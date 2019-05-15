namespace IndividualneZadanie4
{
    partial class ManageEmployeesForm
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
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbBxStructures = new System.Windows.Forms.ComboBox();
            this.bttnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxEmailAddress = new System.Windows.Forms.TextBox();
            this.cmbBxEmployees = new System.Windows.Forms.ComboBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.bttnLeave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.chckBxInDepartment = new System.Windows.Forms.CheckBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.Location = new System.Drawing.Point(60, 146);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.Size = new System.Drawing.Size(216, 20);
            this.txtBxTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(57, 130);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // cmbBxStructures
            // 
            this.cmbBxStructures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxStructures.FormattingEnabled = true;
            this.cmbBxStructures.Location = new System.Drawing.Point(60, 283);
            this.cmbBxStructures.Name = "cmbBxStructures";
            this.cmbBxStructures.Size = new System.Drawing.Size(216, 21);
            this.cmbBxStructures.TabIndex = 2;
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(452, 283);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 23);
            this.bttnSave.TabIndex = 3;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(60, 50);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(216, 20);
            this.txtBxFirstName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(60, 98);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(216, 20);
            this.txtBxLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone number";
            // 
            // txtBxPhoneNumber
            // 
            this.txtBxPhoneNumber.Location = new System.Drawing.Point(60, 189);
            this.txtBxPhoneNumber.Name = "txtBxPhoneNumber";
            this.txtBxPhoneNumber.Size = new System.Drawing.Size(216, 20);
            this.txtBxPhoneNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email address";
            // 
            // txtBxEmailAddress
            // 
            this.txtBxEmailAddress.Location = new System.Drawing.Point(60, 234);
            this.txtBxEmailAddress.Name = "txtBxEmailAddress";
            this.txtBxEmailAddress.Size = new System.Drawing.Size(216, 20);
            this.txtBxEmailAddress.TabIndex = 10;
            // 
            // cmbBxEmployees
            // 
            this.cmbBxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxEmployees.FormattingEnabled = true;
            this.cmbBxEmployees.Location = new System.Drawing.Point(302, 98);
            this.cmbBxEmployees.Name = "cmbBxEmployees";
            this.cmbBxEmployees.Size = new System.Drawing.Size(216, 21);
            this.cmbBxEmployees.TabIndex = 12;
            this.cmbBxEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbBxEmployees_SelectedIndexChanged);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(299, 82);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(58, 13);
            this.lblEmployees.TabIndex = 13;
            this.lblEmployees.Text = "Employees";
            // 
            // bttnLeave
            // 
            this.bttnLeave.Location = new System.Drawing.Point(350, 283);
            this.bttnLeave.Name = "bttnLeave";
            this.bttnLeave.Size = new System.Drawing.Size(75, 23);
            this.bttnLeave.TabIndex = 14;
            this.bttnLeave.Text = "Leave";
            this.bttnLeave.UseVisualStyleBackColor = true;
            this.bttnLeave.Click += new System.EventHandler(this.bttnLeave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Structure employee works at";
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Location = new System.Drawing.Point(452, 283);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(75, 23);
            this.bttnUpdate.TabIndex = 16;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // chckBxInDepartment
            // 
            this.chckBxInDepartment.AutoSize = true;
            this.chckBxInDepartment.Location = new System.Drawing.Point(302, 52);
            this.chckBxInDepartment.Name = "chckBxInDepartment";
            this.chckBxInDepartment.Size = new System.Drawing.Size(110, 17);
            this.chckBxInDepartment.TabIndex = 18;
            this.chckBxInDepartment.Text = "Not in department";
            this.chckBxInDepartment.UseVisualStyleBackColor = true;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(372, 166);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(101, 20);
            this.lblDirector.TabIndex = 19;
            this.lblDirector.Text = "DIRECTOR";
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 329);
            this.ControlBox = false;
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.chckBxInDepartment);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnLeave);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.cmbBxEmployees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxEmailAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.cmbBxStructures);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBxTitle);
            this.MaximumSize = new System.Drawing.Size(575, 368);
            this.MinimumSize = new System.Drawing.Size(575, 368);
            this.Name = "ManageEmployeesForm";
            this.Text = "ManageEmployees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbBxStructures;
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxEmailAddress;
        private System.Windows.Forms.ComboBox cmbBxEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.Button bttnLeave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.CheckBox chckBxInDepartment;
        private System.Windows.Forms.Label lblDirector;
    }
}