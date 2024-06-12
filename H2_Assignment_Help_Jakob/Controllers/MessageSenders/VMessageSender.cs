using H2_Assignment_Help_Jakob.Interfaces;
using H2_Assignment_Help_Jakob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Controllers.MessageSenders
{
    /// <summary>
    /// Represents a message sender that uses VMessage.
    /// </summary>
    public class VMessageSender : IMessageSender
    {
        /// <summary>
        /// Sends a message using VMessage.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void SendMessage(Message message)
        {
            // Here, the code to send the message via VMessage would be implemented
        }

        /// <summary>
        /// Sends a message to multiple recipients using VMessage.
        /// </summary>
        /// <param name="to">An array of recipient addresses.</param>
        /// <param name="message">The message to send.</param>
        public void SendMessageToAll(string[] to, Message message)
        {
            // Here, the code to send the message to multiple recipients via VMessage would be implemented
        }
    }

}
