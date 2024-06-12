using H2_Assignment_Help_Jakob.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Models
{
    /// <summary>
    /// Provides functionality to convert a message to HTML format.
    /// </summary>
    public class ConvertToHTML : IMessageConverter
    {
        /// <summary>
        /// Converts the specified message to an HTML formatted string.
        /// </summary>
        /// <param name="message">The message to convert.</param>
        /// <returns>An HTML formatted string containing the original message.</returns>
        public string Convert(string message) => message;
    }
}
