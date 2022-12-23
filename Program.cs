using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number smallest");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number largest");
            double n2 = double.Parse(Console.ReadLine());

            for (double i = n1; i <= n2; i++)
            {
                for (double y = 2; y <= i; y++)
                {
                    if (i == 2)
                        Console.WriteLine(2);
                    if (i % y == 0)
                        break;
                    else if (y == i - 1)
                        Console.WriteLine(i);
                }
            }
        }
    }
}
