using BotService.Domain;
using BotService.Domain.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BotService.Infrastructure.Repositories
{
    public class FakeCustomerAccountRepo : ICustomerAccountRepo
    {
        public AccountDetails GetCustomerAccountDetails(int personNo)
        {
            List<AccountDetails> customerList = new List<AccountDetails>();

            var cust1 = new AccountDetails()
            {
                PersonNo = 118611783,
                BalanceOutstanding = 5000.00M,
                NowDue = 120.00M,
                LastPaymentDate = new DateTime(2018, 1, 25),
                NextPaymentDate = new DateTime(2018, 3, 15)
            };

            var cust2 = new AccountDetails()
            {
                PersonNo = 999999999,
                BalanceOutstanding = 3000M,
                NowDue = 230.00M,
                LastPaymentDate = new DateTime(2018, 2, 1),
                NextPaymentDate = new DateTime(2018, 4, 15)
            };

            customerList.Add(cust1);
            customerList.Add(cust2);

            return customerList.SingleOrDefault(x => x.PersonNo == personNo);
        }
    }
}
