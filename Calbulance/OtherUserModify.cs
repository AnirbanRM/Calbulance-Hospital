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
    public partial class OtherUserModify : Form
    {
        private String SNO = "";
        private String Acc_Type = "";
        public OtherUserModify(String a)
        {
            InitializeComponent();
            this.SNO = a;
        }

        private void OtherUserModify_Load(object sender, EventArgs e)
        {
            get_account();
        }

        private void setpermission(String perm_str)
        {
            if (perm_str.ToCharArray()[1] == '1') checkBox1.Checked = true;
            if (perm_str.ToCharArray()[2] == '1') checkBox2.Checked = true;
            if (perm_str.ToCharArray()[3] == '1') checkBox3.Checked = true;
            if (perm_str.ToCharArray()[4] == '1') checkBox4.Checked = true;
            if (perm_str.ToCharArray()[5] == '1') checkBox5.Checked = true;
            if (perm_str.ToCharArray()[6] == '1') checkBox6.Checked = true;
        }
        private async void get_account()
        {
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Sno", SNO }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/modify_other_accounts.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);

                username.Text = json_obj.Username.ToString();
                acc_id.Text = json_obj.ID.ToString();
                setpermission(json_obj.PermissionCode.ToString());

                if (json_obj.Acc_Type.ToString().Equals("A")) { Acc_Type_Radio.Checked = true; Acc_Type = "A"; Permissions_GB.Enabled = false; }
                else if (json_obj.Acc_Type.ToString().Equals("S")) { Acc_Type_Radio_2.Checked = true; Acc_Type = "S"; }
                else if (json_obj.Acc_Type.ToString().Equals("M"))
                {
                    master_err_label.Text = "Permissions and Account type of Master Account cannot be changed.";
                    Acc_Type_Radio.Enabled = false;
                    Acc_Type_Radio_2.Enabled = false;
                    setpermission("P111111");
                    Permissions_GB.Enabled = false;
                    Acc_Type = "M";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Sno", SNO },
                        { "ID", acc_id.Text.ToString() },
                        { "Username", username.Text.ToString() },
                        { "Acc_Type", Acc_Type },
                        { "Permission", getcurrentpermissionstring() }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/update_other_accounts.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get. Server is busy");
                if (responseString.Equals("Success"))
                    this.Close();
            }
        }

        private string getcurrentpermissionstring()
        {
            if (Acc_Type == "A") return "P111111";
            StringBuilder Permission_String = new StringBuilder("P");
            if (checkBox1.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox2.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox3.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox4.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox5.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            if (checkBox6.Checked) Permission_String.Append("1"); else Permission_String.Append("0");
            return Permission_String.ToString();
        }

        private void Acc_Type_Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Acc_Type_Radio.Checked) { Permissions_GB.Enabled = false; Acc_Type = "A"; }
            if (Acc_Type_Radio_2.Checked) { Permissions_GB.Enabled = true; Acc_Type = "S"; }
        }
    }
}
