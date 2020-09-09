using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace practice.Inheritance
{
    #region  Area: base class
    public partial class Area// class with public access modifier
    {
        #region variables with protected access modifier
        //only accesible by from derived class
        protected double _radius;
        protected double _length;
        protected double _breadth;
        protected double _area;
        #endregion

        #region Encapsulation// read and write property
        public double Radius
        {
            set
            {
                this._radius = value;
            }
            get
            {
                return this._radius;
            }
        }

        public double Length
        {
            set
            {
                this._length = value;
            }
            get
            {
                return this._length;
            }
        }

        public double Breadth
        {
            set
            {
                this._breadth = value;
            }
            get
            {
                return this._breadth;
            }
        }
        #endregion

        #region Virtual methods for overriding
        public virtual double GetArea()
        {
            return _area;
        }

        public virtual void PrintArea()
        {
            Console.WriteLine("Area is {0}",_area);
        }
        #endregion      

        partial void partialMethodDeclaration();//cannot have access modifiers

        public void CallPartialMethod()
        {
            partialMethodDeclaration();
        }
    }
    #endregion

    #region Square: derived class
    public class Square : Area
    {
        #region GetArea/PrintArea Overriding implementation
        public override double GetArea()
        {
            _area = Math.Pow(_length, 2);
            return _area;
        }
        public override void PrintArea()
        {
            Console.WriteLine("Area of square is {0}", _area);
        }
        #endregion

        #region Method hiding implementation
        public new void MethodHididng()
        {
            Console.WriteLine("This is method hiding example Square");
        }
        #endregion
    }
    #endregion

    #region Circle: derived class
    public class Circle : Area
    {
        public override double GetArea()
        {
            _area = Math.PI * Math.Pow(_radius,2);
            return _area;
        }

        public override void PrintArea()
        {
            Console.WriteLine("Area of circle is {0}", _area);
        }

        public new void MethodHididng()
        {
            Console.WriteLine("This is method hiding example Circle");
        }
    }
    #endregion

    #region Rectangle: derived class
    public class Rectangle : Area
    {
        public override double GetArea()
        {
            _area = _length * _breadth;
            return _area;
        }

        public override void PrintArea()
        {
            Console.WriteLine("Area of rectangle is {0}", _area);
        }

        public new void MethodHididng()
        {
            Console.WriteLine("This is method hiding example Rectangle");
        }
    }
    #endregion
}
