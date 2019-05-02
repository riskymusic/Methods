using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write($"circumference = {Circumference(radius)}\nArea = {Area(radius)}");
            Console.ReadLine();
        }
            static double Circumference(double radius)
            {
                return 2 * Math.PI * radius;
            }

        static double Area(double radius)
        {
            return (radius * radius) * Math.PI;
        }
        
    }
}
