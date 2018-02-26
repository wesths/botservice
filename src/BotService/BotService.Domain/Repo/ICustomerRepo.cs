using System;
using System.Collections.Generic;
using System.Text;

namespace BotService.Domain.Repo
{
    public interface ICustomerRepo
    {
        Customer GetCustomer(int PersonNo);
        Customer GetCustomer(string IDNumber);
        Customer GetCustomer(string FirstName, string LastName);
    }
}
