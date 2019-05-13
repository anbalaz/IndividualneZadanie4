using Data.Models;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                newFrm.ShowDialog();
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
            //dtGrdVwFirm.Columns["UserID"].Visible = false;
            cmbBxFirms.DisplayMember = nameof(Structure.Name);
        }

        private void RefreshDatagridFirm(List<Structure> structures)
        {
            dtGrdVwFirm.Rows.Clear();
            foreach (var structure in structures)
            {
                dtGrdVwFirm.Rows.Add(structure.Code,structure.Name );
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

        private void dtGrdVwFirm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int code=(int)dtGrdVwFirm.CurrentRow.Cells["Code"].Value;
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
    }
}