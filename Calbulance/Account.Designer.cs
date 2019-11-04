namespace Calbulance
{
    partial class Account
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
            this.current_user_detail = new System.Windows.Forms.GroupBox();
            this.HName = new System.Windows.Forms.Label();
            this.hos_id_value = new System.Windows.Forms.Label();
            this.acc_type_value = new System.Windows.Forms.Label();
            this.loginid_value = new System.Windows.Forms.Label();
            this.username_value = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Curr_user_modify = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manage_accounts_box = new System.Windows.Forms.GroupBox();
            this.mod_acc_GB = new System.Windows.Forms.GroupBox();
            this.Existing_Accs = new System.Windows.Forms.DataGridView();
            this.Remove_but = new System.Windows.Forms.Button();
            this.ModifyAccBut = new System.Windows.Forms.Button();
            this.accounts_table = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Permissions_GB = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.create_account = new System.Windows.Forms.Button();
            this.Acc_Type_Radio_2 = new System.Windows.Forms.RadioButton();
            this.Acc_Type_Radio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.new_acc_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.new_acc_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.current_user_detail.SuspendLayout();
            this.manage_accounts_box.SuspendLayout();
            this.mod_acc_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Existing_Accs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Permissions_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // current_user_detail
            // 
            this.current_user_detail.Controls.Add(this.HName);
            this.current_user_detail.Controls.Add(this.hos_id_value);
            this.current_user_detail.Controls.Add(this.acc_type_value);
            this.current_user_detail.Controls.Add(this.loginid_value);
            this.current_user_detail.Controls.Add(this.username_value);
            this.current_user_detail.Controls.Add(this.button2);
            this.current_user_detail.Controls.Add(this.Curr_user_modify);
            this.current_user_detail.Controls.Add(this.label5);
            this.current_user_detail.Controls.Add(this.label4);
            this.current_user_detail.Controls.Add(this.label3);
            this.current_user_detail.Controls.Add(this.label2);
            this.current_user_detail.Controls.Add(this.label1);
            this.current_user_detail.Location = new System.Drawing.Point(12, 12);
            this.current_user_detail.Name = "current_user_detail";
            this.current_user_detail.Size = new System.Drawing.Size(776, 118);
            this.current_user_detail.TabIndex = 0;
            this.current_user_detail.TabStop = false;
            this.current_user_detail.Text = "Logged In User";
            // 
            // HName
            // 
            this.HName.AutoSize = true;
            this.HName.Location = new System.Drawing.Point(164, 92);
            this.HName.Name = "HName";
            this.HName.Size = new System.Drawing.Size(0, 13);
            this.HName.TabIndex = 11;
            // 
            // hos_id_value
            // 
            this.hos_id_value.AutoSize = true;
            this.hos_id_value.Location = new System.Drawing.Point(164, 77);
            this.hos_id_value.Name = "hos_id_value";
            this.hos_id_value.Size = new System.Drawing.Size(0, 13);
            this.hos_id_value.TabIndex = 10;
            // 
            // acc_type_value
            // 
            this.acc_type_value.AutoSize = true;
            this.acc_type_value.Location = new System.Drawing.Point(164, 54);
            this.acc_type_value.Name = "acc_type_value";
            this.acc_type_value.Size = new System.Drawing.Size(0, 13);
            this.acc_type_value.TabIndex = 9;
            // 
            // loginid_value
            // 
            this.loginid_value.AutoSize = true;
            this.loginid_value.Location = new System.Drawing.Point(164, 37);
            this.loginid_value.Name = "loginid_value";
            this.loginid_value.Size = new System.Drawing.Size(0, 13);
            this.loginid_value.TabIndex = 8;
            // 
            // username_value
            // 
            this.username_value.AutoSize = true;
            this.username_value.Location = new System.Drawing.Point(164, 22);
            this.username_value.Name = "username_value";
            this.username_value.Size = new System.Drawing.Size(0, 13);
            this.username_value.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(679, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Curr_user_modify
            // 
            this.Curr_user_modify.Location = new System.Drawing.Point(679, 27);
            this.Curr_user_modify.Name = "Curr_user_modify";
            this.Curr_user_modify.Size = new System.Drawing.Size(75, 23);
            this.Curr_user_modify.TabIndex = 1;
            this.Curr_user_modify.Text = "Modify";
            this.Curr_user_modify.UseVisualStyleBackColor = true;
            this.Curr_user_modify.Click += new System.EventHandler(this.Curr_user_modify_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Login ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hospital Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hospital Registration No. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // manage_accounts_box
            // 
            this.manage_accounts_box.Controls.Add(this.mod_acc_GB);
            this.manage_accounts_box.Controls.Add(this.groupBox1);
            this.manage_accounts_box.Location = new System.Drawing.Point(12, 137);
            this.manage_accounts_box.Name = "manage_accounts_box";
            this.manage_accounts_box.Size = new System.Drawing.Size(776, 329);
            this.manage_accounts_box.TabIndex = 1;
            this.manage_accounts_box.TabStop = false;
            this.manage_accounts_box.Text = "Manage Accounts";
            // 
            // mod_acc_GB
            // 
            this.mod_acc_GB.Controls.Add(this.Existing_Accs);
            this.mod_acc_GB.Controls.Add(this.Remove_but);
            this.mod_acc_GB.Controls.Add(this.ModifyAccBut);
            this.mod_acc_GB.Controls.Add(this.accounts_table);
            this.mod_acc_GB.Location = new System.Drawing.Point(377, 20);
            this.mod_acc_GB.Name = "mod_acc_GB";
            this.mod_acc_GB.Size = new System.Drawing.Size(393, 303);
            this.mod_acc_GB.TabIndex = 1;
            this.mod_acc_GB.TabStop = false;
            this.mod_acc_GB.Text = "Modify Accounts";
            // 
            // Existing_Accs
            // 
            this.Existing_Accs.AllowUserToAddRows = false;
            this.Existing_Accs.AllowUserToDeleteRows = false;
            this.Existing_Accs.AllowUserToResizeRows = false;
            this.Existing_Accs.BackgroundColor = System.Drawing.Color.White;
            this.Existing_Accs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Existing_Accs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Existing_Accs.Location = new System.Drawing.Point(8, 26);
            this.Existing_Accs.MultiSelect = false;
            this.Existing_Accs.Name = "Existing_Accs";
            this.Existing_Accs.ReadOnly = true;
            this.Existing_Accs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Existing_Accs.RowHeadersVisible = false;
            this.Existing_Accs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Existing_Accs.Size = new System.Drawing.Size(379, 238);
            this.Existing_Accs.TabIndex = 3;
            // 
            // Remove_but
            // 
            this.Remove_but.Location = new System.Drawing.Point(197, 272);
            this.Remove_but.Name = "Remove_but";
            this.Remove_but.Size = new System.Drawing.Size(75, 23);
            this.Remove_but.TabIndex = 15;
            this.Remove_but.Text = "Remove";
            this.Remove_but.UseVisualStyleBackColor = true;
            this.Remove_but.Click += new System.EventHandler(this.Remove_but_Click);
            // 
            // ModifyAccBut
            // 
            this.ModifyAccBut.Location = new System.Drawing.Point(116, 272);
            this.ModifyAccBut.Name = "ModifyAccBut";
            this.ModifyAccBut.Size = new System.Drawing.Size(75, 23);
            this.ModifyAccBut.TabIndex = 14;
            this.ModifyAccBut.Text = "Modify";
            this.ModifyAccBut.UseVisualStyleBackColor = true;
            this.ModifyAccBut.Click += new System.EventHandler(this.ModifyAccBut_Click);
            // 
            // accounts_table
            // 
            this.accounts_table.AllowUserToAddRows = false;
            this.accounts_table.AllowUserToDeleteRows = false;
            this.accounts_table.BackgroundColor = System.Drawing.Color.White;
            this.accounts_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accounts_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accounts_table.Location = new System.Drawing.Point(8, 26);
            this.accounts_table.MultiSelect = false;
            this.accounts_table.Name = "accounts_table";
            this.accounts_table.ReadOnly = true;
            this.accounts_table.Size = new System.Drawing.Size(379, 238);
            this.accounts_table.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Permissions_GB);
            this.groupBox1.Controls.Add(this.create_account);
            this.groupBox1.Controls.Add(this.Acc_Type_Radio_2);
            this.groupBox1.Controls.Add(this.Acc_Type_Radio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.new_acc_id);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.new_acc_username);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new Account";
            // 
            // Permissions_GB
            // 
            this.Permissions_GB.Controls.Add(this.checkBox6);
            this.Permissions_GB.Controls.Add(this.checkBox3);
            this.Permissions_GB.Controls.Add(this.checkBox1);
            this.Permissions_GB.Controls.Add(this.checkBox4);
            this.Permissions_GB.Controls.Add(this.checkBox2);
            this.Permissions_GB.Controls.Add(this.checkBox5);
            this.Permissions_GB.Location = new System.Drawing.Point(24, 118);
            this.Permissions_GB.Name = "Permissions_GB";
            this.Permissions_GB.Size = new System.Drawing.Size(319, 146);
            this.Permissions_GB.TabIndex = 15;
            this.Permissions_GB.TabStop = false;
            this.Permissions_GB.Text = "Permissions";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(21, 111);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(113, 17);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "Manage Accounts";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 60);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(155, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Approve/Decline Requests";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Manage Drivers";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(21, 77);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(174, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Approve/Decline Appointments";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Manage Ambulances";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(21, 94);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(208, 17);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Create Driver/Ambulance Associations";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // create_account
            // 
            this.create_account.Location = new System.Drawing.Point(100, 270);
            this.create_account.Name = "create_account";
            this.create_account.Size = new System.Drawing.Size(140, 23);
            this.create_account.TabIndex = 13;
            this.create_account.Text = "Create Account";
            this.create_account.UseVisualStyleBackColor = true;
            this.create_account.Click += new System.EventHandler(this.create_account_Click);
            // 
            // Acc_Type_Radio_2
            // 
            this.Acc_Type_Radio_2.AutoSize = true;
            this.Acc_Type_Radio_2.Location = new System.Drawing.Point(211, 95);
            this.Acc_Type_Radio_2.Name = "Acc_Type_Radio_2";
            this.Acc_Type_Radio_2.Size = new System.Drawing.Size(68, 17);
            this.Acc_Type_Radio_2.TabIndex = 6;
            this.Acc_Type_Radio_2.Text = "Standard";
            this.Acc_Type_Radio_2.UseVisualStyleBackColor = true;
            this.Acc_Type_Radio_2.CheckedChanged += new System.EventHandler(this.Acc_Type_Radio_CheckedChanged);
            // 
            // Acc_Type_Radio
            // 
            this.Acc_Type_Radio.AutoSize = true;
            this.Acc_Type_Radio.Checked = true;
            this.Acc_Type_Radio.Location = new System.Drawing.Point(81, 95);
            this.Acc_Type_Radio.Name = "Acc_Type_Radio";
            this.Acc_Type_Radio.Size = new System.Drawing.Size(85, 17);
            this.Acc_Type_Radio.TabIndex = 5;
            this.Acc_Type_Radio.TabStop = true;
            this.Acc_Type_Radio.Text = "Administrator";
            this.Acc_Type_Radio.UseVisualStyleBackColor = true;
            this.Acc_Type_Radio.CheckedChanged += new System.EventHandler(this.Acc_Type_Radio_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Account Type :";
            // 
            // new_acc_id
            // 
            this.new_acc_id.Location = new System.Drawing.Point(81, 47);
            this.new_acc_id.Name = "new_acc_id";
            this.new_acc_id.Size = new System.Drawing.Size(263, 20);
            this.new_acc_id.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Login ID";
            // 
            // new_acc_username
            // 
            this.new_acc_username.Location = new System.Drawing.Point(81, 23);
            this.new_acc_username.Name = "new_acc_username";
            this.new_acc_username.Size = new System.Drawing.Size(263, 20);
            this.new_acc_username.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username";
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(713, 472);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.manage_accounts_box);
            this.Controls.Add(this.current_user_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Account_Load);
            this.current_user_detail.ResumeLayout(false);
            this.current_user_detail.PerformLayout();
            this.manage_accounts_box.ResumeLayout(false);
            this.mod_acc_GB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Existing_Accs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Permissions_GB.ResumeLayout(false);
            this.Permissions_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox current_user_detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox manage_accounts_box;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Curr_user_modify;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Acc_Type_Radio_2;
        private System.Windows.Forms.RadioButton Acc_Type_Radio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox new_acc_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox new_acc_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox mod_acc_GB;
        private System.Windows.Forms.DataGridView accounts_table;
        private System.Windows.Forms.Button create_account;
        private System.Windows.Forms.Button Remove_but;
        private System.Windows.Forms.Button ModifyAccBut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label acc_type_value;
        private System.Windows.Forms.Label loginid_value;
        private System.Windows.Forms.Label username_value;
        private System.Windows.Forms.Label hos_id_value;
        private System.Windows.Forms.DataGridView Existing_Accs;
        private System.Windows.Forms.Label HName;
        private System.Windows.Forms.GroupBox Permissions_GB;
    }
}