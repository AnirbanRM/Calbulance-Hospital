using Amazon.S3;
using Amazon.S3.Transfer;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calbulance
{
    public partial class CreateHospitalAccount : Form
    {
        //S3 Values
        String bucketname = "data.calbulance";
        String access_id = "AKIAQ73NJTIRWVCR2WYC";
        String access_key = "+iomVJ8EQalKcD1z2tQWUTGkLTuVokItrCEM7ne1";

        String govt_lic="", prop_pap="", reg_proof="", address_proof="", icon_file="";
        List<String> awards_and_certs = new List<string> { };

        //Map Pointer
        PointLatLng point;
        DataTable doctors = new DataTable();

        public String m_u = "", Hospital_ID = "", m_p = "";

        public CreateHospitalAccount()
        {
            InitializeComponent();
            doctors.Columns.Add("Doctor Name", typeof(String));
            doctors.Columns.Add("Doctor Type", typeof(String));
        }

        private void CreateHospitalAccount_Load(object sender, EventArgs e)
        {
            Map.MapProvider = GMapProviders.OpenStreetMap ;
            Map.DragButton = MouseButtons.Left;
            Map.Zoom = 1;
            Map.ShowCenter = false;
            lat_box.Text = Map.Position.Lat.ToString();
            lon_box.Text = Map.Position.Lng.ToString();

        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
                point = Map.FromLocalToLatLng(e.X, e.Y);
                Map.Overlays.Clear();
                Map.Position = point;
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.purple_small);
                GMapOverlay gMapOverlay = new GMapOverlay();
                gMapOverlay.Markers.Add(marker);
                Map.Overlays.Add(gMapOverlay);
                lat_box.Text = Map.Position.Lat.ToString();
                lon_box.Text = Map.Position.Lng.ToString();
        }

        private void Map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Map.Zoom = Map.Zoom+1;
        }

        private void LocationSearch_Click(object sender, EventArgs e)
        {
            Map.Overlays.Clear();
            Map.SetPositionByKeywords(Location_String.Text.ToString());
            point= Map.Position;
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.purple_small);
            GMapOverlay gMapOverlay = new GMapOverlay();
            gMapOverlay.Markers.Add(marker);
            Map.Overlays.Add(gMapOverlay);
            Map.Zoom = 15;
            lat_box.Text = Map.Position.Lat.ToString();
            lon_box.Text = Map.Position.Lng.ToString();
        }

        private void Location_String_KeyDown(object sender, KeyEventArgs e)
        { if (e.KeyValue == (char)Keys.Return) LocationSearch.PerformClick(); }

        private void HName_Leave(object sender, EventArgs e)
        {
            Location_String.Text = HName.Text;
            LocationSearch.PerformClick();
        }

        private async void proceed_Click(object sender, EventArgs e)
        {
            if (!check_validity())
                return;
            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Uploading to server...";
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
                        { "HName", HName.Text },
                        { "RName", RName.Text },
                        { "Owner", Owner_na.Text },
                        { "Year", Yearofestb.Text },
                        { "Land_Area", String.Join(" ", la_num.Text, la_unit.Text) },
                        { "OwnerType", owner_type.Text },
                        { "Address", Address.Text },
                        { "C_Doctors", C_Doctor.Text },
                        { "C_Nurses", C_Nurse.Text },
                        { "C_Wardboys", C_Wardboys.Text },
                        { "C_admin", C_Admin.Text },
                        { "C_HKeep", C_House.Text },
                        { "C_OT", C_OT.Text },
                        { "C_Gen", C_Gen.Text },
                        { "C_ICU", C_ICU.Text },
                        { "C_CCU", C_CCU.Text },
                        { "C_BuildBlocks", C_Blocks.Text },
                        { "Contact", Contact.Text },
                        { "Master_ID", admin_username.Text },
                        { "Master_Pwd", admin_pwd.Text },
                        { "Lat", lat_box.Text },
                        { "Lng", lon_box.Text },
                        { "AmbHrs", ambhrs.Text },
                        { "Website", website.Text }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/create_hospital.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }
                finally { }
                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot register. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                Hospital_ID = json_obj.HID;

                if (!Hospital_ID.Equals("-1"))
                {
                    Amazon.S3.AmazonS3Client s3Client = new AmazonS3Client(access_id, access_key, Amazon.RegionEndpoint.USEast2);
                    var FileTransfer = new TransferUtility(s3Client);

                    //Upload Government License
                    try { await FileTransfer.UploadAsync(govt_lic, bucketname, String.Join("/", "Hospitals", Hospital_ID, "GovtLic", "document.pdf")); }
                    catch (AmazonS3Exception) { }

                    //Upload Property Paper
                    try { await FileTransfer.UploadAsync(prop_pap, bucketname, String.Join("/", "Hospitals", Hospital_ID, "PropertyPaper", "document.pdf")); }
                    catch (AmazonS3Exception) { }

                    //Upload Registration Proof
                    try { await FileTransfer.UploadAsync(reg_proof, bucketname, String.Join("/", "Hospitals", Hospital_ID, "RegistrationProof", "document.pdf")); }
                    catch (AmazonS3Exception) { }

                    //Upload Address Proof
                    try { await FileTransfer.UploadAsync(address_proof, bucketname, String.Join("/", "Hospitals", Hospital_ID, "AddressProof", "document.pdf")); }
                    catch (AmazonS3Exception) { }

                    //Upload Hospital Logo
                    try { await FileTransfer.UploadAsync(icon_file, bucketname, String.Join("/", "Hospitals", Hospital_ID, "Logo", String.Join("", "logo", Path.GetExtension(icon_file)))); }
                    catch (AmazonS3Exception) { }

                    //Upload Certificates and Awards
                    for (int dno = 0; dno < award_and_cert.Items.Count; dno++)
                    {
                        try { await FileTransfer.UploadAsync(award_and_cert.Items[dno].Text.ToString(), bucketname, String.Join("/", "Hospitals", Hospital_ID, "Awards and Certificates", String.Join("", String.Join("-", "Document", (dno + 1).ToString()), Path.GetExtension(award_and_cert.Items[dno].Text.ToString())))); }
                        catch (AmazonS3Exception) { }
                    }
                }
            }

            //Add Doctors
            StringBuilder doctorJSON = new StringBuilder(String.Join("", "{\"HospitalID\":\"", Hospital_ID , "\",\"Doctors\":["));
            foreach(DataRow r in doctors.Rows)
                doctorJSON.Append(String.Join("","{\"Name\":\"", r.ItemArray[0].ToString(),"\",\"Type\":\"", r.ItemArray[1].ToString(),"\"},"));
            String finaldoctorJSON =  String.Join("",doctorJSON.ToString().TrimEnd(','),"]}");

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Doctors", finaldoctorJSON }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/add_doctors.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }
                finally { }
                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot register. Server is busy");
            }
            m_u = admin_username.Text;
            m_p = admin_pwd.Text;
            this.DialogResult = DialogResult.OK;
            formmsg.Close();
            this.Close();
        }

        private void browse_gl_Click(object sender, EventArgs e)
        {
            if (gl_loc_out.Text.ToString().Length == 0)
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "PDF Files|*.pdf;";
                d.ShowDialog();
                govt_lic = d.FileName.ToString();
                gl_loc_out.Text = govt_lic;
                if(govt_lic.Length!=0)
                    browse_gl.Text = "Remove";
            }
            else
            {
                govt_lic = "";
                gl_loc_out.Text = "";
                browse_gl.Text = "Browse";
            }
        }

        private void browse_pp_Click(object sender, EventArgs e)
        {
            if (prop_loc_out.Text.ToString().Length == 0)
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "PDF Files|*.pdf;";
                d.ShowDialog();
                prop_pap = d.FileName.ToString();
                prop_loc_out.Text = prop_pap;
                if (prop_pap.Length != 0)
                    browse_pp.Text = "Remove";
            }
            else
            {
                prop_pap = "";
                prop_loc_out.Text = "";
                browse_pp.Text = "Browse";
            }
        }

        private void add_doctor_Click(object sender, EventArgs e)
        {
            AddModifyDoctors d = new AddModifyDoctors(doctors);
            d.ShowDialog();
            doctors = d.getDoctors();
        }

        private void award_cert_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "PDF Files and Image Files|*.pdf;*.BMP;*.JPG;*.PNG;*.JPEG;";
            d.ShowDialog();
            award_and_cert.Items.Add(d.FileName.ToString());
        }

        private void browse_rp_Click(object sender, EventArgs e)
        {
            if (r_proof_loc_out.Text.ToString().Length == 0)
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "PDF Files|*.pdf;";
                d.ShowDialog();
                reg_proof = d.FileName.ToString();
                r_proof_loc_out.Text = reg_proof;
                if (reg_proof.Length != 0)
                    browse_rp.Text = "Remove";
            }
            else
            {
                reg_proof = "";
                r_proof_loc_out.Text = "";
                browse_rp.Text = "Browse";
            }
        }

        private void browse_ap_Click(object sender, EventArgs e)
        {
            if (ad_proof_loc_out.Text.ToString().Length == 0)
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "PDF Files (*.pdf)|*.pdf;";
                d.ShowDialog();
                address_proof = d.FileName.ToString();
                ad_proof_loc_out.Text = address_proof;
                if (address_proof.Length != 0)
                    browse_ap.Text = "Remove";
            }
            else
            {
                address_proof = "";
                ad_proof_loc_out.Text = "";
                browse_ap.Text = "Browse";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browse_icon_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG;|All files (*.*)|*.*";
            d.ShowDialog();
            icon_file = d.FileName.ToString();
            icon_box.ImageLocation = icon_file;
            icon_box.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private bool check_validity()
        {
            if (!TandCCheckBox.Checked) { MessageBox.Show("Please accept out T&C and Privacy Policy"); return false; }
            String Error="";
            if (HName.Text.Length == 0) Error=String.Join("", Error, " Hospital Name is empty.\n");
            if (RName.Text.Length==0) Error = String.Join("", Error, " Registered Name is empty.\n");
            if(Owner_na.Text.Length==0) Error = String.Join("", Error, " Owner name is empty.\n");
            try { int.Parse(Yearofestb.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " Year of Estb. empty or contains invalid chracters.\n"); }
            if(la_num.Text.Length==0 || la_unit.Text.Length==0) Error=String.Join("", Error, " Invalid land area.\n");
            if(owner_type.Text.Length==0) Error=String.Join("", Error, " Owner type is empty.\n");
            if(Address.Text.Length==0) Error=String.Join("", Error, " Address is empty.\n");
            if (admin_username.Text.Length == 0) Error=String.Join("", Error, " Admin Username is empty.\n");
            if (admin_pwd.Text.Length == 0) Error=String.Join("", Error, " Admin Password is empty.\n");
            try { int.Parse(C_Doctor.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " Doctor count is invalid.\n");}
            try { int.Parse(C_Nurse.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " Nurse count is invalid.\n"); }
            try { int.Parse(C_Wardboys.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " Wardboy count is invalid.\n"); }
            try { int.Parse(C_Admin.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " Admin Staff count is invalid.\n"); }
            try { int.Parse(C_House.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " Housekeeping count is invalid.\n"); }
            try { int.Parse(C_OT.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " Operation Threatre count is invalid.\n"); }
            try { int.Parse(C_Gen.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " General ward count is invalid.\n"); }
            try { int.Parse(C_ICU.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " ICU count is invalid.\n"); }
            try { int.Parse(C_CCU.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " CCU count is invalid.\n"); }
            try { int.Parse(C_Blocks.Text.ToString()); } catch (FormatException) { Error = String.Join("", Error, " Building blocks count is invalid.\n"); }
            if (Contact.Text.Length == 0) Error = String.Join("", Error, " No contact no. provided.\n");
            if (ambhrs.Text.Length == 0) Error = String.Join("", Error, " No Ambulance Hours provided.\n");
            if (website.Text.Length == 0) Error = String.Join("", Error, " Hospital website not provided.\n");
            if (govt_lic.Length==0) Error = String.Join("", Error, " Government License not attached.\n");
            if(prop_pap.Length==0) Error = String.Join("", Error, " Property Paper not attached.\n");
            if (reg_proof.Length == 0) Error = String.Join("", Error, " Registration Proof not attached.\n");
            if (address_proof.Length == 0) Error = String.Join("", Error, " Address Proof not attached.\n");
            if(icon_file.Length==0) Error = String.Join("", Error, " Hospital Logo not attached.\n");
 
            if (Error.Length == 0)
                return true;
            else { MessageBox.Show(Error); return false; }
        }
    }
}

