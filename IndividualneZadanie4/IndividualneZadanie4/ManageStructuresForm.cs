using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IndividualneZadanie4
{
    public partial class ManageStructuresForm : Form
    {
        private MainFrmService _mainFrmService = new MainFrmService();
        private Structure _structure;
        private int _previousDirectorId;
        public ManageStructuresForm()
        {
            InitializeComponent();
            _mainFrmService.GetEveryEmployeeWhoIsNotDirector(5);
            InitializeFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeFields()
        {
            cmbBxLevel.DataSource = Enum.GetValues(typeof(OrganizationLevel));
            RefreshStructure();
            RefreshDirectorAndStructureBoxes();
        }

        private void RefreshDirectorAndStructureBoxes()
        {
            _structure = (Structure)cmbBxStructure.SelectedValue;
            if (_structure.Employee != null)
                _previousDirectorId = _structure.Employee.ID;

            List<Employee> employees = _mainFrmService.GetEveryEmployeeWhoIsNotDirector(_structure.Code);
            if (_structure != null)
            {
                txtBxStructureName.Text = _structure.Name;
                cmbBxDirector.DataSource = employees;
                cmbBxDirector.DisplayMember = nameof(Employee.FullName);
                if (_structure.Employee != null)
                    cmbBxDirector.Text = _mainFrmService.GetEmployee(_structure.Employee.ID).FullName;
            }
        }

        private void RefreshStructure()
        {
            List<Structure> structures = _mainFrmService.GetStructuresList();
            cmbBxStructure.DataSource = structures.Where(structure => structure.Level == (OrganizationLevel)cmbBxLevel.SelectedItem).ToList();
            cmbBxStructure.DisplayMember = nameof(Structure.Name);
        }

        private void cmbBxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshStructure();
            RefreshDirectorAndStructureBoxes();
        }

        private void cmbBxStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDirectorAndStructureBoxes();
        }



        private void bttnSave_Click(object sender, EventArgs e)
        {
            _structure.Employee = (Employee)cmbBxDirector.SelectedItem;
            _structure.Name = txtBxStructureName.Text;
            string message = "Data were not updated";
            if (!string.IsNullOrWhiteSpace(txtBxStructureName.Text) && !string.IsNullOrEmpty(txtBxStructureName.Text))
            {
                if (_mainFrmService.UpdateStructure(_structure,_previousDirectorId) == true)
                {
                    message = "Data were updated";
                }
            }
            RefreshStructure();
            RefreshDirectorAndStructureBoxes();
            MessageBox.Show(message);
        }
    }
}
