using System;
using System.Collections.Generic;
using System.Text;

namespace BotService.Interface.Contracts
{
    public interface IAccountService
    {
        decimal GetCustomerAccountBalance(int personNo);
    }
}
