using H2_Assignment_Help_Jakob.Interfaces;
using H2_Assignment_Help_Jakob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Controllers.MessageSenders
{
    public class VMessageSender : IMessageSender
    {
        public void SendMessage(Message message)
        {
            //her implementeres alt koden til at sende via VMessage
        }

        public void SendMessageToAll(string[] to, Message message)
        {
            //her implementeres alt koden til at sende via VMessage
        }
    }
}
