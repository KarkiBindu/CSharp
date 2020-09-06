using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Interface
{
    interface ICommon
    {
        void PrintInfo();// no access modifier required  
        int ID { get; set; }      // no access modifier required  

    }

    interface IStudent
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void PrintInfo();// no access modifier required  
    }
    public class School:ICommon
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        private int _id;
        public int ID { set { this._id = value; } get { return this._id; } }

        public void PrintInfo()
        {
            Console.WriteLine("Student id: {2} full name: {0} {1} faculty: {3}", FirstName, LastName, ID, Faculty);
        }
       
    }

    public class Student: School, ICommon, IStudent
    {
        public int Grade { get; set; }

        void IStudent.PrintInfo()//explicit Interface Implementation
        {
            Console.WriteLine("Student id: {2} full name: {0} {1} Grade: {4}", FirstName, LastName, ID, Grade);
        }

    }

}
