using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundle_Library
{
    public class InvalidKeyException : InvalidBundleException
    {
        private string key = "";

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public InvalidKeyException() : base()
        {

        }

        public InvalidKeyException(string key) : base()
        {
            this.key = key;
        }

        public override string Message
        {
            get
            {
                return "The key " + this.key + " was not present in the bundle, make sure you have entered the correct key and try again";
            }
        }
    }
}
