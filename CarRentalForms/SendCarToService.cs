using CarRentalSys.Application.Services;
using CarRentalSys.Domain.Entities;
using CarRentalSys.Domain.Enums;
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
    public partial class SendCarToService : Form
    {
        private readonly CarService carSrvc;
        public SendCarToService(CarService service)
        {
            InitializeComponent();
            carSrvc = service;
        }

        private void SendCarToService_Load(object sender, EventArgs e)
        {
            cmbCars.DataSource =
            carSrvc.GetAllCars()
              .Where(c => c.Status != CarStatus.InMaintenance)
              .ToList();

            cmbCars.DisplayMember = "Model";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Car selectedCar =
            (Car)cmbCars.SelectedItem;
 
            carSrvc.SendToMaintenance(selectedCar.Id);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
