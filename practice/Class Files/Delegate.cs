using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Delegates
{
    public delegate bool IsPromotable(Employee emp);
    public struct Employee:IComparable<Employee>
    {
        public int ID { get; set; }
        public double Salary { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }

        #region soting of complex types list
        //sorting employee using salary
        public int CompareTo(Employee emp)
        {
            return this.Name.CompareTo(emp.Name);
            //if salary was an integer we can simply do
            // return this.Salary.CompareTo(emp.Salary); // as integer implementation is already done
        }
        #endregion

        public static bool ExperiencePromote(Employee emp)
        {
            Console.WriteLine("###Experience promote check###");
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
                return false;
           
        }

        public static bool SalaryPromote(Employee emp)
        {
            Console.WriteLine("###Salary promote check###");
            if (emp.Salary <= 5000)
            {
                return true;
            }
            else
                return false;
        }
    }
    class Delegate
    { 
        public static void PromoteEmployee(List<Employee> empList, IsPromotable IsEligibleToPromote)
        {
            foreach(Employee emp in empList)
            {
                if (IsEligibleToPromote(emp))
                {
                    Console.WriteLine(emp.Name + "promoted");
                }
            }
        }
    }
}
