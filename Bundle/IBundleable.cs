using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundle_Library
{
    /// <summary>
    /// This interface allows objects to be packed in bundles. 
    /// Any object you want to pack in a bundle must implement this interface
    /// </summary>
    public interface IBundleable
    {
        /// <summary>
        /// Pack this object into a bundle
        /// </summary>
        /// <param name="key">the key that it will be stored with in the bundle</param>
        /// <param name="B"> The bundle to pack it in</param>
        void packObject(string key,Bundle B);
        /// <summary>
        /// Unpack this object from the bundle
        /// </summary>
        /// <param name="key">the key that it was stored with in the bundle</param>
        /// <param name="B">The bundle that it is packed in</param>
        /// <returns> the unpacked object from the bundle</returns>
        IBundleable unpackOoject(string key,Bundle B);
    }
}
