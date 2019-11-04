namespace Calbulance
{
    partial class ModifyVehicle
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
            this.vid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vdes = new System.Windows.Forms.TextBox();
            this.vmod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vno = new System.Windows.Forms.TextBox();
            this.CancelAmb = new System.Windows.Forms.Button();
            this.ModAmb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RegID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vid
            // 
            this.vid.Location = new System.Drawing.Point(112, 54);
            this.vid.Name = "vid";
            this.vid.Size = new System.Drawing.Size(324, 20);
            this.vid.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vehicle Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Description";
            // 
            // vdes
            // 
            this.vdes.Location = new System.Drawing.Point(32, 172);
            this.vdes.Multiline = true;
            this.vdes.Name = "vdes";
            this.vdes.Size = new System.Drawing.Size(405, 63);
            this.vdes.TabIndex = 13;
            // 
            // vmod
            // 
            this.vmod.Location = new System.Drawing.Point(112, 106);
            this.vmod.Name = "vmod";
            this.vmod.Size = new System.Drawing.Size(324, 20);
            this.vmod.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vehicle Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vehicle No.";
            // 
            // vno
            // 
            this.vno.Location = new System.Drawing.Point(112, 80);
            this.vno.Name = "vno";
            this.vno.Size = new System.Drawing.Size(324, 20);
            this.vno.TabIndex = 10;
            // 
            // CancelAmb
            // 
            this.CancelAmb.BackColor = System.Drawing.Color.Indigo;
            this.CancelAmb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelAmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAmb.ForeColor = System.Drawing.Color.White;
            this.CancelAmb.Location = new System.Drawing.Point(257, 252);
            this.CancelAmb.Name = "CancelAmb";
            this.CancelAmb.Size = new System.Drawing.Size(75, 23);
            this.CancelAmb.TabIndex = 16;
            this.CancelAmb.Text = "Cancel";
            this.CancelAmb.UseVisualStyleBackColor = false;
            this.CancelAmb.Click += new System.EventHandler(this.CancelAmb_Click);
            // 
            // ModAmb
            // 
            this.ModAmb.BackColor = System.Drawing.Color.Indigo;
            this.ModAmb.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ModAmb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModAmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModAmb.ForeColor = System.Drawing.Color.White;
            this.ModAmb.Location = new System.Drawing.Point(135, 252);
            this.ModAmb.Name = "ModAmb";
            this.ModAmb.Size = new System.Drawing.Size(75, 23);
            this.ModAmb.TabIndex = 15;
            this.ModAmb.Text = "Modify";
            this.ModAmb.UseVisualStyleBackColor = false;
            this.ModAmb.Click += new System.EventHandler(this.ModAmb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Registration ID :";
            // 
            // RegID
            // 
            this.RegID.AutoSize = true;
            this.RegID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegID.ForeColor = System.Drawing.Color.Indigo;
            this.RegID.Location = new System.Drawing.Point(116, 18);
            this.RegID.Name = "RegID";
            this.RegID.Size = new System.Drawing.Size(25, 13);
            this.RegID.TabIndex = 20;
            this.RegID.Text = "NO";
            // 
            // ModifyVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 298);
            this.Controls.Add(this.RegID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.vid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vdes);
            this.Controls.Add(this.vmod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vno);
            this.Controls.Add(this.CancelAmb);
            this.Controls.Add(this.ModAmb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(471, 298);
            this.MinimumSize = new System.Drawing.Size(471, 298);
            this.Name = "ModifyVehicle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ModifyVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vdes;
        private System.Windows.Forms.TextBox vmod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vno;
        private System.Windows.Forms.Button CancelAmb;
        private System.Windows.Forms.Button ModAmb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RegID;
    }
}