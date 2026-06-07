using CarRentalSys.Application.Interfaces;
using CarRentalSys.Application.Services;
using CarRentalSys.Infrastructure.EFData;
using Microsoft.EntityFrameworkCore;

namespace CarRentalForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var options = new DbContextOptionsBuilder<AppDbContext>()
       .UseSqlServer("Server=DESKTOP-BLQDC9N;Database=CarRentals;Trusted_Connection=True;TrustServerCertificate=True;")
       .Options;

            using var context = new AppDbContext(options);

            ICarRepository carRepo = new EFCarsRepository(context);

            ICustomerRepository customerRepo = new EFCustomersRepository(context);

            IRentalRepository rentalRepo = new EFRentalsRepository(context);

            CarService carService = new CarService(carRepo, rentalRepo);

            CustomerService customerService = new CustomerService(customerRepo, rentalRepo);

            RentalService rentalService = new RentalService(carRepo, rentalRepo, customerRepo);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(carService,customerService, rentalService));
        }
    }
}