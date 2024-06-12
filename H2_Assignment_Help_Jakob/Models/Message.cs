using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Models
{
    /// <summary>
    /// Represents a general message that can be used for various types of messaging systems.
    /// </summary>
    public class Message
    {
        private string _to;
        private string _from;
        private string _body;
        private string _subject;
        private string _cc;

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="to">The recipient of the message.</param>
        /// <param name="from">The sender of the message.</param>
        /// <param name="body">The body content of the message.</param>
        /// <param name="subject">The subject of the message.</param>
        /// <param name="cc">The CC (carbon copy) recipients of the message.</param>
        public Message(string to, string from, string body, string subject, string cc)
        {
            _to = to;
            _from = from;
            _body = body;
            _subject = subject;
            _cc = cc;
        }

        /// <summary>
        /// Gets or sets the recipient of the message.
        /// </summary>
        public string To 
        { 
            get { return _to; }
            set { _to = value; }
        }

        /// <summary>
        /// Gets or sets the sender of the message.
        /// </summary>
        public string From 
        {
            get { return _from; }
            set { _from = value; }
        }

        /// <summary>
        /// Gets or sets the body content of the message.
        /// </summary>
        public string Body
        {
            get { return _body; }
            set { _body = value; } 
        }

        /// <summary>
        /// Gets or sets the subject of the message.
        /// </summary>
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        /// <summary>
        /// Gets or sets the carbon copy recipients of the message.
        /// </summary>
        public string Cc
        {
            get { return _cc; }
            set { _cc = value; }
        }

    }
}
