using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestProject_15._02._2022
{
    public class Class1
    {       
        public static double ForTest(double a, double b, double c)
        {
            double x = b * b - 4 * a * c;

            return x;
        }      
    }
}
