using System;
using System.Collections.Generic;
using System.Text;

namespace practice.Inheritance
{
    public partial class  Area
    {
        #region Method Hinding
        public void MethodHididng()
        {
            Console.WriteLine("This is method hiding example Base");
        }
        #endregion

        #region LateBinding
        public void LateBinding()
        {
            Console.WriteLine("This is late binding example");
        }
        #endregion

        #region partial method implementation
        partial void partialMethodDeclaration()
        {
            Console.WriteLine("This is partial method declared and implemented separate partial class");
        }
        #endregion
    }
}
