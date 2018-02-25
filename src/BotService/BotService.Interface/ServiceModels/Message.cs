using System;
using System.Collections.Generic;
using System.Text;

namespace BotService.Interface.ServiceModels
{
    public class Messages
    {
        public IEnumerable<Message> messages { get; set; }
    }

    public class Message
    {
        public string speech { get; set; }
        public int type { get; set; }
    }
}
