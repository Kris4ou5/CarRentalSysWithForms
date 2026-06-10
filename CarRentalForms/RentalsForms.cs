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

namespace CarRentalForms
{
    public partial class RentalsForms : Form
    {
        private CarService carSrvc;
        private RentalService rentalSrvc;
        private CustomerService customerSrvc;
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

        }

        private void btnStartRent_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateRent_Click(object sender, EventArgs e)
        {

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
            dgvDmg.DataSource = 

        }
    }
}
