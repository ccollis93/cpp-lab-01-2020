using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01pt2
{
    class Program
    {
        static void Main(string[] args)
        { // below are the cosole I/O for gathering the information for the story
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            // this line below converts the string input to an int
            int ageNum = Convert.ToInt32(age);

            Console.WriteLine("Enter the city you live in");
            string city = Console.ReadLine();

            Console.WriteLine("Enter your College");
            string coll = Console.ReadLine();

            Console.WriteLine("Enter your job title");
            string job = Console.ReadLine();

            Console.WriteLine("Enter an animal species");
            string pet = Console.ReadLine();

            Console.WriteLine("Enter a name");
            string petName = Console.ReadLine();

            // the lines below print out the story, although I am having trouble getting it to display
            Console.WriteLine("There once was a person named " + name + "who lived in " + city + " .");
            Console.WriteLine("At the age of " + ageNum + " they went to " + coll + " .");
            Console.WriteLine(name + "Graduated and went to work as a" + job + " .");
            Console.WriteLine("Then, " + name + "adopted a " + pet + " named " + petName + " .");
            Console.WriteLine("They both lived happily everafter, THE END!");
            Console.ReadLine();

           


        }
    }
}
