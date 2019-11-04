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
    public partial class AddDriver : Form
    {
        public String fname { get; set; }
        public String address { get; set; }
        public String driveLic { get; set; }
        public String empid { get; set; }
        public String Contact { get; set; }
        public String dob { get; set; }
        public String lic_loc { get; set; }
        public String img { get; set; }

        public AddDriver()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        String imgloc="", licloc="";
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG;|All files (*.*)|*.*";
            d.ShowDialog();
            imgloc = d.FileName.ToString();
            dp.ImageLocation = imgloc;
            dp.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (fname_box.Text.Length == 0 || address_box.Text.Length == 0 || drivelic_box.Text.Length == 0 || empid_box.Text.Length == 0 || contact_box.Text.Length == 0 || imgloc.Length == 0 || licloc.Length == 0) { MessageBox.Show("One or more field(s) are empty."); }
            else
            {
                this.fname = fname_box.Text;
                this.address = address_box.Text;
                this.driveLic = drivelic_box.Text;
                this.empid = empid_box.Text;
                this.Contact = contact_box.Text;
                this.dob = String.Join("-", dob_box.Value.Year, dob_box.Value.Month, dob_box.Value.Day);
                this.img = imgloc;
                this.lic_loc = licloc;
                this.Close();
            }
        }

        private void AddDriver_Load(object sender, EventArgs e)
        {
        }

        private void BrowseLic_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image Files|*.BMP;*.JPG;*.PNG;*.JPEG;|All files (*.*)|*.*";
            d.ShowDialog();
            licloc = d.FileName.ToString();
            LicenseLocStr.Text = licloc;
        }
    }
}
