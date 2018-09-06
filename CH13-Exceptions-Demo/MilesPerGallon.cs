using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH13_Exceptions_Demo
{
  public class MilesPerGallon
    {
        private double _gallons;
        private double _miles;

        public double Mpg => Miles / Gallons;

        public double Miles
        {
            get => _miles;
            set
            {
                //ValidateNonNegative(value);
                _miles = value;
            }
        }

        public double Gallons
        {
            get => _gallons;
            set
            {
                //ValidateNonNegative(value);
                //ValidateNonZero(value);
                _gallons = value;
            }
        }
    }
}
