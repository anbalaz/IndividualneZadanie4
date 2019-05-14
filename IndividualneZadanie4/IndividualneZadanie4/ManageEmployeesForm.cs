using Data.Models;
using Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IndividualneZadanie4
{
    public partial class ManageEmployeesForm : Form
    {
        private MainFrmService _mainFrmService = new MainFrmService();
        private Employee _employee;

        public ManageEmployeesForm()
        {
            InitializeComponent();
            InitializeStructureCmbBx();
            RefreshConrollsUpdate();
            RefreshEmployeesCmbBx();
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
            lblDirector.Visible = false;
        }

        private void RefreshConrollsUpdate()
        {
            bttnSave.Visible = false;
            lblDirector.ForeColor = Color.Red;
            lblDirector.Visible = false;
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

        private void RefreshEmployeesCmbBx()
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
            string message = "Employee was not updated";
            if (!string.IsNullOrEmpty(txtBxFirstName.Text) && !string.IsNullOrEmpty(txtBxLastName.Text))
            {
                UpdateEmployee();
                if (_mainFrmService.UpdateEmployee(_employee))
                {
                    message = "Employee was updated";
                    RefreshConrollsUpdate();
                    RefreshEmployeesCmbBx();
                }
            }
            MessageBox.Show(message);
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

        private Employee UpdateEmployee()
        {
            _employee.FirstName = txtBxFirstName.Text;
            _employee.LastName = txtBxLastName.Text;
            _employee.Title = string.IsNullOrEmpty(txtBxTitle.Text) ? null : txtBxTitle.Text;
            _employee.PhoneNumber = string.IsNullOrEmpty(txtBxPhoneNumber.Text) ? null : txtBxPhoneNumber.Text;
            _employee.EmailAddress = string.IsNullOrEmpty(txtBxEmailAddress.Text) ? null : txtBxEmailAddress.Text;
            if (lblDirector.Visible!=true)
            _employee.FirmStructure = chckBxInDepartment.Checked ? null : (Structure)cmbBxStructures.SelectedItem;
            return _employee;
        }

        private void cmbBxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetControllersAfterChangingEmployee();
        }

        public void SetControllersAfterChangingEmployee()
        {
            _employee = (Employee)cmbBxEmployees.SelectedItem;
            txtBxFirstName.Text = _employee.FirstName;
            txtBxLastName.Text = _employee.LastName;
            txtBxTitle.Text = _employee.Title ?? string.Empty;
            txtBxPhoneNumber.Text = _employee.PhoneNumber ?? string.Empty;
            txtBxEmailAddress.Text = _employee.EmailAddress ?? string.Empty;

            if (_employee.FirmStructure != null)
            {
                if (_mainFrmService.IsEmployeeDirector(_employee))
                {
                    lblDirector.Visible = true;
                    cmbBxStructures.Visible = false;
                    chckBxInDepartment.Checked = false;
                }
                else
                {
                    lblDirector.Visible = false;
                    cmbBxStructures.Visible = true;
                    chckBxInDepartment.Checked = false;
                    cmbBxStructures.Text = _mainFrmService.GetStructure(_employee.FirmStructure.ID).Name;
                }
            }
            else
            {
                lblDirector.Visible = false;
                cmbBxStructures.Visible = true;
                chckBxInDepartment.Checked = true;
            }
        }
    }
}
