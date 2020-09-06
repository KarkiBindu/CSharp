using System;
using System.Collections.Generic;
using System.Text;

namespace practice.AccessModifiers
{
    public class AccessModifier
    {
        public class Example
        {
            private void NoAccess()
            {
                Console.WriteLine("This is private method");
            }
            public void EverWhereAccess()
            {
                Console.WriteLine("This is public method");
            }
            protected void DerivedClassAccess()
            {
                Console.WriteLine("This is protected method");
            }

            internal void AssemblyAccess()
            {
                Console.WriteLine("This is internal method");
            }
            protected internal void AssemblyDerivedClassAccess()
            {
                Console.WriteLine("This is internal protected method");
            }
        }

        internal class DerivedClass: Example
        {
           
        }
    }
}
