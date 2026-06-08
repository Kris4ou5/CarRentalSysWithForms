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
            panelMain.BringToFront();
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
            LoadCarData();
            LoadCustomerData();
            LoadRentalsData();

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
            panelCars.BringToFront();
            dgvCars.DataSource = carSrvc.GetAllCars();
        }

        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            EditCustomerForm form = new EditCustomerForm(customer, customerSrvc);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                LoadCustomerData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataCustomers.CurrentRow == null)
                return;
            Customer customer = dataCustomers.CurrentRow.DataBoundItem as Customer;
            dataCustomers.DataSource = customerSrvc.GetCustomerRentalHistory(customer.Id);
        }

        public static void ChangeButtonColor()
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //DatalOads
        public void LoadCarData()
        {
            dataGridMainCars.DataSource = carSrvc.GetAllCars();
        }

        public void LoadCustomerData()
        {
            dataGridMainCustomers.DataSource = customerSrvc.GetAllCustomers();
        }
        public void LoadRentalsData()
        {
            dataGridMainRentals.DataSource = rentalSrvc.GetActiveRentals();
        }
        //CARS
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Form carAddform = new RegisterCarForm(carSrvc);
            carAddform.ShowDialog();


        }

        private void btnChangeCarStatus_Click(object sender, EventArgs e)
        {
            Car selectedCar = dgvCars.CurrentRow.DataBoundItem as Car;
            if (selectedCar == null) throw new ArgumentException("Избери кола!!!");
            Form changeStatusForm = new ChangeCarStatusForm(selectedCar, carSrvc);
            changeStatusForm.ShowDialog();
            if (DialogResult.OK != changeStatusForm.DialogResult)
                throw new ArgumentException("Greshka pri smqna");
        }

        private void btnAvailableCars_Click(object sender, EventArgs e)
        {

        }

        private void btnPriceCalc_Click(object sender, EventArgs e)
        {

        }

        private void btnService_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCarData();
            LoadCustomerData();
            LoadRentalsData();
            dgvCars.DataSource = carSrvc.GetAllCars();
            dataCustomers.DataSource = customerSrvc.GetAllCustomers();

        }

        private void panelCars_Paint(object sender, PaintEventArgs e)
        {

        }
        //Rents

    }
}
