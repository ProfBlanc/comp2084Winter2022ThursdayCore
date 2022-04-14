using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests
{
    /*
     *
     *create 3 methods
     *      Add
     *      Div
     *      Sub
     *          two double arguments
     *
     */ 
    class Calculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return num1 - num2 ;
        }
        public double Div(double num1, double num2) {

            if (num2 == 0)
                throw new DivideByZeroException("2nd number cannot be zero!");

            return num1 / num2;
        }
    }
}
