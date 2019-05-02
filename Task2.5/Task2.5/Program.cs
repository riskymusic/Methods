using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5 //TASK 2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This method will convert Kms into miles"); //Title 
            Console.Write("Please enter a distance in miles: "); //question 
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{miles} = {Converter(miles)}km's"); //formula written out 
        }
        static double Converter(double miles)
        {
            return miles * 0.62137; //formula
        }
        
    }
}
