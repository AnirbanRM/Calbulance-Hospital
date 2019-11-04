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
    public partial class AddModifyDoctors : Form
    {
        DataTable DOCTORS = new DataTable();
        public AddModifyDoctors(DataTable doctors)
        {
            this.DOCTORS = doctors;
            InitializeComponent();
        }

        private void AddModifyDoctors_Load(object sender, EventArgs e)
        {
            DoctorList.DataSource = DOCTORS;
            foreach (DataGridViewColumn dataGridViewColumn in DoctorList.Columns)
                dataGridViewColumn.Width = 300;
        }
        
        public DataTable getDoctors()
        { return DOCTORS; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
