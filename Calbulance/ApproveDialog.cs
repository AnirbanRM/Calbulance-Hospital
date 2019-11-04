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
    public partial class ApproveDialog : Form
    {
        DataTable Ambulance, Driver;
        DataTable Associations = new DataTable();
        String RequestID, PatientName, PatientAddress, Contact, HID;

        private void driv_assign_l_SelectedIndexChanged(object sender, EventArgs e)
        {
            String driv = Driver.Rows[driv_assign_l.SelectedIndex].ItemArray[0].ToString();
            if (match_assoc_check.Checked)
            {
                foreach (DataRow r in Associations.Rows)
                    if (r.ItemArray[2].Equals(driv))
                    {
                        String amb = r.ItemArray[1].ToString();
                        int i = 0;
                        foreach (DataRow r2 in Ambulance.Rows)
                        {
                            if (r2.ItemArray[0].Equals(amb))
                                amb_assign_l.SelectedIndex = i;
                            i++;
                        }
                    }
            }
        }

        private void match_assoc_check_CheckedChanged(object sender, EventArgs e)
        {
            amb_assign_l_SelectedIndexChanged(null, null);
        }

        private async void ApproveButton_Click(object sender, EventArgs e)
        {
            String _Driver = Driver.Rows[driv_assign_l.SelectedIndex].ItemArray[0].ToString();
            String _Ambulance = Ambulance.Rows[amb_assign_l.SelectedIndex].ItemArray[0].ToString();

            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Assigning...";
            Form formmsg = new Form();
            formmsg.FormBorderStyle = FormBorderStyle.None;
            formmsg.StartPosition = FormStartPosition.CenterScreen;
            formmsg.BackColor = Color.WhiteSmoke;
            formmsg.SetBounds(0, 0, 250, 70);
            formmsg.Controls.Add(l);
            formmsg.TopMost = true;
            formmsg.Show();

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Hospital", HID },
                        { "Ambulance", _Ambulance },
                        { "Driver", _Driver },
                        { "Patient", PatientName },
                        { "Address", PatientAddress },
                        { "Contact", Contact },
                        { "RequestNo", RequestID }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/approve_request.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get requests. Server is busy");
                formmsg.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ApproveDialog_Load(object sender, EventArgs e)
        {

        }

        private void amb_assign_l_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ambr = Ambulance.Rows[amb_assign_l.SelectedIndex].ItemArray[0].ToString();
            if (match_assoc_check.Checked)
            {
                foreach (DataRow r in Associations.Rows)
                    if (r.ItemArray[1].Equals(ambr))
                    {
                        String driver = r.ItemArray[2].ToString();
                        int i = 0;
                        foreach (DataRow r2 in Driver.Rows)
                        {
                            if (r2.ItemArray[0].Equals(driver))
                                driv_assign_l.SelectedIndex = i;
                            i++;
                        }
                    }
            }
        }

        public ApproveDialog(DataTable a,DataTable b,String c,String d,String e, String f, String g)
        {
            this.Ambulance = a;
            this.Driver = b;
            this.RequestID = c;
            this.PatientName = d;
            this.PatientAddress = e;
            this.Contact = f;
            this.HID = g;

            InitializeComponent();

            get_Associations();
            pat_name.Text = PatientName;
            pat_addr.Text = PatientAddress;
            pat_con.Text = Contact;

            populate_ambulance();
            populate_driver();

        }

        private async void get_Associations()
        {
            //Getting from server
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Hospital", HID }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/getAssociation.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get requests. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);

                Associations.Columns.Add("Reg", typeof(String));
                Associations.Columns.Add("Ambulance", typeof(String));
                Associations.Columns.Add("Driver", typeof(String));

                foreach (var o in json_obj.Associations)
                {
                    Associations.Rows.Add(o.R.ToString(), o.Ambulance.ToString(), o.Driver.ToString());
                }
            }
        }

        private void populate_driver()
        {
            foreach (DataRow r in Driver.Rows)
                driv_assign_l.Items.Add(String.Join("", r.ItemArray[1].ToString(), " (",r.ItemArray[6].ToString(),")"));
        }
        
        private void populate_ambulance()
        {
            foreach (DataRow r in Ambulance.Rows)
                amb_assign_l.Items.Add(String.Join("", r.ItemArray[2].ToString(), " (", r.ItemArray[1].ToString(), ")"));
        }
    }
}
