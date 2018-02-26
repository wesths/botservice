using BotService.Interface.Contracts;
using BotService.Interface.ServiceModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotService.Service
{
    public class BotService : IBotService
    {
        private IAccountService accountService;
        private ICustomerService customerService;
        public BotService(IAccountService _accountService, ICustomerService _customerService)
        {
            accountService = _accountService;
            customerService = _customerService;
        }
        public Messages CallService(JObject value)
        {
            dynamic request = JsonConvert.DeserializeObject(value.ToString());
            var messageList = new List<Message>();
            var message = new Message();
            var action = request.result.action;
            var parameters = request.result.parameters;

            if (action.ToString().Equals("getbalance"))
            {
                int personNo = (Int32)parameters.personno;
                var customer = customerService.GetCustomer(personNo);
                if (customer == null)
                {
                    message.speech = $"Sorry, I could not find account details for you on account number: {personNo}.";
                }
                else
                {
                    var bal = accountService.GetCustomerAccountBalance(personNo);
                    message.speech = $"Thank you {customer.FirstName} {customer.LastName}. Your balance outstanding is currently R{bal}.";
                }


                message.type = 0;
                messageList.Add(message);
            }
            else
            {
                message.speech = $"This call failed a bit, action: {action}";
                message.type = 0;
                messageList.Add(message);
            }

            return new Messages()
            {
                messages = messageList
            };
        }
    }
}
