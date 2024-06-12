using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_Assignment_Help_Jakob.Interfaces
{
    /// <summary>
    /// Defines a method to convert a message to a different format.
    /// </summary>
    public interface IMessageConverter
    {
        /// <summary>
        /// Converts the specified message to a different format.
        /// </summary>
        /// <param name="message">The message to convert.</param>
        /// <returns>The converted message.</returns>
        string Convert(string message);
    }
}
