using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab7
{
    public class BasicMath
    {
        public double Add(double a, double b)
        { return a + b; }
        public double Subtract(double a, double b) { return a - b; }
        public double Multiply(double a, double b) { return a * b; }
        public double Divide(double a, double b)
        {
            if (b == 0) { throw new DivideByZeroException("Cannot divide by zero"); }
            else { return a / b; }

        }
    }
}
