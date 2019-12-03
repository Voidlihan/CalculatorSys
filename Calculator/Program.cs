using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int fn = int.Parse(args[0]);
            int sn = int.Parse(args[1]);
            Console.WriteLine(fn + sn);
        }
    }
}
