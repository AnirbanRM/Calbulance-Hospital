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
    public partial class Account : Form
    {
        private String ID { get; set; }
        private String Hospital { get; set; }
        private String Acc_Type = "A";
        private String Permissions = "";
        private String Current_user_Sno="";
        private String Sno = "";

        DataTable OtherUsers = new DataTable();

        public Account(String a, String b, String c)
        {
            InitializeComponent();
            this.ID = b;
            this.Hospital = a;
            this.Permissions = c;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            loginid_value.Text = ID;
            hos_id_value.Text = Hospital;
            get_accounts();
            Permissions_GB.Enabled = false;
            Existing_Accs.DataSource = OtherUsers;
            if (Permissions.ToCharArray()[6] == '0')
                manage_accounts_box.Enabled = false;
        }
        private async void get_accounts()
        {
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "HospitalId", Hospital },
                        { "UserID", ID }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/get_Accounts_Hospital.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);

                HName.Text = json_obj.HName;
                if (json_obj.Acc_Type == "M") acc_type_value.Text = "Master Account";
                else if (json_obj.Acc_Type == "S") acc_type_value.Text = "Standard Account";
                else if (json_obj.Acc_Type == "A") acc_type_value.Text = "Administrator Account";
                if (json_obj.Username == "") username_value.Text = "N/A"; else username_value.Text = json_obj.Username;

                Sno = json_obj.Sno.ToString();
                getOtherAccounts_of_this_Hospital();
            }
        }

        private async void getOtherAccounts_of_this_Hospital()
        {
            OtherUsers.Clear();
            OtherUsers.Columns.Clear();
            if (Permissions.ToCharArray()[6] == '0')
                return;
            OtherUsers.Columns.Add("SNo.", typeof(String));
            OtherUsers.Columns.Add("Username", typeof(String));
            OtherUsers.Columns.Add("LoginID", typeof(String));
            OtherUsers.Columns.Add("Account Type", typeof(String));

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "HospitalId", Hospital }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/get_Other_Users.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);

                foreach (var user in json_obj.Users)
                {
                    if (user.LoginID.ToString().Equals(ID)) continue;
                    String acc_t = "";
                    if (user.Acc_Type == "M") acc_t = "Master";
                    else if (user.Acc_Type == "S") acc_t = "Standard";
                    else if (user.Acc_Type == "A") acc_t = "Administrator";
                    OtherUsers.Rows.Add(user.Sno,
                                        user.Username,
                                        user.LoginID,
                                        acc_t);
                }

                //Resizing Column Width
                Existing_Accs.Columns[0].Visible = false;
                Existing_Accs.Columns[1].Width = 135;
                Existing_Accs.Columns[2].Width = 135;
                Existing_Accs.Columns[3].Width = 100;
            }
        }

        private async void create_account_Click(object sender, EventArgs e)
        {
            if (new_acc_id.Text.ToString() == "" || new_acc_username.Text.ToString() == "") { MessageBox.Show("Empty ID or Username"); return; }
            Label l = new Label();
            l.SetBounds(57, 28, 150, 20);
            l.Text = "Creating Account";
            Form formmsg = new Form();
            formmsg.FormBorderStyle = FormBorderStyle.None;
            formmsg.StartPosition = FormStartPosition.CenterScreen;
            formmsg.BackColor = Color.WhiteSmoke;
            formmsg.SetBounds(0, 0, 250, 70);
            formmsg.Controls.Add(l);
            formmsg.TopMost = true;
            formmsg.Show();

            StringBuilder Permission_String = new StringBuilder("P");
            if (checkBox1.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox2.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox3.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox4.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox5.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox6.Checked) Permission_String.Append("1"); else Permission_String.Append("0");

            if (new_acc_username.Text.Length == 0 || new_acc_id.Text.Length == 0)
            { MessageBox.Show("One or more fields are blank."); return; }

            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Hospital", hos_id_value.Text},
                        { "Username", new_acc_username.Text },
                        { "ID", new_acc_id.Text },
                        { "Acc_Type",Acc_Type },
                        { "PermissionCode",Permission_String.ToString() }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/create_accounts_hospital.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get. Server is busy");
                MessageBox.Show(String.Join("","Password : ", responseString));
                formmsg.Close();
                getOtherAccounts_of_this_Hospital();
                new_acc_username.Text = "";
                new_acc_id.Text = "";
            }
        }

        private void Acc_Type_Radio_CheckedChanged(object sender, EventArgs e)
        {
                if (Acc_Type_Radio.Checked) { Permissions_GB.Enabled = false; Acc_Type = "A"; }
                if (Acc_Type_Radio_2.Checked) { Permissions_GB.Enabled = true; Acc_Type = "S"; }
        }

        private void ModifyAccBut_Click(object sender, EventArgs e)
        {
            OtherUserModify otm = new OtherUserModify(Existing_Accs.SelectedRows[0].Cells[0].Value.ToString());
            otm.ShowDialog();
            if (otm.DialogResult == DialogResult.OK) getOtherAccounts_of_this_Hospital();

        }

        private async void Remove_but_Click(object sender, EventArgs e)
        {
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Sno", Existing_Accs.SelectedRows[0].Cells[0].Value.ToString()}
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/delete_accounts_hospital.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot delete. Server is busy");

                getOtherAccounts_of_this_Hospital();
            }
        }

        private void Curr_user_modify_Click(object sender, EventArgs e)
        {
            CurrentUserModify curr_user_mod = new CurrentUserModify(Sno);
            curr_user_mod.ShowDialog();
            DialogResult t = curr_user_mod.DialogResult;
            if (t==DialogResult.OK)
            {
                username_value.Text = curr_user_mod.Username;
                loginid_value.Text = curr_user_mod.ID;
                Microsoft.Win32.Registry.CurrentUser.DeleteSubKey("Software\\Calbulance\\Account");
                MessageBox.Show("Successfully Updated! You are logged out. Please Re-login!");
                Application.Restart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.Registry.CurrentUser.DeleteSubKey("Software\\Calbulance\\Account");
            MessageBox.Show("Successfully cleared your credentials.");
            Application.Restart();
        }
    }
}
