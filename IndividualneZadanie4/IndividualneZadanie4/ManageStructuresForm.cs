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
        public ManageStructuresForm()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeFields()
        {
            cmbBxLevel.DataSource = Enum.GetValues(typeof(OrganizationLevel));
            RefreshDirector();
            RefreshStructure();
        }

        private void RefreshDirector()
        {
            Structure structureLevel = (Structure)cmbBxStructure.SelectedValue;
            List<Employee> employees = _mainFrmService.GetEmployeesList();

            txtBxStructureName.Text = structureLevel.Name;
            cmbBxDirector.Text = _mainFrmService.GetEmployee(structureLevel.Code).FullName;
            cmbBxDirector.BindingContext = new BindingContext();
            cmbBxDirector.DataSource = employees;
            cmbBxDirector.DisplayMember = nameof(Employee.FullName);
        }

        private void RefreshStructure()
        {
            List<Structure> structures = _mainFrmService.GetStructuresList();
            cmbBxStructure.DataSource = structures.Where(structure => structure.Level == (OrganizationLevel)cmbBxLevel.SelectedItem).ToList();
            cmbBxStructure.DisplayMember = nameof(Structure.Name);
            Structure structureLevel = (Structure)cmbBxStructure.SelectedValue;
            
        }

        private void cmbBxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshStructure();
            RefreshDirector();
        }

        private void cmbBxStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDirector();
        }
    }
}
