using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace IndividualneZadanie4
{
    public partial class AddStructureFrm : Form
    {
        private MainFrmService _mainFrmService = new MainFrmService();

        public AddStructureFrm()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            string message = "Data were not inserted";
            if (!string.IsNullOrWhiteSpace(txtBxStructureName.Text) && !string.IsNullOrEmpty(txtBxStructureName.Text))
            {
                Structure structure = GetStructure();
                if (_mainFrmService.IsStructureInserted(structure) == true)
                {
                    message = "Data were inserted";
                }
            }
            RefreshStructure();
            RefreshDirector();
            MessageBox.Show(message);
        }

        private void bttnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBxStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDirector();
        }

        private void InitializeFields()
        {
            cmbBxLevel.DataSource = Enum.GetValues(typeof(OrganizationLevel));
            RefreshStructure();
            RefreshDirector();
        }

        private void cmbBxLevel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RefreshStructure();
            if (cmbBxStructure.Visible == true)
            {
                RefreshDirector();
            }
        }

        private void RefreshDirector()
        {

            List<Employee> employees = _mainFrmService.GetEveryEmployeeWhoIsNotDirector(0);
            cmbBxDirector.DataSource = employees;
            cmbBxDirector.DisplayMember = nameof(Employee.FullName);
        }

        private void RefreshStructure()
        {
            List<Structure> structures = _mainFrmService.GetStructuresList();
            if ((int)cmbBxLevel.SelectedItem != 1)
            {
                cmbBxStructure.Visible = true;
                lblStructure.Visible = true;
                cmbBxStructure.DataSource = structures.Where(structure => (int)structure.Level == (int)cmbBxLevel.SelectedItem - 1).ToList();
                cmbBxStructure.DisplayMember = nameof(Structure.Name);
            }
            else
            {
                cmbBxStructure.Visible = false;
                lblStructure.Visible = false;
            }
        }

        private Structure GetStructure()
        {
            Structure structure = new Structure();
            structure.Name = txtBxStructureName.Text;
            structure.ID = _mainFrmService.GenerateCode();
            structure.Level = (OrganizationLevel)cmbBxLevel.SelectedItem;
            structure.Employee = cmbBxDirector.SelectedItem != null ? (Employee)cmbBxDirector.SelectedItem : null;
            if (cmbBxStructure.Visible == true)
                structure.FirmStructure = (Structure)cmbBxStructure.SelectedItem;
            return structure;
        }
    }
}