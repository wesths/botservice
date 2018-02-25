using BotService.Interface.ServiceModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotService.Interface.Contracts
{
    public interface IBotService
    {
        Messages CallService(JObject value);
    }
}
