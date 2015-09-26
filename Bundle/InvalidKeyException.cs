using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundle_Library
{
    /// <summary>
    /// This class represents an exception which is thrown when the key was not found within the bundle
    /// </summary>
    public class InvalidKeyException : InvalidBundleException
    {
        /// <summary>
        /// The passed key
        /// </summary>
        private string key = "";

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        /// <summary>
        /// Standard Constructor
        /// </summary>
        public InvalidKeyException() : base()
        {

        }

        /// <summary>
        /// Contructor which takes a message 
        /// </summary>
        /// <param name="Message">The message to display when the exception is thrown</param>
        public InvalidKeyException(string key) : base()
        {
            this.key = key;
        }

        /// <summary>
        /// The default message displayed when the exception is thrown. 
        /// This message is displayed if no message was passed in the constructor
        /// </summary>
        public override string Message
        {
            get
            {
                return "The key " + this.key + " was not present in the bundle, make sure you have entered the correct key and try again";
            }
        }
    }
}
