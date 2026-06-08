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

namespace CarRentalForms
{
    public partial class ChangeCarStatusForm : Form
    {
        private Car car;
        private CarService carSrvc;
        public ChangeCarStatusForm(Car cr, CarService srvc)
        {
            InitializeComponent();
            car = cr;
            carSrvc = srvc;
        }

        private void ChangeCarStatusForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add(CarStatus.Available);
            cmbStatus.Items.Add(CarStatus.Rented);
            cmbStatus.Items.Add(CarStatus.InMaintenance);
            lblBrand.Text = car.Brand;
            lblModel.Text = car.Model;
            lblCategory.Text = car.Category.ToString();
            lblPrice.Text = car.PricePerDay.ToString();
            cmbStatus.SelectedItem = car.Status;
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            CarStatus selectStatus = (CarStatus)cmbStatus.SelectedItem;
            carSrvc.ChangeCarStatus(car.Id, selectStatus);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
