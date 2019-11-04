using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calbulance
{
    public partial class ModifyVehicle : Form
    {
        public String regID { get; set; }
        public String Vno { get; set; }
        public String Vid { get; set; }
        public String Vmod { get; set; }
        public String Vdes { get; set; }

        public ModifyVehicle(String a,String b, String c, String d, String e)
        {
            InitializeComponent();
            this.regID = a;
            this.Vno = b;
            this.Vid = c;
            this.Vmod = d;
            this.Vdes = e;
        }

        private void ModifyVehicle_Load(object sender, EventArgs e)
        {
            RegID.Text = regID;
            vno.Text = Vno;
            vid.Text = Vid;
            vmod.Text = Vmod;
            vdes.Text = Vdes;
        }

        private void CancelAmb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModAmb_Click(object sender, EventArgs e)
        {
            this.regID = RegID.Text;
            this.Vno = vno.Text;
            this.Vid = vid.Text;
            this.Vmod = vmod.Text;
            this.Vdes = vdes.Text;
            this.Close();
        }
    }
}
