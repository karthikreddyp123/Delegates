using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int AddDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            AddDelegate addDelegate = new AddDelegate(Add);
            Console.WriteLine("Sum of 10 and 12 is: {0}", addDelegate(10, 12));
            Console.Read();
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
