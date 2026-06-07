using CarRentalSys.Application.Services;
using CarRentalSys.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRentalForms
{
    public partial class Form1 : Form
    {
        private readonly CarService carSrvc;
        private readonly RentalService rentalSrvc;
        private readonly CustomerService customerSrvc;


        public Form1(CarService csrvc, CustomerService cussrvc, RentalService rsrvc)
        {
            InitializeComponent();
            carSrvc = csrvc;
            customerSrvc = cussrvc;
            rentalSrvc = rsrvc;
            dataCustomers.DataSource = customerSrvc.GetAllCustomers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCurPanel.Text = "Main";
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerPanel.BringToFront();
            labelCurPanel.Text = "Customers";
            panelMain.SendToBack();

        }

        private void CustomerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataCustomers.CurrentRow == null)
                return;
            Customer customer = dataCustomers.CurrentRow.DataBoundItem as Customer;

            EditCustomerForm form = new EditCustomerForm(customer, customerSrvc);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                dataCustomers.Refresh();
            }
       }

        private void btnMain_Click(object sender, EventArgs e)
        {
            labelCurPanel.Text = "Main";
            panelMain.BringToFront();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            dataGridMainCustomers.DataSource = customerSrvc.GetAllCustomers();
            dataGridMainRentals.DataSource = rentalSrvc.GetActiveRentals();
            dataGridMainCars.DataSource = carSrvc.GetAllCars();
        }

        private void labelCurPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            labelCurPanel.Text = "Rentals";
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            labelCurPanel.Text = "Cars";
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            EditCustomerForm form = new EditCustomerForm(customer, customerSrvc);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                dataCustomers.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataCustomers.CurrentRow == null)
                return;
            Customer customer = dataCustomers.CurrentRow.DataBoundItem as Customer;
           dataCustomers.DataSource = customerSrvc.GetCustomerRentalHistory(customer.Id);
        }
    }
}
