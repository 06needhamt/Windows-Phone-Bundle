using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bundle_Library;

namespace BundleTestApp
{
    public class TestBundleable : IBundleable
    {
        private string testString = "Hello";

        public string TestString
        {
            get { return testString; }
            set { testString = value; }
        }
        private int testInt = 12345;

        public int TestInt
        {
            get { return testInt; }
            set { testInt = value; }
        }

        public TestBundleable()
        {
        }

        void IBundleable.packObject(string key, Bundle B)
        {
            IBundleable temp = this;
            B.storePackedObject(key, temp);
        }

        IBundleable IBundleable.unpackOoject(string key, Bundle B)
        {
            IBundleable temp = B.getPackedObject(key);
            return temp;
        }
    }
}
