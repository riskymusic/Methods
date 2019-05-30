using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fivenames = new string[5];

            Console.Write("Please enter the first name: ");
            fivenames[0] = Console.ReadLine();
            Console.Write("Please enter the Second name: ");
            fivenames[1] = Console.ReadLine();
            Console.Write("Please enter the Third name: ");
            fivenames[2] = Console.ReadLine();
            Console.Write("Please enter the Fourth name: ");
            fivenames[3] = Console.ReadLine();
            Console.Write("Please enter the Fifth name: ");
            fivenames[4] = Console.ReadLine();

            Console.WriteLine($"First name in the array: {fivenames[0]}");
            Console.WriteLine($"Last name in the array: {fivenames[4]}");

          
           
            Console.ReadLine();


        }
    }
}
