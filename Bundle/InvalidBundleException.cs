using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundle_Library
{
    public class InvalidBundleException : Exception
    {
        public InvalidBundleException()
            : base()
        {

        }
        public InvalidBundleException(string Message)
            : base(Message)
        {
        }
        public override string Message
        {
            get
            {
                return "Bundle is invalid";
            }
        }
    }
}
