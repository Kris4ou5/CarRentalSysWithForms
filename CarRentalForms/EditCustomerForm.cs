using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSys.Application.Services;
using CarRentalSys.Domain.Entities;

namespace CarRentalForms
{
    public partial class EditCustomerForm : Form
    {
        private Customer _customer;
        private CustomerService srvc;
        public EditCustomerForm(Customer cus, CustomerService srvc)
        {
            InitializeComponent();
            _customer = cus;
            this.srvc = srvc;
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            LoadAllInfo(_customer);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLicense_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_customer.FullName == null)
            {
                srvc.RegisterCustomer(txtName.Text, txtLicense.Text, txtPhone.Text, txtEmail.Text);
            }
            else
            {   
                srvc.UpdateCustomerContact(_customer.Id, txtName.Text, txtLicense.Text, txtPhone.Text, txtEmail.Text);
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        public void LoadAllInfo(Customer customer)
        {
            txtName.Text = customer.FullName;
            txtLicense.Text = customer.DriverLicenseNumber;
            txtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
        }
    }
}
