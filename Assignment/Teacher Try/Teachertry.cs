using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Login_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           //TITLE
            Console.WriteLine("*********************************************************");
            Console.WriteLine("******** Welcome to Rotorua Thermal Holiday Park ********");
            Console.WriteLine("*********************************************************");
            //QUESTION ASKED 
            

            Console.WriteLine("Please Enter a Username with a minimum of 8 characters: ");
           
            Console.WriteLine($"Your username is: { Validateusername()} Please press enter to continue");

            Console.ReadLine();

            //Console.WriteLine("Please Enter your password with a minimum or 8 numerals: ");

            //Console.WriteLine($"Your pasword is: { passwordusername()} Please press enter to continue");


          















        }
        public static string Validateusername()
        {
            //bool usernameRequirement = username.Length >= 8;

            //if (username.Length < 8)
            //{
            //    Console.WriteLine($"\nThe Username {username} does not meet the minimum requirement of 8 characters");
            //}


            //else
            //{
            //    Console.WriteLine($"Thank you {username} is valid");
            //}

            //return
            //    usernameRequirement;
            string un = "";
            do
            {
                Console.Clear();
                Console.WriteLine("\nPlease Enter Again your username with a minimum of 8 characters: ");
                un = Console.ReadLine();

                if (un.Length < 8)
                {
                    Console.WriteLine("Error, press enter to try again...");
                    Console.ReadLine();
                }

            } while (un.Length < 8);
            return un;
        }

//        public static string Validatepassword()
//        string password = "";
//        do
//        {
//           Console.Clear();
//                Console.WriteLine("\nPlease Enter Again your username with a minimum of 8 characters: ");
//                password = Console.ReadLine();

//                if (password.Length< 8)
//                {
//                    Console.WriteLine("Error, press enter to try again...");
//                    Console.ReadLine();
//                }

//} while (password.Length < 8);
//            return password;
        
            

        

       
        
    }
}
