using BotService.Domain;
using BotService.Domain.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotService.Infrastructure.Repositories
{
    public class FakeCustomerRepo : ICustomerRepo
    {
        List<Customer> customerList = new List<Customer>();

        Customer cust1 = new Customer()
        {
            PersonNo = 118611783,
            FirstName = "Shane",
            LastName = "Van Der Westhuizen",
            IDNumber = "8401255250088"
        };

        Customer cust2 = new Customer()
        {
            PersonNo = 999999999,
            FirstName = "Joe",
            LastName = "Smith",
            IDNumber = "8811175250088"
        };
        
        public FakeCustomerRepo()
        {
            customerList.Add(cust1);
            customerList.Add(cust2);
        }

        public Customer GetCustomer(int PersonNo)
        {
            return customerList.SingleOrDefault(x => x.PersonNo == PersonNo);
        }

        public Customer GetCustomer(string IDNumber)
        {
            return customerList.SingleOrDefault(x => x.IDNumber.Equals(IDNumber));
        }

        public Customer GetCustomer(string FirstName, string LastName)
        {
            return customerList.SingleOrDefault(x => x.LastName.Contains(LastName) && x.FirstName.Contains(FirstName));
        }
    }
}
