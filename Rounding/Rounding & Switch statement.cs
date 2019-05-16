using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******TASK3*******");
            Console.WriteLine("Please enter what number your transaction ends with between 1 - 9 :  ");
            int userNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"{userNum} gets rounded = {Rounding(userNum)}");

            Console.ReadLine();
        

        }
        
        public  static  string Rounding (int num)
        {
            string result = "-1";
            switch(num)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    result = "down";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                    result = "up";
                    break;
            }

            return result;

        }
         
    
    }

}
