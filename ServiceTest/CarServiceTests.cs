using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSys.Application;
using CarRentalSys.Application.Interfaces;
using CarRentalSys.Application.Services;
using CarRentalSys.Domain.Entities;
using CarRentalSys.Domain.Enums;
using CarRentalSys.Infrastructure;
using NUnit.Framework;


namespace ServiceTest
{
    [TestFixture]
    public class CarServiceTests
    {
        private ICarRepository _carRepo;
        private IRentalRepository _rentalRepo;
        private CarService srvc;
        [SetUp]
        public void SetUp()
        {
            _carRepo = new FakeCarRepository();
            _rentalRepo = new FakeRentalRepository();
             srvc = new CarService(_carRepo, _rentalRepo);
        }
        [Test]
        public void ShouldAddCar()
        {
           
            srvc.AddCar("Sigma", "Bot", CarRentalSys.Domain.Enums.CarCategory.Economy, 200);
            var result = _carRepo.GetById(1);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Model, Is.EqualTo("Bot"));
            Assert.That(result.Brand, Is.EqualTo("Sigma"));
            Assert.That(result.Category, Is.EqualTo(CarRentalSys.Domain.Enums.CarCategory.Economy));
            Assert.That(result.PricePerDay, Is.EqualTo(200));
        }
        [Test]
        public void ShouldChangeStatus()
        {
            srvc.AddCar("Sigma", "Bot", CarRentalSys.Domain.Enums.CarCategory.Economy, 200);
            srvc.ChangeCarStatus(1, CarRentalSys.Domain.Enums.CarStatus.InMaintenance);
            var result = _carRepo.GetById(1);

            Assert.That(result.Status, Is.EqualTo(CarRentalSys.Domain.Enums.CarStatus.InMaintenance));
        }

        [Test]
        public void ShouldGetAllCars()
        {
            srvc.AddCar("Sigma", "Bot", CarRentalSys.Domain.Enums.CarCategory.Economy, 200);
            var result = srvc.GetAllCars();
            Assert.That(result.Count, Is.EqualTo(1));
            var car = result[0];
            Assert.That(car.Brand, Is.EqualTo("Sigma"));
            Assert.That(car.Model, Is.EqualTo("Bot"));
            Assert.That(car.Category, Is.EqualTo(CarRentalSys.Domain.Enums.CarCategory.Economy));
            Assert.That(car.PricePerDay, Is.EqualTo(200));
        }

        [Test]
        public void GetAvailableCars_ShouldReturnOnlyAvailableCars()
        {
            srvc.AddCar("A", "B", CarCategory.Economy, 100);
            srvc.AddCar("C", "D", CarCategory.Economy, 100);

            var allCars = _carRepo.GetAll();
            allCars[1].ChangeStatus(CarStatus.InMaintenance);
            var result = srvc.GetAvailableCars();
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Status, Is.EqualTo(CarStatus.Available));
        }

        [Test]
        public void GetAvailableCarsForPeriod_ShouldExcludeOverlappingRentals()
        {
            
            srvc.AddCar("A", "B", CarCategory.Economy, 100);
            var car = _carRepo.GetAll().First();
            _rentalRepo.Save(new Rentals(1, 1, new DateTime(2026, 1, 10),new DateTime(2026, 1, 20)));           
            DateTime start = new DateTime(2026, 1, 15);
            DateTime end = new DateTime(2026, 1, 25);
            var result = srvc.GetAvailableCarsForPeriod(start, end);
            Assert.That(result.Count, Is.EqualTo(0));
        }
    }
}
