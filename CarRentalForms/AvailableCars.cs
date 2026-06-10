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
    public partial class AvailableCars : Form
    {
        private readonly CarService carSrvc;

        public AvailableCars(CarService service)
        {
            InitializeComponent();
            carSrvc = service;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            DateTime start = dtStart.Value;
            DateTime end = dtEnd.Value;

            dgvAvailableCars.DataSource = carSrvc.GetAvailableCarsForPeriod(start, end);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AvailableCars_Load(object sender, EventArgs e)
        {

        }

        
    }
}
