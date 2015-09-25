using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundle_Library
{
    public interface IBundleable
    {
        void packObject(string key,Bundle B);
        IBundleable unpackOoject(string key,Bundle B);
    }
}
