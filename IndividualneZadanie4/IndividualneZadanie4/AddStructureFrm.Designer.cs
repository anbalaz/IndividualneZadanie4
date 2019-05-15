namespace IndividualneZadanie4
{
    partial class AddStructureFrm
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
            this.bttnAdd = new System.Windows.Forms.Button();
            this.lblStructure = new System.Windows.Forms.Label();
            this.cmbBxStructure = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnLeave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBxDirector = new System.Windows.Forms.ComboBox();
            this.txtBxStructureName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBxLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(513, 214);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 38;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // lblStructure
            // 
            this.lblStructure.AutoSize = true;
            this.lblStructure.Location = new System.Drawing.Point(8, 90);
            this.lblStructure.Name = "lblStructure";
            this.lblStructure.Size = new System.Drawing.Size(156, 13);
            this.lblStructure.TabIndex = 37;
            this.lblStructure.Text = "UNDER WHICH STRUCTURE";
            // 
            // cmbBxStructure
            // 
            this.cmbBxStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxStructure.FormattingEnabled = true;
            this.cmbBxStructure.Location = new System.Drawing.Point(11, 106);
            this.cmbBxStructure.Name = "cmbBxStructure";
            this.cmbBxStructure.Size = new System.Drawing.Size(141, 21);
            this.cmbBxStructure.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "SELECT ORGANIZATION LEVEL";
            // 
            // bttnLeave
            // 
            this.bttnLeave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttnLeave.Location = new System.Drawing.Point(408, 214);
            this.bttnLeave.Name = "bttnLeave";
            this.bttnLeave.Size = new System.Drawing.Size(75, 23);
            this.bttnLeave.TabIndex = 34;
            this.bttnLeave.Text = "Leave";
            this.bttnLeave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "SELECT DIRECTOR";
            // 
            // cmbBxDirector
            // 
            this.cmbBxDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxDirector.FormattingEnabled = true;
            this.cmbBxDirector.Location = new System.Drawing.Point(408, 106);
            this.cmbBxDirector.Name = "cmbBxDirector";
            this.cmbBxDirector.Size = new System.Drawing.Size(180, 21);
            this.cmbBxDirector.TabIndex = 31;
            // 
            // txtBxStructureName
            // 
            this.txtBxStructureName.Location = new System.Drawing.Point(191, 107);
            this.txtBxStructureName.Name = "txtBxStructureName";
            this.txtBxStructureName.Size = new System.Drawing.Size(181, 20);
            this.txtBxStructureName.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "INSERT NAME";
            // 
            // cmbBxLevel
            // 
            this.cmbBxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLevel.FormattingEnabled = true;
            this.cmbBxLevel.Location = new System.Drawing.Point(11, 45);
            this.cmbBxLevel.Name = "cmbBxLevel";
            this.cmbBxLevel.Size = new System.Drawing.Size(141, 21);
            this.cmbBxLevel.TabIndex = 28;
            this.cmbBxLevel.SelectedIndexChanged += new System.EventHandler(this.cmbBxLevel_SelectedIndexChanged_1);
            // 
            // AddStructureFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 249);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.lblStructure);
            this.Controls.Add(this.cmbBxStructure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnLeave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBxDirector);
            this.Controls.Add(this.txtBxStructureName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBxLevel);
            this.MaximumSize = new System.Drawing.Size(642, 288);
            this.MinimumSize = new System.Drawing.Size(642, 288);
            this.Name = "AddStructureFrm";
            this.Text = "NewFirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Label lblStructure;
        private System.Windows.Forms.ComboBox cmbBxStructure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnLeave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBxDirector;
        private System.Windows.Forms.TextBox txtBxStructureName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBxLevel;
    }
}