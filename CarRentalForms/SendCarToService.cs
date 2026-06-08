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

        }
    }
}
