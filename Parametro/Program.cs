using System;

namespace Parametro
{
    class Program
    {
        static void Main(string[] args)
        {
           

           int c1 = Calculator.Sum(2,3);
           int c2 = Calculator.Sum(4,5,6,8);


            Console.WriteLine(c1);
            Console.WriteLine( c2 );
        }
    }
}
