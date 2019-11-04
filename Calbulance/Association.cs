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
    public partial class Association : Form
    {
        String HID;
        DataTable amb, dri;
        public Association(DataTable a, DataTable b,String HID)
        {
            InitializeComponent();

            this.HID = HID;            
            this.amb = a;
            this.dri = b;

            load_inventory_list();
        }

        private void load_inventory_list()
        {
            DataTable amb_tab = new DataTable();
            DataTable dri_tab = new DataTable();

            amb_tab.Columns.Add("Ambulance", typeof(String));
            amb_tab.Columns.Add("Id", typeof(String));
            dri_tab.Columns.Add("Driver", typeof(String));
            dri_tab.Columns.Add("Id", typeof(String));

            foreach (DataRow r in amb.Rows)
            {
                amb_tab.Rows.Add(String.Join("", r["Vehicle ID"], " (", r["Vehicle No."], ")"), r["Registration ID"]);
            }
            foreach (DataRow r in dri.Rows)
            {
                dri_tab.Rows.Add(String.Join("", r["Full Name"], " (", r["Employee ID"], ")"), r["Registration ID"]);
            }

            ambulance_assoc_view.DataSource = amb_tab;
            driver_assoc_view.DataSource = dri_tab;
            DataGridViewColumn c = ambulance_assoc_view.Columns[0];
            c.Width = 355;
            c = driver_assoc_view.Columns[0];
            c.Width = 355;

            //Hide those are already there
                //See when loading associations
        }

        private async void Association_Load(object sender, EventArgs e)
        {
            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Loading Association...";
            Form formmsg = new Form();
            formmsg.FormBorderStyle = FormBorderStyle.None;
            formmsg.StartPosition = FormStartPosition.CenterScreen;
            formmsg.BackColor = Color.WhiteSmoke;
            formmsg.SetBounds(0, 0, 250, 70);
            formmsg.Controls.Add(l);
            formmsg.TopMost = true;
            formmsg.Show();

            DataTable assocs=new DataTable();
            assocs.Columns.Add("Ambulance", typeof(String));
            assocs.Columns.Add("Driver", typeof(String));
            assocs.Columns.Add("AID", typeof(String));
            assocs.Columns.Add("DID", typeof(String));
            assocs.Columns.Add("RID", typeof(String));

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
                formmsg.Close();

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);

                load_inventory_list();

                foreach  (var o in json_obj.Associations)
                {
                    foreach (DataRow ra in amb.Rows)
                    {
                        if (ra.ItemArray.GetValue(0).ToString().Equals(o.Ambulance.ToString()))
                            foreach (DataRow rd in dri.Rows)
                            {
                                if (rd.ItemArray.GetValue(0).ToString().Equals(o.Driver.ToString()))
                                {
                                    assocs.Rows.Add(String.Join("", ra.ItemArray.GetValue(1), " (", ra.ItemArray.GetValue(2), ")"), String.Join("", rd.ItemArray.GetValue(1), " (", rd.ItemArray.GetValue(6), ")"), ra.ItemArray.GetValue(0), rd.ItemArray.GetValue(0), o.R.ToString());

                                    //For ambulances
                                    ambulance_assoc_view.CurrentCell = null;
                                    driver_assoc_view.CurrentCell = null;
                                    foreach (DataGridViewRow r in ambulance_assoc_view.Rows)
                                        if (r.Cells[1].Value.ToString().Equals(o.Ambulance.ToString()))
                                            r.Visible = false;
                                    //for driver
                                    foreach (DataGridViewRow r in driver_assoc_view.Rows)
                                        if (r.Cells[1].Value.ToString().Equals(o.Driver.ToString()))
                                            r.Visible = false;

                                    
                                }
                            }
                    }
                }
                existing_assoc_data_view.DataSource = assocs;
                DataGridViewColumn c = existing_assoc_data_view.Columns[0];
                c.Width = 372;
                c = existing_assoc_data_view.Columns[1];
                c.Width = 372;
            }
            formmsg.Close();
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            if (existing_assoc_data_view.SelectedRows.Count == 0) {
                MessageBox.Show("No Association selected");
                return;
            }

            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Deleting...";
            Form formmsg = new Form();
            formmsg.FormBorderStyle = FormBorderStyle.None;
            formmsg.StartPosition = FormStartPosition.CenterScreen;
            formmsg.BackColor = Color.WhiteSmoke;
            formmsg.SetBounds(0, 0, 250, 70);
            formmsg.Controls.Add(l);
            formmsg.TopMost = true;
            formmsg.Show();

            String dreg = existing_assoc_data_view.SelectedRows[0].Cells[4].Value.ToString();
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "RegId", dreg }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/deleteAssociation.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get requests. Server is busy");
            }
            formmsg.Close();
            Association_Load(null,null);
        }

        private async void CreateAssociation_Click(object sender, EventArgs e)
        {
            if (driver_assoc_view.SelectedRows.Count == 0 || ambulance_assoc_view.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a pair of driver and ambulance from the list");
                return;
            }

            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Creating Association...";
            Form formmsg = new Form();
            formmsg.FormBorderStyle = FormBorderStyle.None;
            formmsg.StartPosition = FormStartPosition.CenterScreen;
            formmsg.BackColor = Color.WhiteSmoke;
            formmsg.SetBounds(0, 0, 250, 70);
            formmsg.Controls.Add(l);
            formmsg.TopMost = true;
            formmsg.Show();

            String DriRegID =  driver_assoc_view.SelectedRows[0].Cells[1].Value.ToString();
            String AmbRegID =  ambulance_assoc_view.SelectedRows[0].Cells[1].Value.ToString();
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "AmbulanceReg", AmbRegID },
                        { "DriverReg", DriRegID },
                        { "Hospital",HID}
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/createAssociation.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get requests. Server is busy");
                formmsg.Close();
                Association_Load(null, null);
            }
        }
    }
}
