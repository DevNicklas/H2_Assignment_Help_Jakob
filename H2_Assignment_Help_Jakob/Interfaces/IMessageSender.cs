using H2_Assignment_Help_Jakob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Interfaces
{
    /// <summary>
    /// Defines methods for sending messages.
    /// </summary>
    public interface IMessageSender
    {
        /// <summary>
        /// Sends a message to a single recipient.
        /// </summary>
        /// <param name="message">The message to send.</param>
        void SendMessage(Message message);

        /// <summary>
        /// Sends a message to multiple recipients.
        /// </summary>
        /// <param name="to">An array of recipient addresses.</param>
        /// <param name="message">The message to send.</param>
        void SendMessageToAll(string[] to, Message message);
    }
}
