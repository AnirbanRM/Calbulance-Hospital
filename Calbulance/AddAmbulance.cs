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
    public partial class AddAmbulance : Form
    {
        public String Vid { get; set; }
        public String Vno { get; set; }
        public String Vmod { get; set; }
        public String Vdes { get; set; }

        public AddAmbulance()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CancelAmb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AddAmb_Click(object sender, EventArgs e)
        {
            if (vid.Text.Length == 0 || vno.Text.Length == 0 || vmod.Text.Length == 0) { MessageBox.Show("Id, Number, Model cannot be empty.");}
            else
            {
                Vid = vid.Text;
                Vno = vno.Text;
                Vmod = vmod.Text;
                Vdes = vdes.Text;
                this.Close();
            }
        }
    }
}
