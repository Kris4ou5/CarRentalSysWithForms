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
using CarRentalSys.Domain.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentalForms
{
    public partial class RegisterCarForm : Form
    {
        private CarService carSrvc;
        public RegisterCarForm(CarService carService)
        {
            InitializeComponent();
            carSrvc = carService;
        }

        private void RegisterCarForm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add(CarCategory.Van);
            cmbCategory.Items.Add(CarCategory.SUV);
            cmbCategory.Items.Add(CarCategory.Luxury);
            cmbCategory.Items.Add(CarCategory.Intermediate);
            cmbCategory.Items.Add(CarCategory.Economy);
            cmbCategory.Items.Add(CarCategory.Compact);
            cmbCategory.Items.Add(CarCategory.Electric);
            cmbCategory.Items.Add(CarCategory.Standard);
            cmbCategory.Items.Add(CarCategory.Sports);
        }

        private void btnRegisterCar_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null)
                throw new ArgumentException("No category selected");
                
            
            CarCategory selected = (CarCategory)cmbCategory.SelectedItem;
            decimal PricePerday = decimal.Parse(txtPricePerDay.Text);
            carSrvc.AddCar(txtBrand.Text,txtModel.Text,selected,PricePerday);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}
