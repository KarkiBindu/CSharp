using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace practice.Deadlocks
{
    class Deadlock
    {
        public class Account
        {
            double _balance; int _id;
            public Account(int id, double balance)
            {
                this._id = id; this._balance = balance;
            }

            public int ID
            {
                get { return _id; }
            }

            public void Withdraw(double amount)
            {
                _balance -= amount;
            }

            public void Deposit(double amount)
            {
                _balance += amount;
            }
        }

        public class AccountManager
        {
            Account _fromAccont; Account _toAccount; double _amountTransfer;
            public AccountManager(Account fromAccont, Account toAccount, double amountTransfer)
            {
                this._amountTransfer = amountTransfer;
                this._fromAccont = fromAccont;
                this._toAccount = toAccount;
            }

            public void Transfer()
            {
                #region code that causes deadlock
                //Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + _fromAccont.ID);
                //lock (_fromAccont)
                //{
                //    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + _fromAccont.ID);
                //    Console.WriteLine(Thread.CurrentThread.Name + " suspending for 1 sec ");
                //    Thread.Sleep(1000);
                //    Console.WriteLine(Thread.CurrentThread.Name + " awake and trying to acquire lock on " + _toAccount.ID);
                //    lock (_toAccount)
                //    {
                //        _fromAccont.Withdraw(_amountTransfer);
                //        _toAccount.Deposit(_amountTransfer);
                //    }
                //}
                #endregion

                #region Resolving deadlock

                #region Acquiring locks in specific order
                object lock1, lock2;
                if (_fromAccont.ID < _toAccount.ID)
                {
                    lock1 = _fromAccont; lock2 = _toAccount;
                }
                else
                {
                    lock1 = _toAccount; lock2 = _fromAccont;
                }
                Console.WriteLine(Thread.CurrentThread.Name + " trying to acquire lock on " + ((Account)lock1).ID);
                lock (lock1)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)lock1).ID);
                    Console.WriteLine(Thread.CurrentThread.Name + " suspending for 1 sec ");
                    Thread.Sleep(1000);
                    Console.WriteLine(Thread.CurrentThread.Name + " awake and trying to acquire lock on " + ((Account)lock2).ID);
                    lock (lock2)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name + " acquired lock on " + ((Account)lock2).ID);
                        _fromAccont.Withdraw(_amountTransfer);
                        _toAccount.Deposit(_amountTransfer);
                    }
                }
                #endregion

                #endregion
            }
        }

    }
}
