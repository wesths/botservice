using System;
using System.Collections.Generic;
using System.Text;

namespace BotService.Domain.Repo
{
    public interface ICustomerAccountRepo
    {
        AccountDetails GetCustomerAccountDetails(int personNo);
    }
}
