using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public delegate void MathOperations(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations=new MathOperations(Add);
            mathOperations += Subtract;
            mathOperations += Multiplication;
            //mathOperations += Multiplication;
            mathOperations(10, 12);
            Console.ReadLine();
        }
        static void Add(int a,int b)
        {
            Console.WriteLine("Addition of "+a+" and "+b+" is "+(a+b));
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction of " + a + " and " + b + " is " + (a - b));
        }
        static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication of " + a + " and " + b + " is " + (a * b));
        }
    }
}
