using H2_Assignment_Help_Jakob.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Models
{
    public class ConvertToHTML : IMessageConverter
    {
        public string Convert(string message) => $"<html><body>{message}</body></html>";
    }
}
