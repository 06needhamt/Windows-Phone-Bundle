using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundle_Library
{
    public class Bundle : IBundleable
    {
        public static readonly Bundle EMPTY = new Bundle("");
        private readonly string identifier;
        private List<Tuple<string, string>> strings = new List<Tuple<string, string>>();
        private List<Tuple<string, int>> ints = new List<Tuple<string, int>>();
        private List<Tuple<string, long>> longs = new List<Tuple<string, long>>();
        private List<Tuple<string, float>> floats = new List<Tuple<string, float>>();
        private List<Tuple<string, double>> doubles = new List<Tuple<string, double>>();
        private List<Tuple<string, bool>> bools = new List<Tuple<string, bool>>();
        private List<Tuple<string, char>> chars = new List<Tuple<string, char>>();
        private List<Tuple<string, IBundleable>> bundleableObjects = new List<Tuple<string, IBundleable>>();
        private List<Tuple<string, string[]>> stringArrays = new List<Tuple<string, string[]>>();
        private List<Tuple<string, int[]>> intArrays = new List<Tuple<string, int[]>>();
        private List<Tuple<string, long[]>> longArrays = new List<Tuple<string, long[]>>();
        private List<Tuple<string, float[]>> floatArrays = new List<Tuple<string, float[]>>();
        private List<Tuple<string, double[]>> doubleArrays = new List<Tuple<string, double[]>>();
        private List<Tuple<string, bool[]>> boolArrays = new List<Tuple<string, bool[]>>();
        private List<Tuple<string, char[]>> charArrays = new List<Tuple<string, char[]>>();
        private List<Tuple<string, IBundleable[]>> bundleableObjectArrays = new List<Tuple<string, IBundleable[]>>();

        public Bundle(string from)
        {
            this.identifier = from;
        }
        public void packObject(string key, Bundle B)
        {
            IBundleable temp = this;
            B.putBundleable(key, temp);
        }
        public IBundleable unpackOoject(string key, Bundle B)
        {
            IBundleable temp = null;
            temp = B.getBundleable(key);
            return temp;
        }

        private void putBundleable(string key, IBundleable obj)
        {
            bundleableObjects.Add(new Tuple<string, IBundleable>(key, obj));
        }

        private IBundleable getBundleable(string key)
        {
            for (int i = 0; i < bundleableObjects.Count; i++)
            {
                if (bundleableObjects[i].Item1.Equals(key))
                {
                    return bundleableObjects[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }
        public void storePackedObject(string key, IBundleable obj)
        {
            putBundleable(key, obj);
        }

        public IBundleable getPackedObject(string key)
        {
            IBundleable temp = getBundleable(key);
            return temp;
        }

        public String getString(string key)
        {
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i].Item1.Equals(key))
                {
                    return strings[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }

        public int getInt(string key)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i].Item1.Equals(key))
                {
                    return ints[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }

        public long getLong(string key)
        {
            for (int i = 0; i < longs.Count; i++)
            {
                if (longs[i].Item1.Equals(key))
                {
                    return longs[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }

        public float getFloat(string key)
        {
            for (int i = 0; i < floats.Count; i++)
            {
                if (floats[i].Item1.Equals(key))
                {
                    return floats[i].Item2;
                }
            }
            throw new InvalidKeyException(key);
        }

        public double getDouble(string key)
        {
            for (int i = 0; i < doubles.Count; i++)
            {
                if (doubles[i].Item1.Equals(key))
                {
                    return doubles[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }

        public bool getBool(string key)
        {
            for (int i = 0; i < bools.Count; i++)
            {
                if (bools[i].Item1.Equals(key))
                {
                    return bools[i].Item2;
                }
            }
            throw new InvalidKeyException(key);
        }

        public char getChar(string key)
        {
            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i].Item1.Equals(key))
                {
                    return chars[i].Item2;
                }
            }
            throw new InvalidKeyException(key);
        }
        public String[] getStringArray(string key)
        {
            for (int i = 0; i < stringArrays.Count; i++)
            {
                if (stringArrays[i].Item1.Equals(key))
                {
                    return stringArrays[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }

        public int[] getIntArray(string key)
        {
            for (int i = 0; i < intArrays.Count; i++)
            {
                if (intArrays[i].Item1.Equals(key))
                {
                    return intArrays[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }

        public long[] getLongArray(string key)
        {
            for (int i = 0; i < longArrays.Count; i++)
            {
                if (longArrays[i].Item1.Equals(key))
                {
                    return longArrays[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }

        public float[] getFloatArray(string key)
        {
            for (int i = 0; i < floatArrays.Count; i++)
            {
                if (floatArrays[i].Item1.Equals(key))
                {
                    return floatArrays[i].Item2;
                }
            }
            throw new InvalidKeyException(key);
        }

        public double[] getDoubleArray(string key)
        {
            for (int i = 0; i < doubleArrays.Count; i++)
            {
                if (doubleArrays[i].Item1.Equals(key))
                {
                    return doubleArrays[i].Item2;
                }
            }
            throw new InvalidKeyException(key);

        }

        public bool[] getBoolArrays(string key)
        {
            for (int i = 0; i < boolArrays.Count; i++)
            {
                if (boolArrays[i].Item1.Equals(key))
                {
                    return boolArrays[i].Item2;
                }
            }
            throw new InvalidKeyException(key);
        }

        public char[] getCharArrays(string key)
        {
            for (int i = 0; i < charArrays.Count; i++)
            {
                if (charArrays[i].Item1.Equals(key))
                {
                    return charArrays[i].Item2;
                }
            }
            throw new InvalidKeyException(key);
        }

        public void putString(string key, string value)
        {
            strings.Add(new Tuple<string,string>(key,value));
        }

        public void putInt(string key, int value)
        {
            ints.Add(new Tuple<string, int>(key, value));
        }

        public void putLong(string key, long value)
        {
            longs.Add(new Tuple<string, long>(key, value));
        }

        public void putFloat(string key, float value)
        {
            floats.Add(new Tuple<string, float>(key, value));
        }

        public void putDouble(string key, double value)
        {
            doubles.Add(new Tuple<string, double>(key, value));
        }

        public void putBool(string key, bool value)
        {
            bools.Add(new Tuple<string, bool>(key, value));
        }

        public void putChar(string key, char value)
        {
            chars.Add(new Tuple<string, char>(key, value));
        }

        public void putStringArray(string key, string[] value)
        {
            stringArrays.Add(new Tuple<string, string[]>(key, value));
        }

        public void putIntArray(string key, int[] value)
        {
            intArrays.Add(new Tuple<string, int[]>(key, value));
        }

        public void putLongArray(string key, long[] value)
        {
            longArrays.Add(new Tuple<string, long[]>(key, value));
        }

        public void putFloatArray(string key, float[] value)
        {
            floatArrays.Add(new Tuple<string, float[]>(key, value));
        }

        public void putDoubleArray(string key, double[] value)
        {
            doubleArrays.Add(new Tuple<string, double[]>(key, value));
        }

        public void putBoolArray(string key, bool[] value)
        {
            boolArrays.Add(new Tuple<string, bool[]>(key, value));
        }

        public void putCharArray(string key, char[] value)
        {
            charArrays.Add(new Tuple<string, char[]>(key, value));
        }

        public static Bundle operator +(Bundle lhs, Bundle rhs)
        {
            if (lhs == null || rhs == null)
            {
                return null;
            }
            if (lhs == Bundle.EMPTY)
            {
                return rhs;
            }
            else if (rhs == Bundle.EMPTY)
            {
                return lhs;
            }

            lhs.strings.AddRange(rhs.strings);
            lhs.ints.AddRange(rhs.ints);
            lhs.longs.AddRange(rhs.longs);
            lhs.floats.AddRange(rhs.floats);
            lhs.doubles.AddRange(rhs.doubles);
            lhs.bools.AddRange(rhs.bools);
            lhs.chars.AddRange(rhs.chars);
            lhs.bundleableObjects.AddRange(rhs.bundleableObjects);
            lhs.stringArrays.AddRange(rhs.stringArrays);
            lhs.intArrays.AddRange(rhs.intArrays);
            lhs.longArrays.AddRange(rhs.longArrays);
            lhs.floatArrays.AddRange(rhs.floatArrays);
            lhs.doubleArrays.AddRange(rhs.doubleArrays);
            lhs.boolArrays.AddRange(rhs.boolArrays);
            lhs.charArrays.AddRange(rhs.charArrays);
            lhs.bundleableObjectArrays.AddRange(rhs.bundleableObjectArrays);
            return lhs;

        }
        public string getIdentifier()
        {
            return this.identifier;
        }
    }
}

