using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IndividualneZadanie4
{
    public partial class MainFrm : Form
    {
        private MainFrmService _mainFrmService = new MainFrmService();
        public MainFrm()
        {
            InitializeComponent();
            InitializeDataGrids();
            RefreshDatagridFirm(_mainFrmService.GetStructuresList(0, OrganizationLevel.Firm));
        }

        private void bttnManageStructures_Click(object sender, EventArgs e)
        {
            using (ManageStructuresForm newFrm = new ManageStructuresForm())
            {
                if (newFrm.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void bttnManageEmployees_Click(object sender, EventArgs e)
        {
            using (ManageEmployeesForm newFrm = new ManageEmployeesForm())
            {
                newFrm.ShowDialog();
            }
        }

        private void bttnNewFirm_Click(object sender, EventArgs e)
        {
            using (NewFirmForm newFrm = new NewFirmForm())
            {
                newFrm.ShowDialog();
            }
        }

        private void InitializeDataGrids()
        {
            dtGrdVwFirm.Columns.Add("Code", "Code");
            dtGrdVwFirm.Columns.Add("Name", "Name");
            dtGrdVwDivision.Columns.Add("Code", "Code");
            dtGrdVwDivision.Columns.Add("Name", "Name");
            dtGrdVwProject.Columns.Add("Code", "Code");
            dtGrdVwProject.Columns.Add("Name", "Name");
            dtGrdVwDepartments.Columns.Add("Code", "Code");
            dtGrdVwDepartments.Columns.Add("Name", "Name");

            dtGrdVwEmployee.Columns.Add("LastName", "LastName");
            dtGrdVwEmployee.Columns.Add("FirstName", "FirstName");
            dtGrdVwEmployee.Columns.Add("Title", "Title");
            dtGrdVwEmployee.Columns.Add("PhoneNumber", "PhoneNumber");
            dtGrdVwEmployee.Columns.Add("EmailAddress", "EmailAddress");
        }
        #region Refresh Datagrids
        private void RefreshDatagridFirm(List<Structure> structures)
        {
            dtGrdVwFirm.Rows.Clear();
            foreach (var structure in structures)
            {
                dtGrdVwFirm.Rows.Add(structure.Code, structure.Name);
            }
        }

        private void RefreshDatagridDivision(List<Structure> structures)
        {
            dtGrdVwDivision.Rows.Clear();
            foreach (var structure in structures)
            {
                dtGrdVwDivision.Rows.Add(structure.Code, structure.Name);
            }
        }

        private void RefreshDatagridProject(List<Structure> structures)
        {
            dtGrdVwProject.Rows.Clear();
            foreach (var structure in structures)
            {
                dtGrdVwProject.Rows.Add(structure.Code, structure.Name);
            }
        }

        private void RefreshDatagridDepartment(List<Structure> structures)
        {
            dtGrdVwDepartments.Rows.Clear();
            foreach (var structure in structures)
            {
                dtGrdVwDepartments.Rows.Add(structure.Code, structure.Name);
            }
        }

        private void RefreshDatagridEmployee(List<Employee> employees)
        {
            dtGrdVwEmployee.Rows.Clear();
            foreach (var employee in employees)
            {
                dtGrdVwEmployee.Rows.Add(employee.LastName, employee.FirstName, employee.Title, employee.PhoneNumber, employee.EmailAddress);
            }
        }
        #endregion

        private void dtGrdVwFirm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int code = (int)dtGrdVwFirm.CurrentRow.Cells["Code"].Value;
            RefreshDatagridDivision(_mainFrmService.GetStructuresList(code, OrganizationLevel.Division));
        }

        private void dtGrdVwDivision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int code = (int)dtGrdVwDivision.CurrentRow.Cells["Code"].Value;
            RefreshDatagridProject(_mainFrmService.GetStructuresList(code, OrganizationLevel.Project));
        }

        private void dtGrdVwProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int code = (int)dtGrdVwProject.CurrentRow.Cells["Code"].Value;
            RefreshDatagridDepartment(_mainFrmService.GetStructuresList(code, OrganizationLevel.Department));
        }

        private void dtGrdVwDepartments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int code = (int)dtGrdVwDepartments.CurrentRow.Cells["Code"].Value;
            RefreshDatagridEmployee(_mainFrmService.GetEmployeesList(code));
        }
    }
}