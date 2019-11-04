using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calbulance
{
    public partial class LoginForm : Form
    {
        Thread thd;
        bool acc_saved=false;

        void checkconnectivity(){
            while (true){
                try{
                    Ping p = new Ping();
                    PingReply pr = p.Send("3.14.219.83");
                    if (pr.Status.ToString().Equals("Success"))
                    {
                        if (LoginBox.InvokeRequired)
                        {
                            LoginBox.Invoke(new Action(()=> {
                                LoginBox.Enabled = true;
                            }));
                        }
                        if (netava.InvokeRequired)
                        {
                            netava.Invoke(new Action(() =>
                            {
                                netava.Text = "Connected";
                                netava.ForeColor = Color.Green;

                            }));
                        }
                        if (acc_saved == true)
                        {
                            if (Login.InvokeRequired)
                            {
                                Login.Invoke(new Action(() =>
                                {
                                    Login.PerformClick();
                                }));
                            }
                            Thread.Sleep(2000);
                        }
                    }
                }
                catch (PingException){
                    
                    if (LoginBox.InvokeRequired)
                    {
                        LoginBox.Invoke(new Action(() => {
                            LoginBox.Enabled = false;
                        }));
                    }
                    if (netava.InvokeRequired){
                        netava.Invoke(new Action(() =>{
                            netava.ForeColor = Color.Red; netava.Text = "Not Connected";
                        }));
                    }
                }
                Thread.Sleep(2000);
            }
        }
        public LoginForm()
        {
            InitializeComponent();
            thd = new Thread(new ThreadStart(checkconnectivity));
            thd.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var check_acc_key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Calbulance\\Account");
            if (check_acc_key!=null)
            {
                reg_no.Text = check_acc_key.GetValue("HospitalId").ToString();
                idbox.Text = check_acc_key.GetValue("AdminId").ToString();
                passwordbox.Text = check_acc_key.GetValue("AdminPWd").ToString();
                acc_saved = true;
                check_acc_key.Close();
            }   
        }
        String id, password, regno;

        private void createaccb_Click(object sender, EventArgs e)
        {
            CreateHospitalAccount createHospitalAccount = new CreateHospitalAccount();
            createHospitalAccount.ShowDialog();
            reg_no.Text = createHospitalAccount.Hospital_ID;
            idbox.Text = createHospitalAccount.m_u;
            if (createHospitalAccount.DialogResult == DialogResult.OK)
            {
                passwordbox.Text = createHospitalAccount.m_p;
                Login.PerformClick();
            }
        }

        private async void login_clickedAsync(object sender, EventArgs e)
        {
            id = idbox.Text;
            password = passwordbox.Text;
            regno = reg_no.Text;
            if (id.Length == 0 || password.Length == 0 || regno.Length==0)
                MessageBox.Show("Reg. No. or Login ID or password is empty !");
            else
            {
                Label l = new Label();
                l.SetBounds(57, 28, 100, 20);
                l.Text = "Authenticating...";
                Form formmsg = new Form();
                formmsg.FormBorderStyle = FormBorderStyle.None;
                formmsg.StartPosition = FormStartPosition.CenterScreen;
                formmsg.BackColor = Color.WhiteSmoke ;
                formmsg.SetBounds(0, 0, 200, 70);
                formmsg.TopMost = true;
                formmsg.Controls.Add(l);
                formmsg.Show();

                String id = idbox.Text;
                String password = passwordbox.Text;
                String regno = reg_no.Text;

                using (var thisclient = new HttpClient())
                {
                    var postargs = new Dictionary<string, string>
                    {
                        { "ID", id },
                        { "PASSWORD", password },
                        { "RegNo", regno }
                    };

                    var urlparam = new FormUrlEncodedContent(postargs);
                    HttpResponseMessage response=null;
                    var responseString = "";
                    try
                    {
                        response = await thisclient.PostAsync("http://3.14.219.83/APIs/HospitalAuth.php", urlparam);
                    }
                    catch (HttpRequestException) { response = null; }
                    if (response != null)
                    {
                        responseString = await response.Content.ReadAsStringAsync();    
                    }
                    else
                    {
                        MessageBox.Show("Connection timed out ! ");
                    }
                    formmsg.Close();
                    var json_obj = JsonConvert.DeserializeObject<dynamic>(responseString); 
                    if (json_obj.Result.ToString().Equals("AccExists"))
                    {
                        var reg_acc_key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Calbulance\\Account");
                        reg_acc_key.SetValue("HospitalId", regno);
                        reg_acc_key.SetValue("AdminId", id);
                        reg_acc_key.SetValue("AdminPwd", password);
                        reg_acc_key.Close();
                        Form nextForm = new Workaround(regno, id, password, json_obj.PermissionString.ToString());
                        this.Hide();
                        nextForm.Show();
                    }
                    else
                    {
                        var check_acc_key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Calbulance\\Account");
                        if (check_acc_key != null)
                        {
                            Microsoft.Win32.Registry.CurrentUser.DeleteSubKey("Software\\Calbulance\\Account");
                            check_acc_key.Close();
                            acc_saved = false;
                        }
                        MessageBox.Show("Wrong Username/Password");
                    }
                }                       
            }
        }
    }
}

