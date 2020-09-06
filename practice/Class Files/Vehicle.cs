using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace practice.Automobiles
{
    public class Vehicle
    {
        #region private variables
        int _numberofWheels { get; set; }
        string _category { get; set; }
        #endregion

        #region VehicleCategory: struct usage
        public struct VehicleCategory
        {
            public const string SingleWheeler = "Single Wheeler";
            public const string TwoWheeler = "Two Wheeler";
            public const string ThreeWheeler = "Three Wheeler";
            public const string FourWheeler = "Four Wheeler";
        }
        #endregion

        #region NumberofVehicleWheels: enum usage
        public enum NumberofVehicleWheels
        {
           One = 1,
           Two = 2,
           Three = 3,
           Four = 4
        }
        #endregion

        #region SetInfo: non-static member, value and output parameter
        public void SetInfo(int numberofWheels, out string category)//value type parameter and output parameter
        {
            _numberofWheels = numberofWheels;
            if (_numberofWheels == 1)
            {
                _category = VehicleCategory.SingleWheeler;
            }
            else if (this._numberofWheels == 2)
            {
                _category = VehicleCategory.TwoWheeler;
            }
            else if (this._numberofWheels == 3)
            {
                _category = VehicleCategory.ThreeWheeler;
            }
            else if (this._numberofWheels == 4)
            {
                _category = VehicleCategory.FourWheeler;
            }
            else
            {
                _category = string.Empty;
            }
            category = _category;
        }
        #endregion

        #region PrintInfo: static type members and array parameter
        public static void PrintInfo(object[] values)//array type parameter
        {
            Console.WriteLine("Number of Wheels : {0} /n Categoty : {1}", values[0], values[1]);
        }
        #endregion
    }


}
