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
            this.trVwFirmStructure = new System.Windows.Forms.TreeView();
            this.bttnManageStructures = new System.Windows.Forms.Button();
            this.bttnNewFirm = new System.Windows.Forms.Button();
            this.cmbBxFirms = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnManageEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trVwFirmStructure
            // 
            this.trVwFirmStructure.Location = new System.Drawing.Point(55, 33);
            this.trVwFirmStructure.Name = "trVwFirmStructure";
            this.trVwFirmStructure.Size = new System.Drawing.Size(384, 448);
            this.trVwFirmStructure.TabIndex = 0;
            // 
            // bttnManageStructures
            // 
            this.bttnManageStructures.Location = new System.Drawing.Point(533, 116);
            this.bttnManageStructures.Name = "bttnManageStructures";
            this.bttnManageStructures.Size = new System.Drawing.Size(121, 23);
            this.bttnManageStructures.TabIndex = 1;
            this.bttnManageStructures.Text = "Manage Structure";
            this.bttnManageStructures.UseVisualStyleBackColor = true;
            this.bttnManageStructures.Click += new System.EventHandler(this.bttnManageStructures_Click);
            // 
            // bttnNewFirm
            // 
            this.bttnNewFirm.Location = new System.Drawing.Point(533, 87);
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
            this.cmbBxFirms.Location = new System.Drawing.Point(533, 60);
            this.cmbBxFirms.Name = "cmbBxFirms";
            this.cmbBxFirms.Size = new System.Drawing.Size(121, 21);
            this.cmbBxFirms.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select firm :";
            // 
            // bttnManageEmployees
            // 
            this.bttnManageEmployees.Location = new System.Drawing.Point(533, 145);
            this.bttnManageEmployees.Name = "bttnManageEmployees";
            this.bttnManageEmployees.Size = new System.Drawing.Size(121, 23);
            this.bttnManageEmployees.TabIndex = 5;
            this.bttnManageEmployees.Text = "Manage Employees";
            this.bttnManageEmployees.UseVisualStyleBackColor = true;
            this.bttnManageEmployees.Click += new System.EventHandler(this.bttnManageEmployees_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 515);
            this.Controls.Add(this.bttnManageEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBxFirms);
            this.Controls.Add(this.bttnNewFirm);
            this.Controls.Add(this.bttnManageStructures);
            this.Controls.Add(this.trVwFirmStructure);
            this.Name = "MainFrm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trVwFirmStructure;
        private System.Windows.Forms.Button bttnManageStructures;
        private System.Windows.Forms.Button bttnNewFirm;
        private System.Windows.Forms.ComboBox cmbBxFirms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnManageEmployees;
    }
}

