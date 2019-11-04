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
    public partial class CurrentUserModify : Form
    {
        private String Sno="";
        public String ID="";
        public String Username = "";
        public String Password = "";
        public CurrentUserModify(String a)
        {
            this.Sno = a;
            InitializeComponent();
            get_detail();
        }

        private async void get_detail()
        {
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Sno", Sno }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/modify_current_account.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get. Server is busy");

                var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString);

                acc_id.Text= json_obj.ID.ToString();
                acc_username.Text= json_obj.Username.ToString();
            }
        }

        private async void Update_button_Click(object sender, EventArgs e)
        {
            ID = acc_id.Text;
            Username = acc_username.Text;
            Password = new_password_box.Text;

            if (!new_password_box.Text.ToString().Equals(c_new_password_box.Text.ToString()))
            {
                MessageBox.Show("Passwords don't match");
                return;
            }
            using (var thisclient = new HttpClient())
            {
                var postargs = new Dictionary<string, string>
                    {
                        { "Sno", Sno },
                        { "Username", acc_username.Text.ToString() },
                        { "ID", acc_id.Text.ToString() },
                        { "CurrentPassword", current_password_box.Text.ToString() },
                        { "NewPassword", new_password_box.Text.ToString() }
                    };

                var urlparam = new FormUrlEncodedContent(postargs);
                HttpResponseMessage response = null;
                var responseString = "";
                try
                { response = await thisclient.PostAsync("http://3.14.219.83/APIs/update_current_account.php", urlparam); }
                catch (HttpRequestException) { response = null; }

                if (response != null)
                    responseString = await response.Content.ReadAsStringAsync();
                else
                    MessageBox.Show("Cannot get. Server is busy");

                if (responseString.Trim().Equals("WP"))
                {
                    MessageBox.Show("Current password is wrong.");
                }
                else if (responseString.Trim().Equals("Success"))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }
    }
}
