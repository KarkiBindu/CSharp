using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Runtime.InteropServices;

namespace practice.Parameters
{
    class OptParameters
    {
        #region optional parameters using params array
        public static int AddNumbers(int a, int b, params object[] remNumbers)
        {
            int sum = a + b;
            if (remNumbers != null)
            {
                foreach (int i in remNumbers)
                {
                    sum += i;
                }
            }
            return sum;
        }
        #endregion

        #region optional parameters using Method overloading
        public static int AddNumbers(int a, int b, int[] remNumbers)
        {
            int sum = a + b;
            if (remNumbers != null)
            {
                foreach (int i in remNumbers)
                {
                    sum += i;
                }
            }
            return sum;
        }
        #endregion

        #region optional parameters using default value
        public static int AddNumbers(int a, int b, int c = 20, int d = 30 )
        {
            int sum = a + b + c + d;         
            return sum;
        }
        #endregion

        #region optional parameters using Optional attribute
        public static int AddNumbers(int a, [Optional]int b)
        {
            int sum = a + b;
            return sum;
        }
        #endregion
    }
}
