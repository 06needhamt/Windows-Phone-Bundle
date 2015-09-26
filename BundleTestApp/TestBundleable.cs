using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bundle_Library;

namespace BundleTestApp
{
    /// <summary>
    /// This class represents a simple object that can be packed and unpacked from a bundle.
    /// </summary>
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
        /// <summary>
        /// Contructor for this object
        /// </summary>
        public TestBundleable()
        {
        }
        /// <summary>
        /// Pack this object into a bundle
        /// </summary>
        /// <param name="key">the key that it will be stored with in the bundle</param>
        /// <param name="B"> The bundle to pack it in</param>
        void IBundleable.packObject(string key, Bundle B)
        {
            IBundleable temp = this;
            B.storePackedObject(key, temp);
        }
        /// <summary>
        /// Unpack this object from the bundle
        /// </summary>
        /// <param name="key">the key that it was stored with in the bundle</param>
        /// <param name="B">The bundle that it is packed in</param>
        /// <returns> the unpacked object from the bundle</returns>
        IBundleable IBundleable.unpackOoject(string key, Bundle B)
        {
            IBundleable temp = B.getPackedObject(key);
            return temp;
        }
    }
}
