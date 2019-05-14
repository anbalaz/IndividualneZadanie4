using Data.Models;
using Service;
using System;
using System.Windows.Forms;

namespace IndividualneZadanie4
{
    public partial class ManageEmployeesForm : Form
    {
        private MainFrmService _mainFrmService = new MainFrmService();

        public ManageEmployeesForm()
        {
            InitializeComponent();
            InitializeStructureCmbBx();
            InitializeButtonsUpdate();
            InitializeEmployeesCmbBx();
        }

        public ManageEmployeesForm(int number)
        {
            InitializeComponent();
            InitializeButtonsAdd();
            InitializeStructureCmbBx();
        }

        private void InitializeButtonsAdd()
        {
            cmbBxEmployees.Visible = false;
            lblEmployees.Visible = false;
            bttnUpdate.Visible = false;
        }

        private void InitializeButtonsUpdate()
        {
            bttnSave.Visible = false;
        }

        private void RefreshButtonsAfterAdding()
        {
            txtBxFirstName.Text = string.Empty;
            txtBxLastName.Text = string.Empty;
            txtBxTitle.Text = string.Empty;
            txtBxPhoneNumber.Text = string.Empty;
            txtBxEmailAddress.Text = string.Empty;
            chckBxInDepartment.Checked = false;
        }

        private void InitializeStructureCmbBx()
        {
            cmbBxStructures.DataSource = _mainFrmService.GetStructuresList(OrganizationLevel.Department);
            cmbBxStructures.DisplayMember = nameof(Structure.Name);
        }

        private void InitializeEmployeesCmbBx()
        {
            cmbBxEmployees.DataSource = _mainFrmService.GetEmployeesList();
            cmbBxEmployees.DisplayMember = nameof(Employee.FullName);
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            string message = "Employee was not added";
            if (!string.IsNullOrEmpty(txtBxFirstName.Text) && !string.IsNullOrEmpty(txtBxLastName.Text))
            {
                Employee employee = CreateEmployee();
                if (_mainFrmService.InsertEmployee(employee))
                {
                    message = "Employee was added";
                    RefreshButtonsAfterAdding();
                }
            }
            MessageBox.Show(message);
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void bttnLeave_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Employee CreateEmployee()
        {
            Employee employee = new Employee();
            employee.FirstName = txtBxFirstName.Text;
            employee.LastName = txtBxLastName.Text;
            employee.Title = string.IsNullOrEmpty(txtBxTitle.Text) ? null : txtBxTitle.Text;
            employee.PhoneNumber = string.IsNullOrEmpty(txtBxPhoneNumber.Text) ? null : txtBxPhoneNumber.Text;
            employee.EmailAddress = string.IsNullOrEmpty(txtBxEmailAddress.Text) ? null : txtBxEmailAddress.Text;
            employee.FirmStructure = chckBxInDepartment.Checked ? null : (Structure)cmbBxStructures.SelectedItem;
            return employee;
        }
    }
}
