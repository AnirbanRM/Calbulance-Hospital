namespace Calbulance
{
    partial class Association
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
            this.ambulance_assoc_view = new System.Windows.Forms.DataGridView();
            this.driver_assoc_view = new System.Windows.Forms.DataGridView();
            this.existing_assoc_data_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.CreateAssociation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ambulance_assoc_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_assoc_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.existing_assoc_data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // ambulance_assoc_view
            // 
            this.ambulance_assoc_view.AllowUserToAddRows = false;
            this.ambulance_assoc_view.AllowUserToDeleteRows = false;
            this.ambulance_assoc_view.AllowUserToResizeColumns = false;
            this.ambulance_assoc_view.AllowUserToResizeRows = false;
            this.ambulance_assoc_view.BackgroundColor = System.Drawing.Color.White;
            this.ambulance_assoc_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ambulance_assoc_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ambulance_assoc_view.Location = new System.Drawing.Point(28, 337);
            this.ambulance_assoc_view.MultiSelect = false;
            this.ambulance_assoc_view.Name = "ambulance_assoc_view";
            this.ambulance_assoc_view.ReadOnly = true;
            this.ambulance_assoc_view.RowHeadersVisible = false;
            this.ambulance_assoc_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ambulance_assoc_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ambulance_assoc_view.Size = new System.Drawing.Size(356, 255);
            this.ambulance_assoc_view.TabIndex = 0;
            // 
            // driver_assoc_view
            // 
            this.driver_assoc_view.AllowUserToAddRows = false;
            this.driver_assoc_view.AllowUserToDeleteRows = false;
            this.driver_assoc_view.AllowUserToResizeColumns = false;
            this.driver_assoc_view.AllowUserToResizeRows = false;
            this.driver_assoc_view.BackgroundColor = System.Drawing.Color.White;
            this.driver_assoc_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.driver_assoc_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.driver_assoc_view.Location = new System.Drawing.Point(414, 337);
            this.driver_assoc_view.MultiSelect = false;
            this.driver_assoc_view.Name = "driver_assoc_view";
            this.driver_assoc_view.ReadOnly = true;
            this.driver_assoc_view.RowHeadersVisible = false;
            this.driver_assoc_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.driver_assoc_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.driver_assoc_view.Size = new System.Drawing.Size(357, 255);
            this.driver_assoc_view.TabIndex = 1;
            // 
            // existing_assoc_data_view
            // 
            this.existing_assoc_data_view.AllowUserToAddRows = false;
            this.existing_assoc_data_view.AllowUserToDeleteRows = false;
            this.existing_assoc_data_view.BackgroundColor = System.Drawing.Color.White;
            this.existing_assoc_data_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.existing_assoc_data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.existing_assoc_data_view.Location = new System.Drawing.Point(28, 37);
            this.existing_assoc_data_view.MultiSelect = false;
            this.existing_assoc_data_view.Name = "existing_assoc_data_view";
            this.existing_assoc_data_view.ReadOnly = true;
            this.existing_assoc_data_view.RowHeadersVisible = false;
            this.existing_assoc_data_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.existing_assoc_data_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.existing_assoc_data_view.Size = new System.Drawing.Size(743, 235);
            this.existing_assoc_data_view.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Existing Associations";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(331, 281);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(132, 31);
            this.delete.TabIndex = 4;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // CreateAssociation
            // 
            this.CreateAssociation.BackColor = System.Drawing.Color.ForestGreen;
            this.CreateAssociation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAssociation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAssociation.ForeColor = System.Drawing.Color.White;
            this.CreateAssociation.Location = new System.Drawing.Point(311, 602);
            this.CreateAssociation.Name = "CreateAssociation";
            this.CreateAssociation.Size = new System.Drawing.Size(180, 31);
            this.CreateAssociation.TabIndex = 5;
            this.CreateAssociation.Text = "CREATE ASSOCIATION";
            this.CreateAssociation.UseVisualStyleBackColor = false;
            this.CreateAssociation.Click += new System.EventHandler(this.CreateAssociation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ambulance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Driver";
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Indigo;
            this.exitbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.Location = new System.Drawing.Point(749, 626);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(46, 26);
            this.exitbutton.TabIndex = 8;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            // 
            // Association
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateAssociation);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.existing_assoc_data_view);
            this.Controls.Add(this.driver_assoc_view);
            this.Controls.Add(this.ambulance_assoc_view);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 657);
            this.MinimumSize = new System.Drawing.Size(800, 657);
            this.Name = "Association";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Association";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Association_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ambulance_assoc_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_assoc_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.existing_assoc_data_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ambulance_assoc_view;
        private System.Windows.Forms.DataGridView driver_assoc_view;
        private System.Windows.Forms.DataGridView existing_assoc_data_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button CreateAssociation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitbutton;
    }
}