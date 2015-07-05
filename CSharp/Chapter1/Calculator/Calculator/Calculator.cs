using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    ///Contains functions for Arithmetic Operations
    /// </summary>
    public class Calculator
    {

        //Add two numbers
        public int Add(int x, int y)
        {
            return x + y;
        }
        //Subtract two numbers
        public int Sub(int x, int y)
        {
            return x - y;
        }
        //Multiply two numbers
        public int Mul(int x, int y)
        {
            return x * y;

        }
        //Divide two numbers
        public double Div(double x, double y)
        {
            return x / y;
        }
        //Modulous two numbers
        public double Modulo(double x, double y)
        {
            return x % y;
        }
    }
}
