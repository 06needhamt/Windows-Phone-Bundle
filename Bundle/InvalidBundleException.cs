using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundle_Library
{
    /// <summary>
    /// This class represents an exception which is thrown when an invalid bundle has been used for a pack unpack operation
    /// </summary>
    public class InvalidBundleException : Exception
    {
        /// <summary>
        /// Standard Constructor
        /// </summary>
        public InvalidBundleException()
            : base()
        {

        }
        /// <summary>
        /// Contructor which takes a message 
        /// </summary>
        /// <param name="Message">The message to display when the exception is thrown</param>
        public InvalidBundleException(string Message)
            : base(Message)
        {
        }
        /// <summary>
        /// The default message displayed when the exception is thrown. 
        /// This message is displayed if no message was passed in the constructor
        /// </summary>
        public override string Message
        {
            get
            {
                return "Bundle is invalid";
            }
        }
    }
}
