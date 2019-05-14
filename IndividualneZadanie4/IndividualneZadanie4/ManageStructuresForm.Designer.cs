namespace IndividualneZadanie4
{
    partial class ManageStructuresForm
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
            this.bttnSave = new System.Windows.Forms.Button();
            this.cmbBxDirector = new System.Windows.Forms.ComboBox();
            this.txtBxStructureName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBxLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnLeave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxStructure = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttnSave
            // 
            this.bttnSave.Location = new System.Drawing.Point(514, 214);
            this.bttnSave.Name = "bttnSave";
            this.bttnSave.Size = new System.Drawing.Size(75, 23);
            this.bttnSave.TabIndex = 18;
            this.bttnSave.Text = "Save";
            this.bttnSave.UseVisualStyleBackColor = true;
            this.bttnSave.Click += new System.EventHandler(this.bttnSave_Click);
            // 
            // cmbBxDirector
            // 
            this.cmbBxDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxDirector.FormattingEnabled = true;
            this.cmbBxDirector.Location = new System.Drawing.Point(409, 108);
            this.cmbBxDirector.Name = "cmbBxDirector";
            this.cmbBxDirector.Size = new System.Drawing.Size(180, 21);
            this.cmbBxDirector.TabIndex = 17;
            // 
            // txtBxStructureName
            // 
            this.txtBxStructureName.Location = new System.Drawing.Point(192, 109);
            this.txtBxStructureName.Name = "txtBxStructureName";
            this.txtBxStructureName.Size = new System.Drawing.Size(181, 20);
            this.txtBxStructureName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "NAME";
            // 
            // cmbBxLevel
            // 
            this.cmbBxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxLevel.FormattingEnabled = true;
            this.cmbBxLevel.Location = new System.Drawing.Point(12, 47);
            this.cmbBxLevel.Name = "cmbBxLevel";
            this.cmbBxLevel.Size = new System.Drawing.Size(141, 21);
            this.cmbBxLevel.TabIndex = 14;
            this.cmbBxLevel.SelectedIndexChanged += new System.EventHandler(this.cmbBxLevel_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "DIRECTOR";
            // 
            // bttnLeave
            // 
            this.bttnLeave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttnLeave.Location = new System.Drawing.Point(514, 157);
            this.bttnLeave.Name = "bttnLeave";
            this.bttnLeave.Size = new System.Drawing.Size(75, 23);
            this.bttnLeave.TabIndex = 23;
            this.bttnLeave.Text = "Leave";
            this.bttnLeave.UseVisualStyleBackColor = true;
            this.bttnLeave.Click += new System.EventHandler(this.bttnLeave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ORGANIZATION LEVEL";
            // 
            // cmbBxStructure
            // 
            this.cmbBxStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxStructure.FormattingEnabled = true;
            this.cmbBxStructure.Location = new System.Drawing.Point(12, 108);
            this.cmbBxStructure.Name = "cmbBxStructure";
            this.cmbBxStructure.Size = new System.Drawing.Size(141, 21);
            this.cmbBxStructure.TabIndex = 25;
            this.cmbBxStructure.SelectedIndexChanged += new System.EventHandler(this.cmbBxStructure_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "STRUCTURE";
            // 
            // ManageStructuresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 249);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBxStructure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnLeave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttnSave);
            this.Controls.Add(this.cmbBxDirector);
            this.Controls.Add(this.txtBxStructureName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBxLevel);
            this.MaximumSize = new System.Drawing.Size(642, 288);
            this.MinimumSize = new System.Drawing.Size(642, 288);
            this.Name = "ManageStructuresForm";
            this.Text = "ManageStructures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnSave;
        private System.Windows.Forms.ComboBox cmbBxDirector;
        private System.Windows.Forms.TextBox txtBxStructureName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBxLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnLeave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxStructure;
        private System.Windows.Forms.Label label2;
    }
}