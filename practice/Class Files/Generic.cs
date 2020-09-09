using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Generics
{
    class Generic
    {

        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
