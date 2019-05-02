using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number: "); 
            Console.Write($"The number with its sign changed would be: {changesign(double.Parse(Console.ReadLine()))}");
            Console.ReadLine();
        }
        static double changesign(double num)
        {//equation 
            return num * -1;
        }




    }
}

