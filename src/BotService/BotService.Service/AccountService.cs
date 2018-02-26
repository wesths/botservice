using BotService.Domain.Repo;
using BotService.Interface.Contracts;
using System;

namespace BotService.Service
{
    public class AccountService : IAccountService
    {
        private ICustomerAccountRepo _customerAccountRepo;
        public AccountService(ICustomerAccountRepo customerAccountRepo)
        {
            _customerAccountRepo = customerAccountRepo;
        }
        public decimal GetCustomerAccountBalance(int personNo)
        {
            var details = _customerAccountRepo.GetCustomerAccountDetails(personNo);

            return details.BalanceOutstanding;
            
        }
    }
}
