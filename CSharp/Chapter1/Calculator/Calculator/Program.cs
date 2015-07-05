using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //Application Entry point
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int add = calc.Add(10, 34);
            Console.WriteLine("10+34 is {0}.", add);
            int sub = calc.Sub(34, 10);
            Console.WriteLine("34-10 is {0}.", sub);
            int mul = calc.Mul(30, 40);
            Console.WriteLine("30*40 is {0}.", mul);
            double div = calc.Div(500, 6);
            Console.WriteLine("500/6 is {0}.", div);
            double modulo = calc.Modulo(56, 9);
            Console.WriteLine("56*9 is {0}.", modulo);
            Console.ReadLine();

        }
    }
}
