namespace Calbulance
{
    partial class ModifyDriver
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
            this.LicenseLocStr = new System.Windows.Forms.Label();
            this.BrowseLic = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dob_box = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.contact_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.empid_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drivelic_box = new System.Windows.Forms.TextBox();
            this.address_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fname_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.RegistrationID = new System.Windows.Forms.Label();
            this.regID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dp = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp)).BeginInit();
            this.SuspendLayout();
            // 
            // LicenseLocStr
            // 
            this.LicenseLocStr.ForeColor = System.Drawing.Color.Indigo;
            this.LicenseLocStr.Location = new System.Drawing.Point(212, 265);
            this.LicenseLocStr.MaximumSize = new System.Drawing.Size(308, 18);
            this.LicenseLocStr.MinimumSize = new System.Drawing.Size(308, 18);
            this.LicenseLocStr.Name = "LicenseLocStr";
            this.LicenseLocStr.Size = new System.Drawing.Size(308, 18);
            this.LicenseLocStr.TabIndex = 37;
            this.LicenseLocStr.Text = "Not Uploaded";
            // 
            // BrowseLic
            // 
            this.BrowseLic.BackColor = System.Drawing.Color.Indigo;
            this.BrowseLic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseLic.ForeColor = System.Drawing.Color.White;
            this.BrowseLic.Location = new System.Drawing.Point(129, 260);
            this.BrowseLic.Name = "BrowseLic";
            this.BrowseLic.Size = new System.Drawing.Size(77, 23);
            this.BrowseLic.TabIndex = 29;
            this.BrowseLic.Text = "Browse";
            this.BrowseLic.UseVisualStyleBackColor = false;
            this.BrowseLic.Click += new System.EventHandler(this.BrowseLic_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Driving License";
            // 
            // dob_box
            // 
            this.dob_box.CustomFormat = "d  -  MMM  -  yyyy";
            this.dob_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob_box.Location = new System.Drawing.Point(375, 225);
            this.dob_box.Name = "dob_box";
            this.dob_box.Size = new System.Drawing.Size(145, 20);
            this.dob_box.TabIndex = 28;
            this.dob_box.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(302, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "DOB";
            // 
            // contact_box
            // 
            this.contact_box.Location = new System.Drawing.Point(98, 225);
            this.contact_box.Name = "contact_box";
            this.contact_box.Size = new System.Drawing.Size(179, 20);
            this.contact_box.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(27, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Contact No,";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Indigo;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel.Location = new System.Drawing.Point(393, 347);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 33;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Modify
            // 
            this.Modify.BackColor = System.Drawing.Color.Indigo;
            this.Modify.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify.ForeColor = System.Drawing.Color.White;
            this.Modify.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Modify.Location = new System.Drawing.Point(261, 347);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(75, 23);
            this.Modify.TabIndex = 32;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = false;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // empid_box
            // 
            this.empid_box.Location = new System.Drawing.Point(375, 191);
            this.empid_box.Name = "empid_box";
            this.empid_box.Size = new System.Drawing.Size(145, 20);
            this.empid_box.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(302, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Employee ID";
            // 
            // drivelic_box
            // 
            this.drivelic_box.Location = new System.Drawing.Point(133, 191);
            this.drivelic_box.Name = "drivelic_box";
            this.drivelic_box.Size = new System.Drawing.Size(144, 20);
            this.drivelic_box.TabIndex = 23;
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(98, 94);
            this.address_box.Multiline = true;
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(422, 82);
            this.address_box.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(27, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Driving License No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Address";
            // 
            // fname_box
            // 
            this.fname_box.Location = new System.Drawing.Point(98, 60);
            this.fname_box.Name = "fname_box";
            this.fname_box.Size = new System.Drawing.Size(422, 20);
            this.fname_box.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Full Name";
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.Indigo;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BrowseButton.Location = new System.Drawing.Point(588, 255);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 30;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // RegistrationID
            // 
            this.RegistrationID.AutoSize = true;
            this.RegistrationID.Location = new System.Drawing.Point(27, 20);
            this.RegistrationID.Name = "RegistrationID";
            this.RegistrationID.Size = new System.Drawing.Size(83, 13);
            this.RegistrationID.TabIndex = 38;
            this.RegistrationID.Text = "Registration ID :";
            // 
            // regID
            // 
            this.regID.AutoSize = true;
            this.regID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regID.ForeColor = System.Drawing.Color.Indigo;
            this.regID.Location = new System.Drawing.Point(113, 20);
            this.regID.Name = "regID";
            this.regID.Size = new System.Drawing.Size(25, 13);
            this.regID.TabIndex = 39;
            this.regID.Text = "NO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Calbulance.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(52, 304);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // dp
            // 
            this.dp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dp.Location = new System.Drawing.Point(549, 60);
            this.dp.Name = "dp";
            this.dp.Size = new System.Drawing.Size(149, 185);
            this.dp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dp.TabIndex = 19;
            this.dp.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(547, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "To keep the previous Profile Picture and License please do not re-upload. Re-uplo" +
    "ading will replace previous ones.";
            // 
            // ModifyDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 392);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regID);
            this.Controls.Add(this.RegistrationID);
            this.Controls.Add(this.LicenseLocStr);
            this.Controls.Add(this.BrowseLic);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dob_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contact_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Modify);
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
            this.MaximumSize = new System.Drawing.Size(734, 392);
            this.MinimumSize = new System.Drawing.Size(734, 392);
            this.Name = "ModifyDriver";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyDriver";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ModifyDriver_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LicenseLocStr;
        private System.Windows.Forms.Button BrowseLic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dob_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contact_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.TextBox empid_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox drivelic_box;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fname_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.PictureBox dp;
        private System.Windows.Forms.Label RegistrationID;
        private System.Windows.Forms.Label regID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}