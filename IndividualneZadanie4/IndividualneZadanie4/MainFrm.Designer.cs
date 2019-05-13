namespace IndividualneZadanie4
{
    partial class MainFrm
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
            this.bttnNewFirm = new System.Windows.Forms.Button();
            this.cmbBxFirms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGrdVwFirm = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnManageStructures = new System.Windows.Forms.Button();
            this.bttnManageEmployees = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtGrdVwDivision = new System.Windows.Forms.DataGridView();
            this.dtGrdVwProject = new System.Windows.Forms.DataGridView();
            this.dtGrdVwDepartments = new System.Windows.Forms.DataGridView();
            this.dtGrdVwEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwFirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnNewFirm
            // 
            this.bttnNewFirm.Location = new System.Drawing.Point(16, 567);
            this.bttnNewFirm.Name = "bttnNewFirm";
            this.bttnNewFirm.Size = new System.Drawing.Size(121, 23);
            this.bttnNewFirm.TabIndex = 2;
            this.bttnNewFirm.Text = "New firm";
            this.bttnNewFirm.UseVisualStyleBackColor = true;
            this.bttnNewFirm.Click += new System.EventHandler(this.bttnNewFirm_Click);
            // 
            // cmbBxFirms
            // 
            this.cmbBxFirms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxFirms.FormattingEnabled = true;
            this.cmbBxFirms.Location = new System.Drawing.Point(933, 581);
            this.cmbBxFirms.Name = "cmbBxFirms";
            this.cmbBxFirms.Size = new System.Drawing.Size(121, 21);
            this.cmbBxFirms.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(957, 618);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select firm :";
            // 
            // dtGrdVwFirm
            // 
            this.dtGrdVwFirm.AllowUserToAddRows = false;
            this.dtGrdVwFirm.AllowUserToDeleteRows = false;
            this.dtGrdVwFirm.AllowUserToResizeRows = false;
            this.dtGrdVwFirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwFirm.Location = new System.Drawing.Point(16, 51);
            this.dtGrdVwFirm.Name = "dtGrdVwFirm";
            this.dtGrdVwFirm.ReadOnly = true;
            this.dtGrdVwFirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwFirm.Size = new System.Drawing.Size(257, 510);
            this.dtGrdVwFirm.TabIndex = 6;
            this.dtGrdVwFirm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwFirm_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Firm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Division";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Project";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1112, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Employees";
            // 
            // bttnManageStructures
            // 
            this.bttnManageStructures.Location = new System.Drawing.Point(152, 567);
            this.bttnManageStructures.Name = "bttnManageStructures";
            this.bttnManageStructures.Size = new System.Drawing.Size(121, 23);
            this.bttnManageStructures.TabIndex = 1;
            this.bttnManageStructures.Text = "Manage Structure";
            this.bttnManageStructures.UseVisualStyleBackColor = true;
            this.bttnManageStructures.Click += new System.EventHandler(this.bttnManageStructures_Click);
            // 
            // bttnManageEmployees
            // 
            this.bttnManageEmployees.Location = new System.Drawing.Point(1115, 567);
            this.bttnManageEmployees.Name = "bttnManageEmployees";
            this.bttnManageEmployees.Size = new System.Drawing.Size(121, 23);
            this.bttnManageEmployees.TabIndex = 5;
            this.bttnManageEmployees.Text = "Manage Employees";
            this.bttnManageEmployees.UseVisualStyleBackColor = true;
            this.bttnManageEmployees.Click += new System.EventHandler(this.bttnManageEmployees_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete Structure";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwDivision
            // 
            this.dtGrdVwDivision.AllowUserToAddRows = false;
            this.dtGrdVwDivision.AllowUserToDeleteRows = false;
            this.dtGrdVwDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwDivision.Location = new System.Drawing.Point(288, 51);
            this.dtGrdVwDivision.Name = "dtGrdVwDivision";
            this.dtGrdVwDivision.ReadOnly = true;
            this.dtGrdVwDivision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwDivision.Size = new System.Drawing.Size(257, 510);
            this.dtGrdVwDivision.TabIndex = 17;
            // 
            // dtGrdVwProject
            // 
            this.dtGrdVwProject.AllowUserToAddRows = false;
            this.dtGrdVwProject.AllowUserToDeleteRows = false;
            this.dtGrdVwProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwProject.Location = new System.Drawing.Point(561, 51);
            this.dtGrdVwProject.Name = "dtGrdVwProject";
            this.dtGrdVwProject.ReadOnly = true;
            this.dtGrdVwProject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwProject.Size = new System.Drawing.Size(257, 510);
            this.dtGrdVwProject.TabIndex = 18;
            // 
            // dtGrdVwDepartments
            // 
            this.dtGrdVwDepartments.AllowUserToAddRows = false;
            this.dtGrdVwDepartments.AllowUserToDeleteRows = false;
            this.dtGrdVwDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwDepartments.Location = new System.Drawing.Point(836, 51);
            this.dtGrdVwDepartments.Name = "dtGrdVwDepartments";
            this.dtGrdVwDepartments.ReadOnly = true;
            this.dtGrdVwDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwDepartments.Size = new System.Drawing.Size(257, 510);
            this.dtGrdVwDepartments.TabIndex = 19;
            // 
            // dtGrdVwEmployee
            // 
            this.dtGrdVwEmployee.AllowUserToAddRows = false;
            this.dtGrdVwEmployee.AllowUserToDeleteRows = false;
            this.dtGrdVwEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwEmployee.Location = new System.Drawing.Point(1115, 51);
            this.dtGrdVwEmployee.Name = "dtGrdVwEmployee";
            this.dtGrdVwEmployee.ReadOnly = true;
            this.dtGrdVwEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwEmployee.Size = new System.Drawing.Size(257, 510);
            this.dtGrdVwEmployee.TabIndex = 20;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 640);
            this.Controls.Add(this.dtGrdVwEmployee);
            this.Controls.Add(this.dtGrdVwDepartments);
            this.Controls.Add(this.dtGrdVwProject);
            this.Controls.Add(this.dtGrdVwDivision);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtGrdVwFirm);
            this.Controls.Add(this.bttnManageEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxFirms);
            this.Controls.Add(this.bttnNewFirm);
            this.Controls.Add(this.bttnManageStructures);
            this.Name = "MainFrm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwFirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnNewFirm;
        private System.Windows.Forms.ComboBox cmbBxFirms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtGrdVwFirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnManageStructures;
        private System.Windows.Forms.Button bttnManageEmployees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtGrdVwDivision;
        private System.Windows.Forms.DataGridView dtGrdVwProject;
        private System.Windows.Forms.DataGridView dtGrdVwDepartments;
        private System.Windows.Forms.DataGridView dtGrdVwEmployee;
    }
}

