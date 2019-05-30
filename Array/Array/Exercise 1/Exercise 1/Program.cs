using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //String array of size 3
            string[] medalWinners = new string[3];

            //Three names to the array. 
            Console.Write("Please enter the name of the GOLD medal winner: ");
            medalWinners[0] = Console.ReadLine();
            Console.Write("Please enter the name of the SILVER medal winner: ");
            medalWinners[1] = Console.ReadLine();
            Console.Write("Please enter the name of the BRONZE medal winner: ");
            medalWinners[2] = Console.ReadLine();
            
           //Asks user to select which medal winner they would like to see 
            Console.WriteLine("\nWhich medal winner would you like to see. \n1 - gold\n2 - Silver\n3 - Bronze");
            //Take in the user input and save it as an int
            int input = int.Parse(Console.ReadLine());

            //output the appropriate medal winner to the console using the users input. 
            //Subtract 1 from the input to match the correct array indicies. 
            Console.WriteLine($"The medal winner is: {medalWinners[input - 1]}");

            Console.ReadLine();
        }
    }
}
