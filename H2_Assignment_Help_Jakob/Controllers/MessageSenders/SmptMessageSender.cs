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
    /// Represents a message sender that uses the SMTP protocol.
    /// </summary>
    public class SmtpMessageSender : IMessageSender
    {
        /// <summary>
        /// Sends a message using the SMTP protocol.
        /// </summary>
        /// <param name="message">The message to send.</param>
        public void SendMessage(Message message)
        {
            // Here, the code to send the message via SMTP would be implemented
        }

        /// <summary>
        /// Sends a message to multiple recipients using the SMTP protocol.
        /// </summary>
        /// <param name="to">An array of recipient addresses.</param>
        /// <param name="message">The message to send.</param>
        public void SendMessageToAll(string[] to, Message message)
        {
            // Here, the code to send the message to multiple recipients via SMTP would be implemented
        }
    }

}
