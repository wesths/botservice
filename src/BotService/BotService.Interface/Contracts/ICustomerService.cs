using BotService.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotService.Interface.Contracts
{
    public interface ICustomerService
    {
        Customer GetCustomer(int PersonNo);
    }
}
