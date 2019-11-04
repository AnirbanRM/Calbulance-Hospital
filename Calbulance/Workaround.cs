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
using Newtonsoft.Json;
using Amazon.S3;
using Amazon.S3.Transfer;
using System.Threading;

namespace Calbulance
{
    public partial class Workaround : Form
    {
        Thread synchronizethread;

        DataTable prtable = new DataTable();
        DataTable artable = new DataTable();
        DataTable drtable = new DataTable();

        DataTable AmbulanceList = new DataTable();
        DataTable DriverList = new DataTable();

        DataTable OngoingList = new DataTable();
        DataTable OngoingListOriginal = new DataTable();

        DataTable pend_app_table = new DataTable();
        DataTable appr_app_table = new DataTable();

        String REG_NO = "";
        String ADMIN = "";
        String ADMIN_PASSWORD = "";
        String PERMISSIONS = "";

        //S3 Values
        String bucketname = "data.calbulance";
        String access_id = "AKIAQ73NJTIRWVCR2WYC";
        String access_key = "+iomVJ8EQalKcD1z2tQWUTGkLTuVokItrCEM7ne1";
        public Workaround(String a, String b, String c,String d)
        {
            REG_NO = a;
            ADMIN = b;
            ADMIN_PASSWORD = c;
            PERMISSIONS = d;
            InitializeComponent();
        }

        class Ambulance
        {
            private String VehicleId;
            private String VehicleNo;
            private String VehicleModel;
            private String VehicleDes;
            public Ambulance(String vid, String vno, String vmod, String vdes)
            {
                this.VehicleId = vid;
                this.VehicleNo = vno;
                this.VehicleModel = vmod;
                this.VehicleDes = vdes;
            }
            public String getVehicleNo() { return this.VehicleNo; }
            public String getVehicleId() { return this.VehicleId; }
            public String getVehicleModel() { return this.VehicleModel; }
            public String getVehicleDescription() { return this.VehicleDes; }
        }

        class Driver
        {
            private String fname;
            private String address;
            private String drivelic;
            private String empid;
            private String contactno;
            private String dob;
            public Driver(String fname, String address, String drivelic, String empid, String contactno, String dob)
            {
                this.fname = fname;
                this.address = address;
                this.drivelic = drivelic;
                this.empid = empid;
                this.contactno = contactno;
                this.dob = dob;
            }
            public String getfname() { return this.fname; }
            public String getaddress() { return this.address; }
            public String getdrivelic() { return this.drivelic; }
            public String getempid() { return this.empid; }
            public String getcontact() { return this.contactno; }
            public String getdob() { return this.dob; }
        }

        void resizeColumnsofTables(String a = "11111")
        {
            //Requests
            if(a.ToCharArray()[0]=='1')
            {
                int[] WidthMap = { 120, 180, 300, 450, 120 };
                for (int i = 0; i < 5; i++)
                {
                    DataGridViewColumn temp;
                    if (prtab.InvokeRequired)
                        prtab.Invoke(new Action(()=> {
                            temp = prtab.Columns[i];
                            temp.Width = WidthMap[i];
                        }));
                    else
                    {
                        temp = prtab.Columns[i];
                        temp.Width = WidthMap[i];
                    }

                    if (artab.InvokeRequired)
                        artab.Invoke(new Action(()=> {
                            temp = artab.Columns[i];
                            temp.Width = WidthMap[i];
                        }));
                    else
                    {
                        temp = artab.Columns[i];
                        temp.Width = WidthMap[i];
                    }

                    if (drtab.InvokeRequired)
                        drtab.Invoke(new Action(()=> {
                            temp = drtab.Columns[i];
                            temp.Width = WidthMap[i];
                        }));
                    else
                    {
                        temp = drtab.Columns[i];
                        temp.Width = WidthMap[i];
                    }
                }
            }
            //------------------
            //Ambulances
            if (a.ToCharArray()[1] == '1')
            {
                int[] WidthMap = { 100, 150, 150, 250, 489 };
                DataGridViewColumn temp;
                for (int i = 0; i < 5; i++)
                {
                   if (ambu_tabview.InvokeRequired)
                   {
                        ambu_tabview.Invoke(new Action(() =>
                        {
                            temp = ambu_tabview.Columns[i];
                            temp.Width = WidthMap[i];
                        }));
                   }
                   else{
                        temp = ambu_tabview.Columns[i];
                        temp.Width = WidthMap[i];
                   }
                }
            }
            //------------------
            //Drivers
            if (a.ToCharArray()[2] == '1')
            {
                int[] WidthMap = { 100, 220, 300, 100, 155,110,150 };
                
                DataGridViewColumn temp;
                for (int i = 0; i < 7; i++)
                {
                    if (driver_tableview.InvokeRequired)
                    {
                        driver_tableview.Invoke(new Action(() =>
                        {
                            temp = driver_tableview.Columns[i];
                            temp.Width = WidthMap[i];
                        }));
                    }
                    else{
                        temp = driver_tableview.Columns[i];
                        temp.Width = WidthMap[i];
                    }
                }                
            }
            //Ongoing List
            if (a.ToCharArray()[3] == '1')
            {
                int[] WidthMap = { 50,120, 150, 250, 120, 200, 200 };
                for (int i = 0; i < 7; i++)
                {
                    DataGridViewColumn temp;
                    if (ongoing_req_data_grid_view.InvokeRequired)
                    {
                        ongoing_req_data_grid_view.Invoke(new Action(() =>
                        {
                            temp = ongoing_req_data_grid_view.Columns[i];
                            temp.Width = WidthMap[i];
                        }));
                    }
                    else
                    {
                        temp = ongoing_req_data_grid_view.Columns[i];
                        temp.Width = WidthMap[i];
                    }
                }
            }
            //Appointments
            if (a.ToCharArray()[4] == '1')
            {
                int[] WidthMap = { 50, 120, 180, 200, 120, 210, 180, 120 };
                for (int i = 0; i < 8; i++)
                {
                    DataGridViewColumn temp;
                    if (papr.InvokeRequired)
                        papr.Invoke(new Action(() => {
                            temp = papr.Columns[i];
                            temp.Width = WidthMap[i];
                        }));
                    else
                    {
                        temp = papr.Columns[i];
                        temp.Width = WidthMap[i];
                    }

                    if (apapr.InvokeRequired)
                        apapr.Invoke(new Action(() => {
                            temp = apapr.Columns[i];
                            temp.Width = WidthMap[i];
                        }));
                    else
                    {
                        temp = apapr.Columns[i];
                        temp.Width = WidthMap[i];
                    }
                }
            }
        }

