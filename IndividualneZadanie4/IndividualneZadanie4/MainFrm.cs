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
        public MainFrm()
        {
            InitializeComponent();
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
    }
}
