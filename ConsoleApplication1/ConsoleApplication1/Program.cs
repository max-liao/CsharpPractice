using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod1_lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            firstName = "Tom";
            lastName = "Thumb";
            age = 18;
            street = "123 spring street";
            city = "atlanta";
            country = "usa";
            birthDate = new DateTime(1974, 11, 17);

            Console.WriteLine("age is {0}", age);
            Console.WriteLine("{0} , {1}", firstName, lastName);
            Console.WriteLine(street + " , " + city + "," + country);
            Console.WriteLine($"Born on {birthDate} , {firstName}");
            Console.WriteLine("Born on {0}", birthDate);

            Console.WriteLine("enter integer and press enter :");
            int input = 0;
            try
            {
                input = Int32.Parse(Console.ReadLine());
            }
            catch ( Exception e)
            {
                Console.WriteLine("in exception");
            }

            if ((input % 2) == 0)
                Console.WriteLine("the number is even");
            else
                Console.WriteLine("the number is odd");

            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }
}
