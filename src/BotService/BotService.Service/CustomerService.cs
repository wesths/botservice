using BotService.Domain;
using BotService.Domain.Repo;
using BotService.Interface.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotService.Service
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepo _customerRepo;
        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public Customer GetCustomer(int PersonNo)
        {
            return _customerRepo.GetCustomer(PersonNo);
        }
    }
}
