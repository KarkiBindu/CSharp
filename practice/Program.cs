using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using veh = practice.Automobiles.Vehicle;//aliases
using area = practice.Inheritance.Area;
using practice.Inheritance;
using practice.Automobiles;

namespace practice
{
    class Program // class with private acces modifier
    {
        static void Main(string[] args) // method with private access modifier
        {
            int a = 10;
            int b = 29;

            #region print using Place holders
            Console.WriteLine("{0} {1}", a, b);
            #endregion

            #region escape sequence
            Console.WriteLine("\"string\"");
            #endregion

            #region verbatim literal
            string abc = @"F:\Black Butler";
            #endregion

            #region ternary Operator
            int j = (a == 10) ? 10 : 40;
            Console.WriteLine(j);
            #endregion

            #region null coalescing operator
            int? i = null;
            int k = i ?? 50;
            Console.WriteLine(k);

            string bc = null;
            string cd = bc ?? "ab";           
            Console.WriteLine(cd);
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
            foreach(string c in nums)
            {
                int e;
                int.TryParse(c, out e);
                Console.WriteLine(e);
            }
            #endregion

            #region Object Instantiation of a class
            Circle circle = new Circle();
            circle.Radius = 5;
            double circleArea = circle.GetArea();// getting value as returned by method
            circle.PrintArea();
            circle.MethodHididng();// this hides the base method

            #region polymorphism
            area square = new Square();//area is base class and sqare is derived class
            #endregion
            square.Length = 5;
            square.GetArea();//it is not madatory to catch returned value
            square.PrintArea();
            square.MethodHididng();// casting to base type to call base method
            #endregion

            #region enums, struct, aliases, static members
            veh vehicle = new veh();//veh is the aliase created above
            object[] info = new object[2];
            info[0] = (int)veh.NumberofVehicleWheels.Four;//use of enum
            string category = string.Empty;
            vehicle.SetInfo((int)info[0], out category);//calling non-static memeber //casting object to int as argument
            info[1] = category;
            Vehicle.PrintInfo(info);//calling satic member directly from class
            #endregion




        }
    }
}
