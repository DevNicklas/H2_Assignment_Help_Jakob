using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Models
{
    public class Message
    {
        private string _to;
        private string _from;
        private string _body;
        private string _subject;
        private string _cc;

        public Message(string to, string from, string body, string subject, string cc)
        {
            _to = to;
            _from = from;
            _body = body;
            _subject = subject;
            _cc = cc;
        }

        public string To { get { return _to; } set { _to = value; } }

        public string From { get { return _from; } set { _from = value; } }

        public string Body { get { return _body; } set { _body = value; } }

        public string Subject { get { return _subject; } set { _subject = value; } }

        public string Cc { get { return _cc; } set { _cc = value; } }

    }
}
