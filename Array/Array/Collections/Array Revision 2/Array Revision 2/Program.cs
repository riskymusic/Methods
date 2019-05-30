using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Revision_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the objects need for the app 
            int[] nums = new int[10]; //ARRAY CONCEPT
            Random rand = new Random(); //RANDOM NUMBER GENERATOR 
            double total = 0; //TOTAL FOR THE AVERAGE EQUATION

            //LOOP USED TO ADD THE TEN RANDOM NUMBERS TO THE ARRAY
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 10);
                total += nums[i];
            }
            //DISPLAY THE AVERAGE OF THE 10 NUMBERS TO THE USER 
            Console.WriteLine($"The average of the 10 numbers is: {total/nums.Length}");
            Console.ReadLine();
        }
    }
}
