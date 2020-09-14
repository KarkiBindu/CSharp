using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using veh = practice.Automobiles.Vehicle;//aliases
using area = practice.Inheritance.Area;
using practice.Inheritance;
using practice.Automobiles;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace practice
{
    class Program // class with private acces modifier
    {
        static void Main(string[] args) // method with private access modifier
        {
            try
            {
                int a, b;
                Console.WriteLine("Please Enter an integer number :");
                int.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Please Enter another integer number :");
                int.TryParse(Console.ReadLine(), out b);

                #region print using Place holders
                Console.WriteLine("Entered values printed using place holders are : {0} {1} \n", a, b);
                #endregion

                #region escape sequence
                Console.WriteLine("Usage of escape sequence: \"string\" \n");
                #endregion

                #region verbatim literal
                string abc = @"F:\Black Butler";
                #endregion

                #region ternary Operator
                int j = (a == 10) ? 10 : 40;
                Console.WriteLine("Output using ternary operator {0} \n", j);
                #endregion

                #region null coalescing operator
                int? i = null;
                int k = i ?? 50;
                Console.WriteLine("null coalescing operator (k = i ?? 50): since i is null, k is {0}",k);

                string bc = null;
                string cd = bc ?? "ab";
                Console.WriteLine("null coalescing operator (cd = bc ?? \"ab\"): since cd is null, cd is {0} \n", cd);
                #endregion

                #region implicit data conversion
                int val = 50;
                float sth = val;
                // int b = sth; not possible
                #endregion

                #region explicit data conversion
                int d = (int)sth;
                d = Convert.ToInt16(sth);
                #endregion

                #region parse
                string num = "100";
                a = int.Parse(num);//when you are sure the value to be parsed will not return null
                #endregion

                #region try parse
                string[] nums = new string[4] { "ab", "12", "12c", "0" };
                foreach (string c in nums)
                {
                    int e;
                    int.TryParse(c, out e);
                    Console.WriteLine("Try parse conversion output {0}",e);
                }
                Console.WriteLine("");
                #endregion

                #region Object Instantiation of a class/ polymorphism
                Circle circle = new Circle();
                circle.Radius = 5;
                double circleArea = circle.GetArea();// getting value as returned by method
                circle.PrintArea();
                circle.MethodHididng();// this hides the base method

                #region polymorphism
                area square = new Square();//area is base class and sqare is derived class, polymorphism example
                #endregion
                square.Length = 5;
                square.GetArea();//it is not madatory to catch returned value
                square.PrintArea();
                square.MethodHididng();// casting to base type to call base method
                square.CallPartialMethod();
                Console.WriteLine("");
                #endregion

                #region enums, struct, aliases, static members
                veh vehicle = new veh();//veh is the aliase created above
                object[] info = new object[2];
                info[0] = (int)veh.NumberofVehicleWheels.Four;//use of enum
                string category = string.Empty;
                vehicle.SetInfo((int)info[0], out category);//calling non-static memeber //casting object to int as argument
                info[1] = category;
                Vehicle.PrintInfo(info);//calling satic member directly from class
                Console.WriteLine("");
                #endregion

                #region Interface
                Console.WriteLine("Interface----------------------------------------------------");
                Interface.Student student = new Interface.Student();
                student.ID = 15;
                student.FirstName = "Samantha";
                student.LastName = "Sal";
                student.Grade = 8;
                student.PrintInfo();
                Console.WriteLine("");
                #endregion

                #region delegates            
                List<Delegates.Employee> employees = new List<Delegates.Employee>();
                employees.Add(new Delegates.Employee { ID = 15, Name = "Sam", Salary = 30000, Experience = 2 });
                employees.Add(new Delegates.Employee { ID = 101, Name = "Brut", Salary = 50000, Experience = 3 });
                employees.Add(new Delegates.Employee { ID = 95, Name = "Berth", Salary = 5000, Experience = 1 });
                employees.Add(new Delegates.Employee { ID = 35, Name = "Bently", Salary = 4000, Experience = 1 });
                employees.Add(new Delegates.Employee { ID = 11, Name = "Joseph", Salary = 70000, Experience = 4 });
                employees.Add(new Delegates.Employee { ID = 54, Name = "Samantha", Salary = 90000, Experience = 6 });

                Console.WriteLine("Delegates: Experience promotion ----------------------------------------------------");
                Delegates.IsPromotable isExperiencePromotable = new Delegates.IsPromotable(Delegates.Employee.ExperiencePromote);
                Delegates.Delegate.PromoteEmployee(employees, isExperiencePromotable);

                Console.WriteLine("Delegates: Salary promotion ----------------------------------------------------");
                Delegates.IsPromotable isSalaryPromotable = new Delegates.IsPromotable(Delegates.Employee.SalaryPromote);
                Delegates.Delegate.PromoteEmployee(employees, isSalaryPromotable);

                Console.WriteLine("Delegates: multicast delegate register, checks both salary and experience----------------------------------");
                Delegates.IsPromotable multiCastDelegate = isSalaryPromotable + isExperiencePromotable;// returns value of second type only
                Delegates.Delegate.PromoteEmployee(employees, multiCastDelegate);

                Console.WriteLine("Delegates: multicast delegate unregister, checks only salary----------------------------------------------------");
                Delegates.IsPromotable multiCastDelegateUnRegis = multiCastDelegate - isExperiencePromotable;// returns value of second type only
                Delegates.Delegate.PromoteEmployee(employees, multiCastDelegateUnRegis);
                Console.WriteLine("");
                #endregion

                #region Access Modifiers
                Console.WriteLine("AccessModifiers ----------------------------------------------------");
                AccessModifiers.AccessModifier.Example example = new AccessModifiers.AccessModifier.Example();
                //example.NoAccess();//cannot access
                example.EverWhereAccess();
                example.AssemblyDerivedClassAccess();
                example.AssemblyAccess();
                //example.DerivedClassAccess();//can be accessed from derived class only
                Console.WriteLine("");
                #endregion

                #region Generics
                Console.WriteLine("Generics ----------------------------------------------------");
                Console.WriteLine("Generic int check with AreEqual function, Result : {0}",Generics.Generic.AreEqual<int>(10, 20));
                Console.WriteLine("Generic string check with AreEqual function, Result : {0} \n", Generics.Generic.AreEqual<string>("ab", "ab"));
                
                #endregion

                #region Indexers
                Console.WriteLine("Indexers ----------------------------------------------------");
                Indexers.Indexer.Company company = new Indexers.Indexer.Company();               
                Console.WriteLine("Employee of id 15 is {0}", company[15]);
                Console.WriteLine("Gender of employee of id 15 is {0}", company[company[15]]);
                company[15] = "Harry";
                Console.WriteLine("Name of Employee of id 15 after changing name is {0}", company[15]);
                company[company[15]] = "Female";
                Console.WriteLine("Name of Employee of id 15 after changing name is {0} \n", company[company[15]]);
                #endregion

                #region Optional parameters
                Console.WriteLine("sum of optional parameter using params Array :");
                Console.WriteLine("providing only two numbers {0}",Parameters.OptParameters.AddNumbers(12, 11));
                Console.WriteLine("providing only four numbers {0} \n", Parameters.OptParameters.AddNumbers(12, 11, 13, 14));
                Console.WriteLine("sum of optional parameter using Method overloading :");
                Console.WriteLine("providing only three numbers {0} \n", Parameters.OptParameters.AddNumbers(12, 11, new int[1] { 12}));
                Console.WriteLine("sum of optional parameter using default :");
                Console.WriteLine("providing only four numbers (two default 20 and 30) {0}", Parameters.OptParameters.AddNumbers(12, 11));
                Console.WriteLine("providing only four numbers (one default and changing one default value to 10) {0} \n", Parameters.OptParameters.AddNumbers(12, 11, c: 10));
                Console.WriteLine("sum of optional parameter using optional attribute :");
                Console.WriteLine("sum of two numbers providing only one value 12 {0} \n", Parameters.OptParameters.AddNumbers(12));
                #endregion

                #region Dictionary              
                Collections.Collection.Employess = employees.ToDictionary(emp => emp.ID, emp => emp);//list to dictionary conversion
                Delegates.Employee emp11;
                Collections.Collection.Employess.TryGetValue(11, out emp11);
                if(!string.IsNullOrEmpty(emp11.Name))
                {
                    Console.WriteLine("Employee with id 11 is found using TryGetValue");
                }
                else
                    Console.WriteLine("Employee with id 11 is not found using TryGetValue");
                Console.WriteLine("The total items in dictionary whose name starts with S is {0} \n", Collections.Collection.Employess.Count(employees => employees.Value.Name.StartsWith('S')));
                #endregion

                #region List
                List<Delegates.Employee> lowSalaryEmp = employees.FindAll(emp => emp.Salary <= 5000);
                Console.WriteLine("List FindAll example: employees with salary less than 5000 are :");
                foreach (Delegates.Employee empl in lowSalaryEmp)
                {
                    Console.WriteLine(empl.Name);
                }

                Console.WriteLine("Before sorting customer of complex type on the base of name using default class interface IComparable :");
                foreach (Delegates.Employee empl in employees)
                {
                    Console.WriteLine(empl.Name);
                }

                employees.Sort();
                #region using delegate to Sort
                // employees.Sort(delegate (Delegates.Employee x, Delegates.Employee y) { return x.Name.CompareTo(y.Name); });
                #endregion
                #region using lambda expression to sort
                //employees.Sort((x, y) => x.Name.CompareTo(y.Name));
                #endregion
                Console.WriteLine("After sorting customer of complex type :");
                foreach (Delegates.Employee empl in employees)
                {
                    Console.WriteLine(empl.Name);
                }

                Console.WriteLine("Before sorting customer of complex type on the base of salary using custom class interface IComparer :");
                foreach (Delegates.Employee empl in employees)
                {
                    Console.WriteLine(empl.Salary);
                }

                SortEmployeeBySalary SortEmpSal = new SortEmployeeBySalary();
                employees.Sort(SortEmpSal);

                Console.WriteLine("After sorting customer of complex type :");
                foreach (Delegates.Employee empl in employees)
                {
                    Console.WriteLine(empl.Salary);
                }

                Console.WriteLine("Result of check whether salary of all employee is greater than 5k using TrueForAll : {0}", employees.TrueForAll(x => x.Salary > 5000));

                ReadOnlyCollection<Delegates.Employee> readOnlyEmp = employees.AsReadOnly();

                Console.WriteLine("Capacity of employee list before trimming : {0}", employees.Capacity);
                employees.TrimExcess();
                Console.WriteLine("Capacity of employee list after trimming : {0} \n", employees.Capacity);

                #endregion

                #region Queue
                Queue<Delegates.Employee> empQueue = new Queue<Delegates.Employee>();
                empQueue.Enqueue(new Delegates.Employee { ID = 1, Name = "Yeti", Salary = 5000, Experience = 1 });
                empQueue.Enqueue(employees[0]);
                empQueue.Enqueue(Collections.Collection.Employess[11]);
                empQueue.Enqueue(new Delegates.Employee { ID = 5, Name = "Amla", Salary = 5000, Experience = 2 });
                Console.WriteLine("First Employee in queue before dequeue is : {0}", empQueue.Peek().Name);
                empQueue.Dequeue();
                Console.WriteLine("First Employee in queue after dequeue is : {0} \n", empQueue.Peek().Name);
                bool contains = empQueue.Contains(employees[0]);
                #endregion

                #region Stack
                Stack<Delegates.Employee> empStack = new Stack<Delegates.Employee>();
                empStack.Push(new Delegates.Employee { ID = 1, Name = "Yeti", Salary = 5000, Experience = 1 });
                empStack.Push(employees[0]);
                empStack.Push(Collections.Collection.Employess[11]);
                empStack.Push(new Delegates.Employee { ID = 5, Name = "Amla", Salary = 5000, Experience = 2 });
                Console.WriteLine("Top Employee in stack before pop is : {0}", empStack.Peek().Name);
                empStack.Pop();
                Console.WriteLine("Top Employee in stack after pop is : {0} \n", empStack.Peek().Name);
                bool containsEmp = empStack.Contains(employees[0]);
                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }

        #region Creating custom class to sort complex list
        public class SortEmployeeBySalary: IComparer<Delegates.Employee>
        {
            public int Compare(Delegates.Employee x, Delegates.Employee y)
            {
                #region Salary Comparison for sorting
                int a = 0;
                if (x.Salary > y.Salary)
                    a = 1;
                else if (x.Salary < y.Salary)
                    a = -1;
                else if (x.Salary == y.Salary)
                    a = 0;
                return a;
                #endregion
            }
        }
        #endregion
    }
}
