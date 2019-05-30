using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            for(int i = 0; i < names.Length; i++)
            {
                Console.Write("Please enter a name to add to the array:");
                names[i] = Console.ReadLine();
            }
        }
    }
}
