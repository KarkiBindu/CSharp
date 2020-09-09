using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practice.Indexers
{
    class Indexer
    {
        public class Employee
        {
            public int EmployeeId { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
        }

        public class Company
        {
            List<Employee> _employees = new List<Employee>();
            public Company()
            {
                _employees.Add(new Employee { EmployeeId = 15, Name = "Sam", Gender = "Male" });
                _employees.Add(new Employee { EmployeeId = 20, Name = "Sita", Gender = "Female" });
                _employees.Add(new Employee { EmployeeId = 45, Name = "Hari", Gender = "Male" });
                _employees.Add(new Employee { EmployeeId = 80, Name = "George", Gender = "Male" });
                _employees.Add(new Employee { EmployeeId = 22, Name = "Bertha", Gender = "Female" });
                _employees.Add(new Employee { EmployeeId = 11, Name = "Charlie", Gender = "Male" });
                _employees.Add(new Employee { EmployeeId = 9, Name = "Susan", Gender = "Female" });
                _employees.Add(new Employee { EmployeeId = 3, Name = "June", Gender = "Female" });
                _employees.Add(new Employee { EmployeeId = 8, Name = "Jude", Gender = "Male" });
            }

            #region creating Indexer
            public string this[int employeeId]
            {
                get
                {
                    return _employees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
                }
                set
                {
                    _employees.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
                }
            }
            #endregion

            #region creating overloading Indexer
            public string this[string name]
            {
                get
                {
                    return _employees.FirstOrDefault(emp => emp.Name == name).Gender;
                }
                set
                {
                    _employees.FirstOrDefault(emp => emp.Name == name).Gender = value;
                }
            }
            #endregion
        }
    }
}
