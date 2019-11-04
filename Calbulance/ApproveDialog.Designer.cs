namespace Calbulance
{
    partial class ApproveDialog
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.amb_assign_l = new System.Windows.Forms.ComboBox();
            this.driv_assign_l = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pat_con = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pat_addr = new System.Windows.Forms.Label();
            this.pat_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ApproveButton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.match_assoc_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Ambulance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Driver";
            // 
            // amb_assign_l
            // 
            this.amb_assign_l.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amb_assign_l.FormattingEnabled = true;
            this.amb_assign_l.Location = new System.Drawing.Point(26, 39);
            this.amb_assign_l.Name = "amb_assign_l";
            this.amb_assign_l.Size = new System.Drawing.Size(299, 21);
            this.amb_assign_l.Sorted = true;
            this.amb_assign_l.TabIndex = 2;
            this.amb_assign_l.SelectedIndexChanged += new System.EventHandler(this.amb_assign_l_SelectedIndexChanged);
            // 
            // driv_assign_l
            // 
            this.driv_assign_l.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driv_assign_l.FormattingEnabled = true;
            this.driv_assign_l.Location = new System.Drawing.Point(346, 39);
            this.driv_assign_l.Name = "driv_assign_l";
            this.driv_assign_l.Size = new System.Drawing.Size(300, 21);
            this.driv_assign_l.TabIndex = 3;
            this.driv_assign_l.SelectedIndexChanged += new System.EventHandler(this.driv_assign_l_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pat_con);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pat_addr);
            this.groupBox1.Controls.Add(this.pat_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Details";
            // 
            // pat_con
            // 
            this.pat_con.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pat_con.Location = new System.Drawing.Point(134, 178);
            this.pat_con.Name = "pat_con";
            this.pat_con.Size = new System.Drawing.Size(466, 18);
            this.pat_con.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contact No. :";
            // 
            // pat_addr
            // 
            this.pat_addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pat_addr.Location = new System.Drawing.Point(134, 57);
            this.pat_addr.Name = "pat_addr";
            this.pat_addr.Padding = new System.Windows.Forms.Padding(5);
            this.pat_addr.Size = new System.Drawing.Size(466, 110);
            this.pat_addr.TabIndex = 3;
            // 
            // pat_name
            // 
            this.pat_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pat_name.Location = new System.Drawing.Point(134, 28);
            this.pat_name.Name = "pat_name";
            this.pat_name.Size = new System.Drawing.Size(466, 18);
            this.pat_name.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Patient Address : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Patient Name :";
            // 
            // ApproveButton
            // 
            this.ApproveButton.BackColor = System.Drawing.Color.Green;
            this.ApproveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApproveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApproveButton.ForeColor = System.Drawing.Color.White;
            this.ApproveButton.Location = new System.Drawing.Point(296, 322);
            this.ApproveButton.Name = "ApproveButton";
            this.ApproveButton.Size = new System.Drawing.Size(85, 24);
            this.ApproveButton.TabIndex = 5;
            this.ApproveButton.Text = "ASSIGN";
            this.ApproveButton.UseVisualStyleBackColor = false;
            this.ApproveButton.Click += new System.EventHandler(this.ApproveButton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Indigo;
            this.exitbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.Location = new System.Drawing.Point(626, 333);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(46, 26);
            this.exitbutton.TabIndex = 9;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            // 
            // match_assoc_check
            // 
            this.match_assoc_check.AutoSize = true;
            this.match_assoc_check.Location = new System.Drawing.Point(277, 76);
            this.match_assoc_check.Name = "match_assoc_check";
            this.match_assoc_check.Size = new System.Drawing.Size(113, 17);
            this.match_assoc_check.TabIndex = 10;
            this.match_assoc_check.Text = "Match Association";
            this.match_assoc_check.UseVisualStyleBackColor = true;
            this.match_assoc_check.CheckedChanged += new System.EventHandler(this.match_assoc_check_CheckedChanged);
            // 
            // ApproveDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 364);
            this.Controls.Add(this.match_assoc_check);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.ApproveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.driv_assign_l);
            this.Controls.Add(this.amb_assign_l);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ApproveDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approve";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ApproveDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox amb_assign_l;
        private System.Windows.Forms.ComboBox driv_assign_l;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pat_addr;
        private System.Windows.Forms.Label pat_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pat_con;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ApproveButton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.CheckBox match_assoc_check;
    }
}