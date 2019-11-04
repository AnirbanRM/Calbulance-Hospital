namespace Calbulance
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginBox = new System.Windows.Forms.GroupBox();
            this.reg_no = new System.Windows.Forms.TextBox();
            this.reglab = new System.Windows.Forms.Label();
            this.createaccb = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.netava = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBox
            // 
            this.LoginBox.Controls.Add(this.reg_no);
            this.LoginBox.Controls.Add(this.reglab);
            this.LoginBox.Controls.Add(this.createaccb);
            this.LoginBox.Controls.Add(this.Login);
            this.LoginBox.Controls.Add(this.passwordbox);
            this.LoginBox.Controls.Add(this.idbox);
            this.LoginBox.Controls.Add(this.label2);
            this.LoginBox.Controls.Add(this.label1);
            this.LoginBox.Enabled = false;
            this.LoginBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBox.Location = new System.Drawing.Point(185, 215);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(422, 209);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.TabStop = false;
            // 
            // reg_no
            // 
            this.reg_no.Location = new System.Drawing.Point(154, 36);
            this.reg_no.Name = "reg_no";
            this.reg_no.Size = new System.Drawing.Size(217, 20);
            this.reg_no.TabIndex = 1;
            // 
            // reglab
            // 
            this.reglab.AutoSize = true;
            this.reglab.Location = new System.Drawing.Point(42, 39);
            this.reglab.Name = "reglab";
            this.reglab.Size = new System.Drawing.Size(94, 13);
            this.reglab.TabIndex = 6;
            this.reglab.Text = "Hospital Reg No. :";
            // 
            // createaccb
            // 
            this.createaccb.BackColor = System.Drawing.Color.Indigo;
            this.createaccb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createaccb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccb.ForeColor = System.Drawing.Color.White;
            this.createaccb.Location = new System.Drawing.Point(22, 162);
            this.createaccb.Margin = new System.Windows.Forms.Padding(0);
            this.createaccb.Name = "createaccb";
            this.createaccb.Size = new System.Drawing.Size(131, 23);
            this.createaccb.TabIndex = 5;
            this.createaccb.Text = "CREATE ACCOUNT";
            this.createaccb.UseVisualStyleBackColor = false;
            this.createaccb.Click += new System.EventHandler(this.createaccb_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Indigo;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Location = new System.Drawing.Point(296, 134);
            this.Login.Margin = new System.Windows.Forms.Padding(0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.login_clickedAsync);
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(154, 88);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(217, 20);
            this.passwordbox.TabIndex = 3;
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(154, 62);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(217, 20);
            this.idbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login ID : ";
            // 
            // netava
            // 
            this.netava.AutoSize = true;
            this.netava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netava.ForeColor = System.Drawing.Color.Red;
            this.netava.Location = new System.Drawing.Point(683, 475);
            this.netava.Name = "netava";
            this.netava.Size = new System.Drawing.Size(92, 13);
            this.netava.TabIndex = 2;
            this.netava.Text = "Not Connected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calbulance.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(216, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 497);
            this.Controls.Add(this.netava);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(803, 536);
            this.MinimumSize = new System.Drawing.Size(803, 536);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calbulance (Hospital Version) v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginBox.ResumeLayout(false);
            this.LoginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button createaccb;
        private System.Windows.Forms.Label netava;
        private System.Windows.Forms.TextBox reg_no;
        private System.Windows.Forms.Label reglab;
    }
}

