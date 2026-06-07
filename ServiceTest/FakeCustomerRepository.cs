using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSys.Application.Interfaces;
using CarRentalSys.Domain.Entities;

namespace ServiceTest
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = new();

        public IReadOnlyList<Customer> GetAll()
        {
            return _customers;
        }

        public Customer GetById(int id)
        {
            var customer = _customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
                throw new Exception("Customer not found");

            return customer;
        }

        public void Save(Customer newCustomer)
        {
            if (newCustomer == null)
                throw new Exception("Customer cant be null");

            _customers.Add(newCustomer);
        }
    }
}
