using H2_Assignment_Help_Jakob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(Message message);
        void SendMessageToAll(string[] to, Message message);
    }
}
