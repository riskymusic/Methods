using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
     
        
       
        
        static void Main (string[] args)
        {
            Console.WriteLine("Here's Method to find out your BMI");
            Console.Write("Please enter your height in metres: ");
            //optain height from user 
            double h = double.Parse(Console.ReadLine());
            Console.Write("please enter your weight in kg's: ");
            //obtain weight from user 
            double w = double.Parse(Console.ReadLine());
            double result = BMI(h, w);
            Console.WriteLine($"your BMI is:  {Task2(result)}");
            //display result
            float catagory = float.Parse(Console.ReadLine());
        }
        static double BMI(double w, double h)
        {
            return w / (h * h);
        }

        static string Task2(double bmi)

        {
            if (bmi >= 30)
                return "your Obese";

            else if (bmi >= 25 && bmi < 30)

                return "you need to loose some weight";

            else if (bmi >= 18.5 && bmi < 25)

                return "Normal weight";
            else
                return "You are underweight";
        }

  
        
    
    }
}
