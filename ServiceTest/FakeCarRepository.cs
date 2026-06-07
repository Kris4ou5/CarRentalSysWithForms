using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSys.Application.Interfaces;
using CarRentalSys.Domain.Entities;

namespace ServiceTest
{
    public class FakeCarRepository : ICarRepository
    {
        private readonly List<Car> _cars = new();

        public IReadOnlyList<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            var car = _cars[id - 1];
            if (car == null)
                throw new Exception("Car not found");

            return car;
        }

        public void Save(Car newCar)
        {
            if (newCar == null)
                throw new Exception("Car cannot be null");

            _cars.Add(newCar);
        }
    }
}
