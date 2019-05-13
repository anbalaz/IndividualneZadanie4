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
            InitializeCmbBx();
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

        private void InitializeCmbBx()
        {
            cmbBxFirms.DataSource = new BindingSource(_mainFrmService.GetStructuresList(0,OrganizationLevel.Firm), null);
            cmbBxFirms.DisplayMember = nameof(Structure.Name);
        }

        private void cmbBxFirms_SelectedValueChanged(object sender, EventArgs e)
        {
            trVwFirmStructure.Nodes.Clear();
            Structure structure = (Structure)cmbBxFirms.SelectedValue;
            trVwFirmStructure.Nodes.Add(structure.Name);

            List <Structure> structures=_mainFrmService.GetStructuresList(structure.ID, OrganizationLevel.Division);
            foreach (var part in structures)
            {
                trVwFirmStructure.Nodes[0].Nodes.Add(part.Name);
            }

            List<Structure> structures1 = _mainFrmService.GetStructuresList(structure.ID, OrganizationLevel.Division);
            foreach (var part in structures1)
            {
                trVwFirmStructure.Nodes.Add(part.Name,);
            }
        }
        private void mothod(int code, OrganizationLevel organization)
        {
            List<Structure> castiFirmy;
            castiFirmy= _mainFrmService.GetStructuresList(code, organization);
        }
    }
}