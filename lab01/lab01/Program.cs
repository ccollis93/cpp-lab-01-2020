using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks user for their name
            Console.WriteLine("Please enter your name.");

            //reads in the user's name
            string usrName = Console.ReadLine();

            //outputs the user's inputted name 
            Console.WriteLine("Welcome " + usrName);
           
        }
    }
}
