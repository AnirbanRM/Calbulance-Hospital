namespace Calbulance
{
    partial class AddDriver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriver));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fname_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.TextBox();
            this.drivelic_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empid_box = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.contact_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dob_box = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.BrowseLic = new System.Windows.Forms.Button();
            this.LicenseLocStr = new System.Windows.Forms.Label();
            this.dp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dp)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.Indigo;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BrowseButton.Location = new System.Drawing.Point(584, 220);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 8;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name";
            // 
            // fname_box
            // 
            this.fname_box.Location = new System.Drawing.Point(94, 25);
            this.fname_box.Name = "fname_box";
            this.fname_box.Size = new System.Drawing.Size(422, 20);
            this.fname_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(23, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Driving License No.";
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(94, 59);
            this.address_box.Multiline = true;
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(422, 82);
            this.address_box.TabIndex = 2;
            // 
            // drivelic_box
            // 
            this.drivelic_box.Location = new System.Drawing.Point(129, 156);
            this.drivelic_box.Name = "drivelic_box";
            this.drivelic_box.Size = new System.Drawing.Size(144, 20);
            this.drivelic_box.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(298, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee ID";
            // 
            // empid_box
            // 
            this.empid_box.Location = new System.Drawing.Point(371, 156);
            this.empid_box.Name = "empid_box";
            this.empid_box.Size = new System.Drawing.Size(145, 20);
            this.empid_box.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Indigo;
            this.Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add.Location = new System.Drawing.Point(253, 272);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Indigo;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel.Location = new System.Drawing.Point(385, 272);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(23, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contact No,";
            // 
            // contact_box
            // 
            this.contact_box.Location = new System.Drawing.Point(94, 190);
            this.contact_box.Name = "contact_box";
            this.contact_box.Size = new System.Drawing.Size(179, 20);
            this.contact_box.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(298, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DOB";
            // 
            // dob_box
            // 
            this.dob_box.CustomFormat = "d  -  MMM  -  yyyy";
            this.dob_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob_box.Location = new System.Drawing.Point(371, 190);
            this.dob_box.Name = "dob_box";
            this.dob_box.Size = new System.Drawing.Size(145, 20);
            this.dob_box.TabIndex = 6;
            this.dob_box.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Driving License";
            // 
            // BrowseLic
            // 
            this.BrowseLic.BackColor = System.Drawing.Color.Indigo;
            this.BrowseLic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseLic.ForeColor = System.Drawing.Color.White;
            this.BrowseLic.Location = new System.Drawing.Point(125, 225);
            this.BrowseLic.Name = "BrowseLic";
            this.BrowseLic.Size = new System.Drawing.Size(77, 23);
            this.BrowseLic.TabIndex = 7;
            this.BrowseLic.Text = "Browse";
            this.BrowseLic.UseVisualStyleBackColor = false;
            this.BrowseLic.Click += new System.EventHandler(this.BrowseLic_Click);
            // 
            // LicenseLocStr
            // 
            this.LicenseLocStr.ForeColor = System.Drawing.Color.Indigo;
            this.LicenseLocStr.Location = new System.Drawing.Point(208, 230);
            this.LicenseLocStr.MaximumSize = new System.Drawing.Size(308, 18);
            this.LicenseLocStr.MinimumSize = new System.Drawing.Size(308, 18);
            this.LicenseLocStr.Name = "LicenseLocStr";
            this.LicenseLocStr.Size = new System.Drawing.Size(308, 18);
            this.LicenseLocStr.TabIndex = 18;
            this.LicenseLocStr.Text = "Not Uploaded";
            // 
            // dp
            // 
            this.dp.BackColor = System.Drawing.Color.White;
            this.dp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dp.ErrorImage = null;
            this.dp.Image = ((System.Drawing.Image)(resources.GetObject("dp.Image")));
            this.dp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dp.InitialImage = null;
            this.dp.Location = new System.Drawing.Point(545, 25);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(149, 185);
            this.dp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dp.TabIndex = 0;
            this.dp.TabStop = false;
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 317);
            this.Controls.Add(this.LicenseLocStr);
            this.Controls.Add(this.BrowseLic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dob_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contact_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.empid_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drivelic_box);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.dp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(724, 317);
            this.MinimumSize = new System.Drawing.Size(724, 317);
            this.Name = "AddDriver";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDriver";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dp;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fname_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.TextBox drivelic_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empid_box;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contact_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dob_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BrowseLic;
        private System.Windows.Forms.Label LicenseLocStr;
    }
}