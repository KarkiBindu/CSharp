using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using practice;

namespace WindowsFormsApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string path = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) + @"\practice.dll";          
            //Assembly trial = Assembly.LoadFrom(path);
            //Type areaType = trial.GetType("practice.Inheritance.Area");
            //object area = Activator.CreateInstance(areaType);           
            //MethodInfo GetArea = areaType.GetMethod("LateBinding");
            //object[] sth = new object[1] { (object)string.Empty };
            //object ar = GetArea.Invoke(GetArea, sth);

            practice.AccessModifiers.AccessModifier.Example example = new practice.AccessModifiers.AccessModifier.Example();
            //example.NoAccess();//cannot access
            example.EverWhereAccess();
            //example.AssemblyDerivedClassAccess();//cannot be accessed
            //example.AssemblyAccess();//cannot be accessed
            //example.DerivedClassAccess();//can be accessed from derived class only

            #region default code
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            #endregion


        }
    }

    public class AnotherExample : practice.AccessModifiers.AccessModifier.Example
    {
        //internal void AssemblyDerivedClassAccess()
        //{

        //}
    }
}
