using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSys.Application.Interfaces;
using CarRentalSys.Domain.Entities;

namespace ServiceTest
{
    public class FakeRentalRepository : IRentalRepository
    {
        private readonly List<Rentals> _rentals = new();

        public IReadOnlyList<Rentals> GetAll()
        {
            return _rentals;
        }

        public Rentals GetById(int id)
        {
            var rental = _rentals.FirstOrDefault(x => x.Id == id);
            if (rental == null)
                throw new Exception("Rental not found");

            return rental;
        }

        public void Save(Rentals newRental)
        {
            if (newRental == null)
                throw new Exception("Rental cant be null");

            _rentals.Add(newRental);
        }
    }
}
