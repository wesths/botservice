using BotService.Interface.Contracts;
using System;

namespace BotService.Service
{
    public class AccountService : IAccountService
    {
        public decimal GetCustomerAccountBalance(int personNo)
        {
            
            if (personNo == 118611783)
            {
                return 1000.00M;
            }
            else if (personNo == 999999999)
            { 
                return 9999.00M;

            }
            else
            {
                return 0.00M;
            }
        }
    }
}
