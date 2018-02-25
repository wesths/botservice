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
        public Messages CallService(JObject value)
        {
            dynamic request = JsonConvert.DeserializeObject(value.ToString());
            var messageList = new List<Message>();
            var message = new Message();
            var action = request.result.action;

            if (action.Equals("getbalance"))
            {
                message.speech = "Get Balance method was executed!";
                message.type = 0;
                messageList.Add(message);
            }
            else
            {
                message.speech = "This call failed a bit" + "action: " + action.ToString();
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
