using System;
using System.Collections.Generic;
using System.Text;

namespace practice.MultiThreading
{
    class MultiThreads
    {
        public delegate void SumofNumbersCallBack(int sumofNumbers);
        public static void PrintNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbersUptoTarget(object target)
        {
            for (int i = 0; i < (int)target; i++)
            {
                Console.WriteLine(i);
            }
        }

        public class Numbers
        {
            int _target;
            public Numbers(int val)
            {
                this._target = val;
            }

            public void PrintNumbersUptoTarget()
            {
                for (int i = 0; i < _target; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public class SumofNumbers
        {
            SumofNumbersCallBack _sumofNumbersCallBack;
            int _target;
            public SumofNumbers(int val, SumofNumbersCallBack sumofNumbersCallBack)
            {
                this._target = val;
                this._sumofNumbersCallBack = sumofNumbersCallBack;
            }

            public void PrintSumUptoTarget()
            {
                int sum = 0;
                for (int i = 0; i < _target; i++)
                {
                    sum += i;
                }
                if(_sumofNumbersCallBack != null)
                {
                    _sumofNumbersCallBack(sum);
                }
            }

        }

    }
}
