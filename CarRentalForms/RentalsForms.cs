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
using CarRentalSys.Domain.Enums;
using CarRentalSys.Domain.RentalObjects;

namespace CarRentalForms
{
    public partial class RentalsForms : Form
    {
        private CarService carSrvc;
        private RentalService rentalSrvc;
        private CustomerService customerSrvc;
        private List<Damage> damageList;
        public RentalsForms(RentalService rentalSrvc, CustomerService customerSrvc, CarService carService)
        {
            InitializeComponent();
            this.rentalSrvc = rentalSrvc;
            this.customerSrvc = customerSrvc;
            this.carSrvc = carService;
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rentals rnt = dgvRentals.CurrentRow.DataBoundItem as Rentals;
            rentalSrvc.CancelRental(rnt.Id);
        }

        private void btnStartRent_Click(object sender, EventArgs e)
        {
            Rentals rnt = dgvRentals.CurrentRow.DataBoundItem as Rentals;
            rentalSrvc.StartRental(rnt.Id);
        }

        private void btnCreateRent_Click(object sender, EventArgs e)
        {
            Customer client = cmbClient.SelectedItem as Customer;
            Car car = cmbCar.SelectedItem as Car;
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;
            int promo = int.Parse(txtPromo.Text);
            Rentals newRental = rentalSrvc.CreateRental(client.Id, car.Id, start, end, promo);


        }

        private void dgvRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDmg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RentalsForms_Load(object sender, EventArgs e)
        {
            dgvCars.DataSource = carSrvc.GetAllCars();
            dgvRentals.DataSource = rentalSrvc.GetAllRentals();
            //dgvDmg.DataSource = 
            var customers = customerSrvc.GetAllCustomers();
            cmbClient.DataSource = customers;
            var cars = carSrvc.GetAvailableCars();
            cmbCar.DataSource = cars;
            cmbClient.DisplayMember = "FullName";
            cmbCar.DisplayMember = "Model";
            cmbClient.ValueMember = "Id";
            cmbCar.ValueMember = "Id";
            timer1.Start();
            cmbSeverity.Items.Add(DamageSeverity.Severe);
            cmbSeverity.Items.Add(DamageSeverity.Moderate);
            cmbSeverity.Items.Add(DamageSeverity.Minor);
            damageList = new List<Damage>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Rentals rnt = dgvRentals.CurrentRow.DataBoundItem as Rentals;
            txtDeposit.Text = rnt.Deposit.ToString();
            txtPricePerDay.Text = rnt.TotalPrice.ToString();



        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Rentals rnt = dgvRentals.CurrentRow.DataBoundItem as Rentals;
            rentalSrvc.CompleteRental(rnt.Id);
        }

        private void btnAddDmg_Click(object sender, EventArgs e)
        {
            DamageSeverity severity = (DamageSeverity)cmbSeverity.SelectedItem;
            Damage dmg = new Damage(txtDscDmg.Text, severity);
            damageList.Add(dmg);
        }

        private void btnCreateInspection_Click(object sender, EventArgs e)
        {
            Rentals rnt = dgvRentals.CurrentRow.DataBoundItem as Rentals;
            rentalSrvc.RegisterInspection(rnt.Id, damageList);
            damageList.Clear();
        }

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
            Rentals rnt = dgvRentals.CurrentRow.DataBoundItem as Rentals;
            Payments payment = rentalSrvc.ProcessPayment(rnt.Id);
            MessageBox.Show($"{payment.Amount}eur");
        }

        private void btnReturnDeposit_Click(object sender, EventArgs e)
        {
            Rentals rnt = dgvRentals.CurrentRow.DataBoundItem as Rentals;
            decimal deposit = rentalSrvc.ReturnDeposit(rnt.Id);
            if (deposit == 0)
            {
                MessageBox.Show("Има щети никъв депозит не връщам");
            }
            else MessageBox.Show($"Заповядайте {deposit}eur");
        }
    }
}