        private async void getInventoriesAmbulance()
        {
            String HospitalId = REG_NO;
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "HospitalId", REG_NO }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {response = await thisclient.PostAsync("http://3.14.219.83/APIs/getAmbulances.php", urlparam);}
                catch (HttpRequestException) { response = null; }
            
                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get list. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                AmbulanceList.Clear();
                foreach (var ambulance in json_obj.Ambulances)
                {
                    AmbulanceList.Rows.Add(ambulance.AmbRegID, 
                                           ambulance.AmbID, 
                                           ambulance.AmbNo, 
                                           ambulance.AmbModel, 
                                           ambulance.AmbDes);
                }
                if (ambu_tabview.InvokeRequired)
                {
                    ambu_tabview.Invoke(new Action(() =>
                    { ambu_tabview.DataSource = AmbulanceList;}));
                    resizeColumnsofTables("01000");
                }
                ViewOriginalNameinOngoingList();
            }
        }

        private async void getInventoriesDrivers()
        {
            String HospitalId = REG_NO;

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "HospitalId", REG_NO }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/getDrivers.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get list. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                DriverList.Clear();
                foreach (var driver in json_obj.Drivers)
                {
                    DriverList.Rows.Add(driver.DriverRegID, 
                                        driver.Name, 
                                        driver.Address,
                                        onlydate(driver.DOB),
                                        driver.License,
                                        driver.Contact,
                                        driver.EID);
                }
                if (driver_tableview.InvokeRequired)
                {
                    driver_tableview.Invoke(new Action(() =>
                    { driver_tableview.DataSource = DriverList; }));
                    resizeColumnsofTables("00100");
                }
                ViewOriginalNameinOngoingList();
            }
        }

        private object onlydate(dynamic dOB)
        {
            int v = 0;
            char[] temp = dOB.ToString().ToCharArray(), result="          ".ToCharArray();
            for (int i = 0; i <= 9; i++)
                result[v++] = temp[i];
            return new String(result);
        }

        private async void getRequests()
        {
            String HospitalId = REG_NO;

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "HospitalId", REG_NO },
                        { "Administrator", ADMIN },
                        { "Password", ADMIN_PASSWORD }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/getRequests.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get requests. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                prtable.Clear();
                artable.Clear();
                drtable.Clear();
                foreach (var request in json_obj.Requests)
                {
                    if (request.Status.ToString().Equals("P"))
                        prtable.Rows.Add(request.Req_Id.ToString(), 
                                        request.DateTime.ToString(), 
                                        request.PatientName.ToString(), 
                                        request.Address.ToString(),
                                        request.Contact.ToString());

                    if (request.Status.ToString().Equals("A"))
                        artable.Rows.Add(request.Req_Id.ToString(), 
                                         request.DateTime.ToString(), 
                                         request.PatientName.ToString(),
                                         request.Address.ToString(),
                                         request.Contact.ToString());

                    if (request.Status.ToString().Equals("D"))
                        drtable.Rows.Add(request.Req_Id.ToString(), 
                                         request.DateTime.ToString(),
                                         request.PatientName.ToString(),
                                         request.Address.ToString(),
                                         request.Contact.ToString());
                }
                if (prtab.InvokeRequired)
                {
                    prtab.Invoke(new Action(() =>
                    { prtab.DataSource = prtable; }));
                }
                if (artab.InvokeRequired)
                {
                    artab.Invoke(new Action(() =>
                    { artab.DataSource = artable; }));
                }
                if (drtab.InvokeRequired)
                {
                    drtab.Invoke(new Action(() =>
                    { drtab.DataSource = drtable; }));
                    resizeColumnsofTables("10000");
                }

            }
        }

        private async void getAppointments()
        {
            String HospitalId = REG_NO;

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "HospitalId", REG_NO },
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/getAppointments.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get requests. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                pend_app_table.Clear();
                appr_app_table.Clear();
                foreach (var appointment in json_obj.Appointments)
                {
                    if (appointment.Status.ToString().Equals("P"))
                        pend_app_table.Rows.Add(appointment.App_Id.ToString(),
                                        appointment.DateTime.ToString(),
                                        appointment.PatientName.ToString(),
                                        appointment.Address.ToString(),
                                        appointment.Contact.ToString(),
                                        appointment.Doctor.ToString(),
                                        appointment.DoctorType.ToString(),
                                        appointment.AppointmentDateTime.ToString());

                    if (appointment.Status.ToString().Equals("A"))
                        appr_app_table.Rows.Add(appointment.App_Id.ToString(),
                                        appointment.DateTime.ToString(),
                                        appointment.PatientName.ToString(),
                                        appointment.Address.ToString(),
                                        appointment.Contact.ToString(),
                                        appointment.Doctor.ToString(),
                                        appointment.DoctorType.ToString(),
                                        appointment.AppointmentDateTime.ToString());
                }
                if (papr.InvokeRequired)
                {
                    papr.Invoke(new Action(() =>
                    { papr.DataSource = pend_app_table; }));
                }
                if (apapr.InvokeRequired)
                {
                    apapr.Invoke(new Action(() =>
                    { apapr.DataSource = appr_app_table; }));
                    resizeColumnsofTables("00001");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salute.Text = ADMIN;
            searchbox.ForeColor = Color.Gray;
            searchbox.Text = "Search";
            searchbox.GotFocus += Searchbox_GotFocus;
            searchbox.LostFocus += Searchbox_LostFocus;

            //Pending Request Table Initialization
            prtable.Columns.Add("Request ID", typeof(String));
            prtable.Columns.Add("Date / Time", typeof(String));
            prtable.Columns.Add("Patient Name", typeof(String));
            prtable.Columns.Add("Address", typeof(String));
            prtable.Columns.Add("Contact No.", typeof(String));
            prtab.DataSource = prtable;
            prtab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //-------------------------------------

            //Approved Request Table Initialization
            artable.Columns.Add("Request ID", typeof(String));
            artable.Columns.Add("Date / Time", typeof(String));
            artable.Columns.Add("Patient Name", typeof(String));
            artable.Columns.Add("Address", typeof(String));
            artable.Columns.Add("Contact No.", typeof(String));
            artab.DataSource = artable;
            artab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //-------------------------------------

            //Declined Request Table Initialization
            drtable.Columns.Add("Request ID", typeof(String));
            drtable.Columns.Add("Date / Time", typeof(String));
            drtable.Columns.Add("Patient Name", typeof(String));
            drtable.Columns.Add("Address", typeof(String));
            drtable.Columns.Add("Contact No.", typeof(String));
            drtab.DataSource = drtable;
            drtab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //-------------------------------------

            //Pending Appointment Table Initialization
            pend_app_table.Columns.Add("Appointment ID", typeof(String));
            pend_app_table.Columns.Add("Date / Time", typeof(String));
            pend_app_table.Columns.Add("Patient Name", typeof(String));
            pend_app_table.Columns.Add("Address", typeof(String));
            pend_app_table.Columns.Add("Contact No.", typeof(String));
            pend_app_table.Columns.Add("Doctor", typeof(String));
            pend_app_table.Columns.Add("Doctor Type", typeof(String));
            pend_app_table.Columns.Add("Appointment Date/Time", typeof(String));
            papr.DataSource = pend_app_table;

            //-------------------------------------

            //Approved Appointment Table Initialization
            appr_app_table.Columns.Add("Appointment ID", typeof(String));
            appr_app_table.Columns.Add("Date / Time", typeof(String));
            appr_app_table.Columns.Add("Patient Name", typeof(String));
            appr_app_table.Columns.Add("Address", typeof(String));
            appr_app_table.Columns.Add("Contact No.", typeof(String));
            appr_app_table.Columns.Add("Doctor", typeof(String));
            appr_app_table.Columns.Add("Doctor Type", typeof(String));
            appr_app_table.Columns.Add("Appointment Date/Time", typeof(String));
            apapr.DataSource = appr_app_table;

            //-------------------------------------

            //Ambulances Table
            AmbulanceList.Columns.Add("Registration ID", typeof(String));
            AmbulanceList.Columns.Add("Vehicle ID", typeof(String));
            AmbulanceList.Columns.Add("Vehicle No.", typeof(String));
            AmbulanceList.Columns.Add("Vehicle Model", typeof(String));
            AmbulanceList.Columns.Add("Vehicle Description", typeof(String));
            ambu_tabview.DataSource = AmbulanceList;
            ambu_tabview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //---------------------

            //Driver Table
            DriverList.Columns.Add("Registration ID", typeof(String));
            DriverList.Columns.Add("Full Name", typeof(String));
            DriverList.Columns.Add("Address", typeof(String));
            DriverList.Columns.Add("DOB", typeof(String));
            DriverList.Columns.Add("Driving License No.", typeof(String));
            DriverList.Columns.Add("Contact No.", typeof(String));
            DriverList.Columns.Add("Employee ID", typeof(String));
            driver_tableview.DataSource = DriverList;
            driver_tableview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //----------------------

            //Ongoing Table Original
            OngoingListOriginal.Columns.Add("RegID", typeof(String));
            OngoingListOriginal.Columns.Add("Date/Time", typeof(String));
            OngoingListOriginal.Columns.Add("Patient Name", typeof(String));
            OngoingListOriginal.Columns.Add("Patient Address", typeof(String));
            OngoingListOriginal.Columns.Add("Patient Contact", typeof(String));
            OngoingListOriginal.Columns.Add("Ambulance No.", typeof(String));
            OngoingListOriginal.Columns.Add("Ambulance Driver", typeof(String));

            //Ongoing Table
            OngoingList.Columns.Add("RegID",typeof(String));
            OngoingList.Columns.Add("Date/Time", typeof(String));
            OngoingList.Columns.Add("Patient Name", typeof(String));
            OngoingList.Columns.Add("Patient Address", typeof(String));
            OngoingList.Columns.Add("Patient Contact", typeof(String));
            OngoingList.Columns.Add("Ambulance No.", typeof(String));
            OngoingList.Columns.Add("Ambulance Driver", typeof(String));
            ongoing_req_data_grid_view.DataSource = OngoingList;
            ongoing_req_data_grid_view.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            getRequests();
            getInventoriesAmbulance();
            getInventoriesDrivers();
            getAppointments();
            getOngoing();
            resizeColumnsofTables();
            synchronizethread = new Thread(new ThreadStart(synchronize));
            synchronizethread.Start();
        }

        private async void getOngoing()
        {   
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "HospitalId", REG_NO }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/get_ongoing.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }
                finally { }
                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot register. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                OngoingListOriginal.Clear();
                OngoingList.Clear();
                foreach (var ride in json_obj.Rides)
                {
                    OngoingList.Rows.Add(ride.ID.ToString(),
                                         ride.DateTime.ToString(),
                                         ride.PatientName.ToString(),
                                         ride.PatientAddress.ToString(),
                                         ride.Contact.ToString(),
                                         ride.Ambulance.ToString(),
                                         ride.Driver.ToString());

                    OngoingListOriginal.Rows.Add(ride.ID.ToString(),
                                         ride.DateTime.ToString(),
                                         ride.PatientName.ToString(),
                                         ride.PatientAddress.ToString(),
                                         ride.Contact.ToString(),
                                         ride.Ambulance.ToString(),
                                         ride.Driver.ToString());
                }
                if (ongoing_req_data_grid_view.InvokeRequired)
                {
                    ongoing_req_data_grid_view.Invoke(new Action(() =>
                    { ongoing_req_data_grid_view.DataSource = OngoingList; }));
                    resizeColumnsofTables("00010");
                }
                //Set Real name and number of ambulance and driver
                ViewOriginalNameinOngoingList();
            }
        }

        private void ViewOriginalNameinOngoingList()
        {
            int i = 0;
            foreach (DataRow row in OngoingListOriginal.Rows)
            {
                foreach (DataRow ambrow in AmbulanceList.Rows)
                    if (ambrow.ItemArray[0].ToString().Equals(row.ItemArray[5].ToString()))
                        OngoingList.Rows[i][5] = String.Join("", ambrow.ItemArray[2].ToString(), " (", ambrow.ItemArray[1].ToString(), ")");
                foreach (DataRow drirow in DriverList.Rows)
                    if (drirow.ItemArray[0].ToString().Equals(row.ItemArray[6].ToString()))
                        OngoingList.Rows[i][6] = String.Join("", drirow.ItemArray[1].ToString(), " (", drirow.ItemArray[6].ToString(), ")");
                i += 1;
            }
        }
        
        private void Searchbox_LostFocus(object sender, EventArgs e)
        {
            if (searchbox.Text.Length == 0)
            {
                searchbox.Text = "Search";
                searchbox.ForeColor = Color.Gray;

                //Showing all in Tables
                foreach (DataGridViewRow r in artab.Rows)
                    r.Visible = true;
                foreach (DataGridViewRow r in drtab.Rows)
                    r.Visible = true;
                foreach (DataGridViewRow r in prtab.Rows)
                    r.Visible = true;
                foreach (DataGridViewRow r in ambu_tabview.Rows)
                    r.Visible = true;
                foreach (DataGridViewRow r in driver_tableview.Rows)
                    r.Visible = true;
                foreach (DataGridViewRow r in ongoing_req_data_grid_view.Rows)
                    r.Visible = true;
                foreach (DataGridViewRow r in papr.Rows)
                    r.Visible = true;
                foreach (DataGridViewRow r in apapr.Rows)
                    r.Visible = true;
            }
        }

        private void PrimaryTabSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchbox_TextChanged(null, null);
        }

        private void SecondaryTabSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchbox_TextChanged(null, null);
        }

        private void SecondaryTabSet2_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchbox_TextChanged(null, null);
        }

        private void Searchbox_GotFocus(object sender, EventArgs e)
        {
            if (searchbox.Text.Length != 0 && searchbox.ForeColor == Color.Gray)
            {
                searchbox.Text = "";
                searchbox.ForeColor = Color.Black;
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            if (PrimaryTabSet.SelectedIndex.ToString().Equals("0") && SecondaryTabSet.SelectedIndex.ToString().Equals("0"))
            {
                if (searchbox.ForeColor != Color.Gray)
                {
                    prtab.CurrentCell = null;
                    foreach (DataGridViewRow r in prtab.Rows)
                    {
                        String tuple = String.Join("", r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString());
                        tuple = tuple.ToLower();
                        if (tuple.Contains(searchbox.Text.ToLower()))
                            r.Visible = true;
                        else
                            r.Visible = false;
                    }
                }
            }
            if (PrimaryTabSet.SelectedIndex.ToString().Equals("0") && SecondaryTabSet.SelectedIndex.ToString().Equals("1"))
            {
                if (searchbox.ForeColor != Color.Gray)
                {
                    artab.CurrentCell = null;
                    foreach (DataGridViewRow r in artab.Rows)
                    {
                        String tuple = String.Join("", r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString());
                        tuple = tuple.ToLower();
                        if (tuple.Contains(searchbox.Text.ToLower()))
                            r.Visible = true;
                        else
                            r.Visible = false;
                    }
                }    
            }
            if (PrimaryTabSet.SelectedIndex.ToString().Equals("0") && SecondaryTabSet.SelectedIndex.ToString().Equals("2"))
            {
                if (searchbox.ForeColor != Color.Gray)
                {
                    drtab.CurrentCell = null;
                    foreach (DataGridViewRow r in drtab.Rows)
                    {
                        String tuple = String.Join("", r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString());
                        tuple = tuple.ToLower();
                        if (tuple.Contains(searchbox.Text.ToLower()))
                            r.Visible = true;
                        else
                            r.Visible = false;
                    }
                }
            }
            if (PrimaryTabSet.SelectedIndex.ToString().Equals("1") && SecondaryTabSet2.SelectedIndex.ToString().Equals("0"))
            {
                if (searchbox.ForeColor != Color.Gray)
                {
                    ambu_tabview.CurrentCell = null;
                    foreach (DataGridViewRow r in ambu_tabview.Rows)
                    {
                        String tuple = String.Join("", r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString());
                        tuple = tuple.ToLower();
                        if (tuple.Contains(searchbox.Text.ToLower()))
                            r.Visible = true;
                        else
                            r.Visible = false;
                    }
                }
            }
            if (PrimaryTabSet.SelectedIndex.ToString().Equals("1") && SecondaryTabSet2.SelectedIndex.ToString().Equals("1"))
            {
                if (searchbox.ForeColor != Color.Gray)
                {
                    driver_tableview.CurrentCell = null;
                    foreach (DataGridViewRow r in driver_tableview.Rows)
                    {
                        String tuple = String.Join("", r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[5].Value.ToString(), r.Cells[6].Value.ToString());
                        tuple = tuple.ToLower();
                        if (tuple.Contains(searchbox.Text.ToLower()))
                            r.Visible = true;
                        else
                            r.Visible = false;
                    }
                }
            }
            if (PrimaryTabSet.SelectedIndex.ToString().Equals("2") && SecondaryTabSet3.SelectedIndex.ToString().Equals("0"))
            {
                if (searchbox.ForeColor != Color.Gray)
                {
                    papr.CurrentCell = null;
                    foreach (DataGridViewRow r in papr.Rows)
                    {
                        String tuple = String.Join("", r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[5].Value.ToString(), r.Cells[6].Value.ToString(), r.Cells[7].Value.ToString());
                        tuple = tuple.ToLower();
                        if (tuple.Contains(searchbox.Text.ToLower()))
                            r.Visible = true;
                        else
                            r.Visible = false;
                    }
                }
            }
            if (PrimaryTabSet.SelectedIndex.ToString().Equals("2") && SecondaryTabSet3.SelectedIndex.ToString().Equals("1"))
            {
                if (searchbox.ForeColor != Color.Gray)
                {
                    apapr.CurrentCell = null;
                    foreach (DataGridViewRow r in apapr.Rows)
                    {
                        String tuple = String.Join("", r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[5].Value.ToString(), r.Cells[6].Value.ToString(), r.Cells[7].Value.ToString());
                        tuple = tuple.ToLower();
                        if (tuple.Contains(searchbox.Text.ToLower()))
                            r.Visible = true;
                        else
                            r.Visible = false;
                    }
                }

            }
            if (PrimaryTabSet.SelectedIndex.ToString().Equals("3"))
            {
                if (searchbox.ForeColor != Color.Gray)
                {
                    ongoing_req_data_grid_view.CurrentCell = null;
                    foreach (DataGridViewRow r in ongoing_req_data_grid_view.Rows)
                    {
                        String tuple = String.Join("", r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[5].Value.ToString(), r.Cells[6].Value.ToString());
                        tuple = tuple.ToLower();
                        if (tuple.Contains(searchbox.Text.ToLower()))
                            r.Visible = true;
                        else
                            r.Visible = false;
                    }
                }
            }
        }

        private void CreateAssociation_Click(object sender, EventArgs e)
        {
            if (PERMISSIONS.ToCharArray()[5] == '0')
            {
                MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                return;
            }
            Association assoc = new Association(AmbulanceList, DriverList, REG_NO);
            assoc.ShowDialog();
            if (assoc.DialogResult == DialogResult.OK)
                assoc.Close();
        }

        private void AddAmbulance_Click(object sender, EventArgs e)
        {
            if (PERMISSIONS.ToCharArray()[2] == '0')
            {
                MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                return;
            }
            using (AddAmbulance addambulance = new AddAmbulance())
            {
                if (addambulance.ShowDialog() == DialogResult.OK)
                {
                    Ambulance amb = new Ambulance(addambulance.Vid, 
                                                  addambulance.Vno, 
                                                  addambulance.Vmod, 
                                                  addambulance.Vdes);

                    if (addambulance.Vid != null && addambulance.Vno != null && addambulance.Vmod != null)
                        addaAsync(amb);
                    else AddAmbulance.PerformClick();
                }
            }
        }

        private async void addaAsync(Ambulance amb)
        {
            //Adding to cloud
            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Uploading...";
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
                        { "HospitalId", REG_NO },
                        { "AmbulanceId", amb.getVehicleId() },
                        { "AmbulanceNo", amb.getVehicleNo() },
                        { "AmbulanceModel", amb.getVehicleModel() },
                        { "AmbulanceDescription", amb.getVehicleDescription() }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/addAmbulance.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }
                finally { }
                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot register. Server is busy");
                AmbulanceList.Clear();
                getInventoriesAmbulance();
                resizeColumnsofTables("01000");


                //-------------------Added to cloud------------------------

                formmsg.Close();
            }
        }

        private void AddDriver_Click(object sender, EventArgs e)
        {
            if (PERMISSIONS.ToCharArray()[1] == '0')
            {
                MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                return;
            }
            using (AddDriver driver = new AddDriver())
            {
                if (driver.ShowDialog() == DialogResult.OK)
                {
                    Driver drvr = new Driver(driver.fname, 
                                             driver.address, 
                                             driver.driveLic, 
                                             driver.empid, 
                                             driver.Contact, 
                                             driver.dob);

                    if (drvr.getfname() != "" && drvr.getaddress() != null && drvr.getdrivelic() != null && drvr.getempid() != null && drvr.getcontact() != null && drvr.getdob() != null)
                        AdddAsync(drvr,driver.img,driver.lic_loc);
                    else AddDriver.PerformClick();
                }
            }
        }

        private async void AdddAsync(Driver drvr, string img, string license)
        {
            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Uploading...";
            Form formmsg = new Form();
            formmsg.FormBorderStyle = FormBorderStyle.None;
            formmsg.StartPosition = FormStartPosition.CenterScreen;
            formmsg.BackColor = Color.WhiteSmoke;
            formmsg.SetBounds(0, 0, 250, 70);
            formmsg.Controls.Add(l);
            formmsg.TopMost = true;
            formmsg.Show();

            //POST image and license to S3
            String ext_dp = Path.GetExtension(img);
            String ext_lic = Path.GetExtension(license);

            AmazonS3Client s3Client = new AmazonS3Client(access_id, access_key, Amazon.RegionEndpoint.USEast2);
            var FileTransfer = new TransferUtility(s3Client);

            String dp_filename = String.Join("-", drvr.getempid(), String.Join("", drvr.getdrivelic(), ext_dp));
            dp_filename = escape_slash(dp_filename);
            String key = String.Join("", "Drivers/DP/", REG_NO,"/", dp_filename);
            try {await FileTransfer.UploadAsync(img, bucketname, key);}
            catch (AmazonS3Exception) { }

            String license_filename = String.Join("-", drvr.getempid(), String.Join("", drvr.getdrivelic(), ext_lic));
            license_filename = escape_slash(license_filename);
            key = String.Join("", "Drivers/Driving-License/", REG_NO, "/", license_filename);
            try {await FileTransfer.UploadAsync(license, bucketname, key);}
            catch (AmazonS3Exception) { }

            //--------------------

            //Adding to cloud
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "HospitalId", REG_NO },
                        { "Name", drvr.getfname() },
                        { "Address", drvr.getaddress() },
                        { "DOB", drvr.getdob() },
                        { "License", drvr.getdrivelic() },
                        { "Contact", drvr.getcontact() },
                        { "eid", drvr.getempid() },
                        { "img", dp_filename },
                        { "lic", license_filename }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/addDrivers.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }
                finally { }
                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot register. Server is busy");
                DriverList.Clear();
                getInventoriesDrivers();
                resizeColumnsofTables("00100");


                //-------------------Added to cloud------------------------

                formmsg.Close();

            }
        }

        private string escape_slash(string filename)
        {
            char[] temp = filename.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
                if (temp[i] == '/' || temp[i] == '\\') temp[i] = '_';
            filename = new String(temp) ;
            return filename;
        }
       
        private async void ApproveButton_ClickAsync(object sender, EventArgs e)
        {
            if (PERMISSIONS.ToCharArray()[3] == '0')
            {
                MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                return;
            }
            if (prtab.SelectedRows.Count == 0) return;
            String RequestID = prtab.SelectedRows[0].Cells[0].Value.ToString();
            String PatientName = prtab.SelectedRows[0].Cells[2].Value.ToString();
            String PatientAddress = prtab.SelectedRows[0].Cells[3].Value.ToString();
            String Contact = prtab.SelectedRows[0].Cells[4].Value.ToString();

            ApproveDialog diag = new ApproveDialog(AmbulanceList, DriverList, RequestID,PatientName,PatientAddress,Contact,REG_NO);
            diag.ShowDialog();
            if (diag.DialogResult == DialogResult.OK)
            {
                using (var thisclient = new HttpClient())
                {
                    var postargs = new Dictionary<string, string>
                    {
                        { "ReqID", RequestID },
                        { "command", "APPROVE" }
                    };

                    var urlparam = new FormUrlEncodedContent(postargs);
                    HttpResponseMessage response = null;
                    var responseString = "";
                    try
                    {
                        response = await thisclient.PostAsync("http://3.14.219.83/APIs/approve_decline_request.php", urlparam);
                    }
                    catch (HttpRequestException) { response = null; }

                    if (response != null)
                        responseString = await response.Content.ReadAsStringAsync();
                    else
                        MessageBox.Show("Cannot Approve. Server is busy.");
                }
                prtable.Clear();
                artable.Clear();
                drtable.Clear();
                getRequests();
            }
        }

        private async void approve_appointment_Click(object sender, EventArgs e)
        {
            if (PERMISSIONS.ToCharArray()[4] == '0')
            {
                MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                return;
            }
            if (papr.SelectedRows.Count == 0) return;
            String AppointmentID = papr.SelectedRows[0].Cells[0].Value.ToString();
            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Approving...";
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
                    { "AppointmentID", AppointmentID },
                    { "command", "APPROVE" }
                };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                   response = await thisclient.PostAsync("http://3.14.219.83/APIs/approve_decline_Appointment.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot Approve. Server is busy.");
            }
            getAppointments();
            formmsg.Close();
        }

        private async void decline_appointment_Click(object sender, EventArgs e)
        {
            if (PERMISSIONS.ToCharArray()[4] == '0')
            {
                MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                return;
            }
            if (papr.SelectedRows.Count == 0) return;
            String AppointmentID = papr.SelectedRows[0].Cells[0].Value.ToString();
            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Declining...";
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
                    { "AppointmentID", AppointmentID },
                    { "command", "DECLINE" }
                };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/approve_decline_Appointment.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot Approve. Server is busy.");
            }
            getAppointments();
            formmsg.Close();
        }

        private async void DeclineButton_ClickAsync(object sender, EventArgs e)
        {
            if (PERMISSIONS.ToCharArray()[3] == '0')
            {
                MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                return;
            }
            String RequestID = "";
            foreach (DataGridViewRow r in prtab.SelectedRows)
                RequestID = r.Cells[0].Value.ToString();

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "ReqID", RequestID },
                        { "command", "DECLINE" }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/approve_decline_request.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot Approve. Server is busy.");
            }
            prtable.Clear();
            artable.Clear();
            drtable.Clear();
            getRequests();
        }

        private async void Modify_ClickAsync(object sender, EventArgs e)
        {
            //For Ambulance Modification
            if (SecondaryTabSet2.SelectedIndex.ToString().Equals("0"))
            {
                if (PERMISSIONS.ToCharArray()[2] == '0')
                {
                    MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                    return;
                }
                foreach (DataGridViewRow r in ambu_tabview.SelectedRows)
                {
                    ModifyVehicle vmodform = new ModifyVehicle(r.Cells[0].Value.ToString(),
                                                               r.Cells[2].Value.ToString(),
                                                               r.Cells[1].Value.ToString(),
                                                               r.Cells[3].Value.ToString(),
                                                               r.Cells[4].Value.ToString());

                    vmodform.ShowDialog();
                    if (vmodform.DialogResult == DialogResult.OK)
                    {
                        Label l = new Label();
                        l.SetBounds(57, 28, 150, 20);
                        l.Text = "Updating Database...";
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
                                { "HospitalId", REG_NO },
                                { "RegID", vmodform.regID },
                                { "AmbulanceId", vmodform.Vid },
                                { "AmbulanceNo", vmodform.Vno },
                                { "AmbulanceModel", vmodform.Vmod },
                                { "AmbulanceDescription", vmodform.Vdes }
                            };

                            var urlparam = new FormUrlEncodedContent(postargs);
                            HttpResponseMessage response = null;
                            var responseString = "";
                            try
                            {
                                response = await thisclient.PostAsync("http://3.14.219.83/APIs/modifyAmbulance.php", urlparam);
                            }
                            catch (HttpRequestException) { response = null; }
                            finally { }
                            if (response != null)
                                responseString = await response.Content.ReadAsStringAsync();
                            else
                                MessageBox.Show("Cannot register. Server is busy");
                            AmbulanceList.Clear();
                            getInventoriesAmbulance();
                            resizeColumnsofTables();
                        }
                        formmsg.Close();
                    }
                }
            }

            //For driver modification
            if (SecondaryTabSet2.SelectedIndex.ToString().Equals("1"))
            {
                if (PERMISSIONS.ToCharArray()[1] == '0')
                {
                    MessageBox.Show("Sorry, You don't have sufficient Priviledges");
                    return;
                }
                foreach (DataGridViewRow r in driver_tableview.SelectedRows)
                {
                    ModifyDriver dmodform = new ModifyDriver(r.Cells[0].Value.ToString(), 
                                                             r.Cells[1].Value.ToString(), 
                                                             r.Cells[2].Value.ToString(), 
                                                             r.Cells[3].Value.ToString(), 
                                                             r.Cells[4].Value.ToString(), 
                                                             r.Cells[5].Value.ToString(), 
                                                             r.Cells[6].Value.ToString(),REG_NO);
                    dmodform.ShowDialog();
                    if (dmodform.DialogResult == DialogResult.OK)
                    {
                        Label l = new Label();
                        l.SetBounds(57, 28, 150, 20);
                        l.Text = "Updating Database...";
                        Form formmsg = new Form();
                        formmsg.FormBorderStyle = FormBorderStyle.None;
                        formmsg.StartPosition = FormStartPosition.CenterScreen;
                        formmsg.BackColor = Color.WhiteSmoke;
                        formmsg.SetBounds(0, 0, 250, 70);
                        formmsg.Controls.Add(l);
                        formmsg.TopMost = true;
                        formmsg.Show();

                        String Prev_dp_file = "";
                        String Prev_lic_file = "";
                        using (var thisclient = new HttpClient())
                        {
                            var postargs = new Dictionary<string, string>
                                {
                                    { "DriverRegID", dmodform.RegNo },
                                };
                            var urlparam = new FormUrlEncodedContent(postargs);
                            HttpResponseMessage response = null;
                            var responseString = "";
                            try
                            { response = await thisclient.PostAsync("http://3.14.219.83/APIs/getDriverimgname.php", urlparam); }
                            catch (HttpRequestException) { response = null; }
                            finally { }
                            if (response != null) responseString = await response.Content.ReadAsStringAsync();
                            else MessageBox.Show("Cannot download. Server is busy");

                            var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                            Prev_dp_file = json_obj.DP.ToString();
                            Prev_lic_file = json_obj.LIC.ToString();
                        }
                        bool img_changed = false,lic_changed = false;
                        if (dmodform.img != "")
                        {
                            img_changed = true;
                            //Delete Image
                            AmazonS3Client s3Client = new AmazonS3Client(access_id, access_key, Amazon.RegionEndpoint.USEast2);
                            String key = String.Join("", "Drivers/DP/", REG_NO, "/", Prev_dp_file);
                            await s3Client.DeleteObjectAsync(bucketname, key);
                            //--------------------------

                            //Add image
                            var FileTransfer = new TransferUtility(s3Client);
                            String dp_filename = String.Join("-", dmodform.EID, String.Join("", dmodform.License, Path.GetExtension(dmodform.img)));
                            dp_filename = escape_slash(dp_filename);
                            key = String.Join("", "Drivers/DP/", REG_NO, "/", dp_filename);
                            try { await FileTransfer.UploadAsync(dmodform.img, bucketname, key); }
                            catch (AmazonS3Exception) { }
                        }

                        if (dmodform.lic != "")
                        {
                            lic_changed = true;
                            //Delete Image
                            AmazonS3Client s3Client = new AmazonS3Client(access_id, access_key, Amazon.RegionEndpoint.USEast2);
                            String key = String.Join("", "Drivers/Driving-License/", REG_NO, "/", Prev_lic_file);
                            await s3Client.DeleteObjectAsync(bucketname, key);

                            //Add image
                            var FileTransfer = new TransferUtility(s3Client);
                            String lic_filename = String.Join("-", dmodform.EID, String.Join("", dmodform.License, Path.GetExtension(dmodform.lic)));
                            lic_filename = escape_slash(lic_filename);
                            key = String.Join("", "Drivers/Driving-License/", REG_NO, "/", lic_filename);
                            try { await FileTransfer.UploadAsync(dmodform.lic, bucketname, key); }
                            catch (AmazonS3Exception) { }
                        }
                        //Update database
                        using (var thisclient = new HttpClient())
                        {
                            String a="", b="";
                            if (img_changed == true) a = escape_slash(String.Join("-", dmodform.EID, String.Join("", dmodform.License, Path.GetExtension(dmodform.img))));
                            if (lic_changed == true) b = escape_slash(String.Join("-", dmodform.EID, String.Join("", dmodform.License, Path.GetExtension(dmodform.lic))));
                            var postargs = new Dictionary<string, string>
                            {
                                { "RegID", dmodform.RegNo },
                                { "Name", dmodform.DriverName },
                                { "Address", dmodform.Address },
                                { "License", dmodform.License },
                                { "empid", dmodform.EID },
                                { "Contact", dmodform.Contact },
                                { "DOB", dmodform.DOB },
                                { "dp_filename", a },
                                { "lic_filename", b }
                            };

                            var urlparam = new FormUrlEncodedContent(postargs);
                            HttpResponseMessage response = null;
                            var responseString = "";
                            try
                            {
                                response = await thisclient.PostAsync("http://3.14.219.83/APIs/modifyDriver.php", urlparam);
                            }
                            catch (HttpRequestException) { response = null; }
                            finally { }
                            if (response != null)
                                responseString = await response.Content.ReadAsStringAsync();
                            else
                                MessageBox.Show("Cannot register. Server is busy");
                        }
                        formmsg.Close();
                        DriverList.Clear();
                        getInventoriesDrivers();
                        resizeColumnsofTables();
                    }
                }
            }
        }

        private async void DeleteRec_ClickAsync(object sender, EventArgs e)
        {
            if (SecondaryTabSet2.SelectedIndex.ToString().Equals("0"))
            {
                foreach (DataGridViewRow r in ambu_tabview.SelectedRows)
                {
                    String regid = r.Cells[0].Value.ToString();
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
                    using (var thisclient = new HttpClient())
                    {
                        var postargs = new Dictionary<string, string>
                        {
                            { "RegId", regid }
                        };
                        var urlparam = new FormUrlEncodedContent(postargs);
                        HttpResponseMessage response = null;
                        var responseString = "";
                        try
                        {
                            response = await thisclient.PostAsync("http://3.14.219.83/APIs/deleteAmbulance.php", urlparam);
                        }
                        catch (HttpRequestException) { response = null; }
                        finally { }
                        if (response != null)
                            responseString = await response.Content.ReadAsStringAsync();
                        else
                            MessageBox.Show("Cannot register. Server is busy");
                        AmbulanceList.Clear();
                        getInventoriesAmbulance();
                        resizeColumnsofTables();
                    }
                    formmsg.Close();
                }
            }

            if (SecondaryTabSet2.SelectedIndex.ToString().Equals("1"))
            {
                foreach (DataGridViewRow r in driver_tableview.SelectedRows)
                {
                    String regid = r.Cells[0].Value.ToString();
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
                    using (var thisclient = new HttpClient())
                    {
                        var postargs = new Dictionary<string, string>
                        {
                            { "RegId", regid }
                        };
                        var urlparam = new FormUrlEncodedContent(postargs);
                        HttpResponseMessage response = null;
                        var responseString = "";
                        try
                        {
                            response = await thisclient.PostAsync("http://3.14.219.83/APIs/deleteDriver.php", urlparam);
                        }
                        catch (HttpRequestException) { response = null; }
                        finally { }
                        if (response != null)
                            responseString = await response.Content.ReadAsStringAsync();
                        else
                            MessageBox.Show("Cannot register. Server is busy");

                        //Delete from S3
                        
                        var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);
                        String dp = json_obj.DP.ToString();
                        String lic = json_obj.LIC.ToString();

                        AmazonS3Client s3Client = new AmazonS3Client(access_id, access_key, Amazon.RegionEndpoint.USEast2);

                        String key = String.Join("", "Drivers/DP/", REG_NO, "/", dp);
                        s3Client.DeleteObject(bucketname, key);

                        key = String.Join("", "Drivers/Driving-License/", REG_NO, "/", lic);
                        s3Client.DeleteObject(bucketname, key);

                        DriverList.Clear();
                        getInventoriesDrivers();
                        resizeColumnsofTables();
                    }
                    formmsg.Close();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account acc_form = new Account(REG_NO,ADMIN,PERMISSIONS);
            acc_form.ShowDialog();
        }

        private async void synchronize()
        {
            String MD5_Requests = "", MD5_Drivers = "", MD5_Ambulances = "", MD5_Appointments = "", MD5_Ongoing = "";

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                        {
                            { "Hospital", REG_NO }
                        };
                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                {
                    response = await thisclient.PostAsync("http://3.14.219.83/APIs/getMD5Digests.php", urlparam);
                }
                catch (HttpRequestException) { response = null; }
                finally { }
                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot refresh. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);

                MD5_Requests = json_obj.MD5_Requests.ToString();
                MD5_Ambulances = json_obj.MD5_Ambulances.ToString();
                MD5_Drivers = json_obj.MD5_Drivers.ToString();
                MD5_Appointments = json_obj.MD5_Appointments.ToString();
                MD5_Ongoing = json_obj.MD5_Ongoing.ToString();
            }
            Thread.Sleep(5000);

            while (true)
            {
                using (var thisclient = new HttpClient())
                {
                    var postargs = new Dictionary<string, string>
                        {
                            { "Hospital", REG_NO }
                        };
                    var urlparam = new FormUrlEncodedContent(postargs);
                    HttpResponseMessage response = null;
                    var responseString = "";
                    try
                    {
                        response = await thisclient.PostAsync("http://3.14.219.83/APIs/getMD5Digests.php", urlparam);
                    }
                    catch (HttpRequestException) { response = null; }
                    finally { }
                    if (response != null)
                        responseString = await response.Content.ReadAsStringAsync();
                    else
                        MessageBox.Show("Cannot refresh. Server is busy");

                    var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);

                    if (!MD5_Requests.Equals(json_obj.MD5_Requests.ToString()))
                    {
                        MD5_Requests = json_obj.MD5_Requests.ToString();
                        if (prtab.InvokeRequired)
                            prtab.Invoke(new Action(()=> { prtab.DataSource = null; }));
                        if (artab.InvokeRequired)
                            artab.Invoke(new Action(() => { artab.DataSource = null; }));
                        if (drtab.InvokeRequired)
                            drtab.Invoke(new Action(() => { drtab.DataSource = null; }));
                        getRequests();
                    }

                    if (!MD5_Drivers.Equals(json_obj.MD5_Drivers.ToString()))
                    {
                        MD5_Drivers = json_obj.MD5_Drivers.ToString();
                        if (driver_tableview.InvokeRequired)
                            driver_tableview.Invoke(new Action(() => { driver_tableview.DataSource = null; }));
                        getInventoriesDrivers();
                    }

                    if (!MD5_Ambulances.Equals(json_obj.MD5_Ambulances.ToString()))
                    {
                        MD5_Ambulances = json_obj.MD5_Ambulances.ToString();
                        if (ambu_tabview.InvokeRequired)
                            ambu_tabview.Invoke(new Action(()=> {ambu_tabview.DataSource = null;}));
                        getInventoriesAmbulance();
                    }

                    if (!MD5_Ongoing.Equals(json_obj.MD5_Ongoing.ToString()))
                    {
                        MD5_Ongoing = json_obj.MD5_Ongoing.ToString();
                        if (ongoing_req_data_grid_view.InvokeRequired)
                            ongoing_req_data_grid_view.Invoke(new Action(()=> { ongoing_req_data_grid_view.DataSource = null; }));
                        getOngoing();
                    }

                    if (!MD5_Appointments.Equals(json_obj.MD5_Appointments.ToString()))
                    {
                        MD5_Appointments = json_obj.MD5_Appointments.ToString();
                        if (papr.InvokeRequired)
                            papr.Invoke(new Action(() => { papr.DataSource = null; }));
                        if (apapr.InvokeRequired)
                            apapr.Invoke(new Action(() => { apapr.DataSource = null; }));
                        getAppointments();
                    }
                }
                Thread.Sleep(5000);
            }
        }

    }
}