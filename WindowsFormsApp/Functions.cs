using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WindowsFormsApp
{
    class Functions
    {
        public static int Sum;
        public static int AddThreeMillion()
        {
            Sum = 0;
            for (int i = 1; i <= 3000000; i++)
            {
                Sum++;
            }
            Thread.Sleep(5000);
            return Sum;
        }
    }
}
