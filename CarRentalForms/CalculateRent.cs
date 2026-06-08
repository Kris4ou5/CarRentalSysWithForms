using CarRentalSys.Application.Services;
using CarRentalSys.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalForms
{
    public partial class CalculateRent : Form
    {
        private readonly CarService carSrvc;
        private readonly RentalService rentalSrvc;

        public CalculateRent(CarService carService, RentalService rentalService)
        {
            InitializeComponent();
            carSrvc = carService;
            rentalSrvc = rentalService;
        }

        private void CalculateRent_Load(object sender, EventArgs e)
        {
            cmbCars.DataSource =
               carSrvc.GetAllCars();

            cmbCars.DisplayMember = "Model";
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            if (cmbCars.SelectedItem == null)
                return;

            Car selectedCar =
                (Car)cmbCars.SelectedItem;

            int days = int.Parse(txtDays.Text);

            int promo = int.Parse(txtPromo.Text);

            decimal price = rentalSrvc.Price(selectedCar, days, promo);

            txtResult.Text = price.ToString("F2") + " lv";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
