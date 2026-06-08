using CarRentalSys.Application.Services;
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

        private void CalculateRentForm_Load(object sender, EventArgs e)
        {
            cmbCars.DataSource =
                carSrvc.GetAllCars();

            cmbCars.DisplayMember = "Model";
        }

        private void CalculateRent_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
