using System.Collections.Generic;
using System.Linq;
using GraphQLDemo.Entities;
using GraphQLDemo.Repositories.Interfaces;

namespace GraphQLDemo.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private static readonly List<Customer> _customers = new List<Customer>
        {
            new Customer
            {
                Id = 1,
                Name = "Oleg Vinokurov",
                Address = "726 N Maple Dr.",
                City = "Beverly Hills",
                State = "CA",
                Zipcode = "90210",
                Portfolios = new List<Portfolio>
                {
                    new Portfolio
                    {
                        Id = 1, Name = "Retirement", Value = 234.45,
                        Stocks = new List<Stock>
                        {
                            new Stock { Id = 1, LastPrice = 22.5, Name = "MSFT"},
                            new Stock { Id = 2, LastPrice = 122.5, Name = "AMZN"},
                            new Stock { Id = 3, LastPrice = 1122.5, Name = "FB"},
                            new Stock { Id = 4, LastPrice = 222.5, Name = "TWITTER"}
                        }
                    },
                    new Portfolio { Id = 2, Name = "Investment", Value = 2234.45},
                }
            },
            new Customer
            {
                Id = 2,
                Name = "Oleg2 Vinokurov2",
                Address = "726 N Maple Dr.",
                City = "Beverly Hills",
                State = "CA",
                Zipcode = "90210"
            },
            new Customer
            {
                Id = 3,
                Name = "Oleg3 Vinokurov3",
                Address = "726 N Maple Dr.",
                City = "Beverly Hills",
                State = "CA",
                Zipcode = "90210"
            },
        };

        public List<Customer> GetAll() => _customers;

        public Customer GetCustomerById(int id) => _customers.FirstOrDefault(c => c.Id == id);
        public Customer AddCustomer(Customer customer)
        {
            _customers.Add(customer);
             return customer;
        }
    }
}