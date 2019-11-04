using Amazon.S3;
using Amazon.S3.Transfer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calbulance
{
    public partial class ModifyDriver : Form
    {
        public String RegNo { get; set; }
        public String DriverName { get; set; }
        public String Address { get; set; }
        public String EID { get; set; }
        public String DOB { get; set; }
        public String License { get; set; }
        public String Contact { get; set; }
        public String img { get; set; }
        public String lic { get; set; }

        String bucketname = "data.calbulance";
        String access_id = "AKIAQ73NJTIRWVCR2WYC";
        String access_key = "+iomVJ8EQalKcD1z2tQWUTGkLTuVokItrCEM7ne1";

        String HospitalID = "";
        public ModifyDriver(String a, String b, String c, String d, String e,String f,String g,String h)
        {
            InitializeComponent();
            this.RegNo = a;
            this.DriverName = b;
            this.Address = c;
            this.License = e;
            this.EID = g;
            this.Contact = f;
            this.DOB = d;
            this.HospitalID = h;
        }

        private async void ModifyDriver_LoadAsync(object sender, EventArgs e)
        {
            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Downloading DP...";
            Form formmsg = new Form();
            formmsg.FormBorderStyle = FormBorderStyle.None;
            formmsg.StartPosition = FormStartPosition.CenterScreen;
            formmsg.BackColor = Color.WhiteSmoke;
            formmsg.SetBounds(0, 0, 250, 70);
            formmsg.Controls.Add(l);
            formmsg.TopMost = true;
            formmsg.Show();
            

            img = ""; lic = "";
            regID.Text = RegNo;
            fname_box.Text = DriverName;
            address_box.Text = Address;
            drivelic_box.Text = License;
            empid_box.Text = EID;
            contact_box.Text = Contact;
            dob_box.Value = DateTime.Parse(correctdateformat(DOB));

            //Download profile picture : 
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "DriverRegID", this.RegNo },
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/getDriverimgname.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }
                finally { }
                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot download. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                
                

                AmazonS3Client s3Client = new AmazonS3Client(access_id, access_key, Amazon.RegionEndpoint.USEast2);
                var FileTransfer = new TransferUtility(s3Client);

                String key = String.Join("","Drivers/DP/",HospitalID,"/", json_obj.DP);
                
                await FileTransfer.DownloadAsync(String.Join("", "%appdata%\\Calbulance\\Temp\\", json_obj.DP.ToString()), bucketname, key);

                dp.ImageLocation = String.Join("", "%appdata%\\Calbulance\\Temp\\", json_obj.DP.ToString());

                //--------------------------
                formmsg.Close();

            }
        }

        private string correctdateformat(string dOB)
        {
            Char[] temp = dOB.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == '-')
                    temp[i] = '/';
            return new string(temp);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modify_Click(object sender, EventArgs e)
        {
            this.DriverName = fname_box.Text;
            this.Address = address_box.Text;
            this.EID = empid_box.Text;
            this.DOB = String.Join("-", dob_box.Value.Year, dob_box.Value.Month, dob_box.Value.Day);
            this.License = drivelic_box.Text;
            this.Contact = contact_box.Text;
            this.Close();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG;|All files (*.*)|*.*";
            d.ShowDialog();
            img = d.FileName.ToString();
            dp.ImageLocation = img;
        }

        private void BrowseLic_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG;|All files (*.*)|*.*";
            d.ShowDialog();
            lic = d.FileName.ToString();
            LicenseLocStr.Text = lic;
        }
    }
}
