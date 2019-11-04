namespace Calbulance
{
    partial class AddAmbulance
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
            this.AddAmb = new System.Windows.Forms.Button();
            this.CancelAmb = new System.Windows.Forms.Button();
            this.vno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vmod = new System.Windows.Forms.TextBox();
            this.vdes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddAmb
            // 
            this.AddAmb.BackColor = System.Drawing.Color.Indigo;
            this.AddAmb.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddAmb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAmb.ForeColor = System.Drawing.Color.White;
            this.AddAmb.Location = new System.Drawing.Point(167, 237);
            this.AddAmb.Name = "AddAmb";
            this.AddAmb.Size = new System.Drawing.Size(75, 23);
            this.AddAmb.TabIndex = 5;
            this.AddAmb.Text = "Add";
            this.AddAmb.UseVisualStyleBackColor = false;
            this.AddAmb.Click += new System.EventHandler(this.AddAmb_Click);
            // 
            // CancelAmb
            // 
            this.CancelAmb.BackColor = System.Drawing.Color.Indigo;
            this.CancelAmb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelAmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAmb.ForeColor = System.Drawing.Color.White;
            this.CancelAmb.Location = new System.Drawing.Point(289, 237);
            this.CancelAmb.Name = "CancelAmb";
            this.CancelAmb.Size = new System.Drawing.Size(75, 23);
            this.CancelAmb.TabIndex = 6;
            this.CancelAmb.Text = "Cancel";
            this.CancelAmb.UseVisualStyleBackColor = false;
            this.CancelAmb.Click += new System.EventHandler(this.CancelAmb_Click);
            // 
            // vno
            // 
            this.vno.Location = new System.Drawing.Point(144, 65);
            this.vno.Name = "vno";
            this.vno.Size = new System.Drawing.Size(324, 20);
            this.vno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicle No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vehicle Model";
            // 
            // vmod
            // 
            this.vmod.Location = new System.Drawing.Point(144, 91);
            this.vmod.Name = "vmod";
            this.vmod.Size = new System.Drawing.Size(324, 20);
            this.vmod.TabIndex = 3;
            // 
            // vdes
            // 
            this.vdes.Location = new System.Drawing.Point(64, 157);
            this.vdes.Multiline = true;
            this.vdes.Name = "vdes";
            this.vdes.Size = new System.Drawing.Size(405, 63);
            this.vdes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehicle Id";
            // 
            // vid
            // 
            this.vid.Location = new System.Drawing.Point(144, 39);
            this.vid.Name = "vid";
            this.vid.Size = new System.Drawing.Size(324, 20);
            this.vid.TabIndex = 1;
            // 
            // AddAmbulance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 291);
            this.Controls.Add(this.vid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vdes);
            this.Controls.Add(this.vmod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vno);
            this.Controls.Add(this.CancelAmb);
            this.Controls.Add(this.AddAmb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 291);
            this.Name = "AddAmbulance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Ambulance";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAmb;
        private System.Windows.Forms.Button CancelAmb;
        private System.Windows.Forms.TextBox vno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vmod;
        private System.Windows.Forms.TextBox vdes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vid;
    }
}