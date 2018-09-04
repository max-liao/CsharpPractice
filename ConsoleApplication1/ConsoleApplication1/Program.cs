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
            Console.WriteLine($"Born on {birthDate}");
            Console.WriteLine("Born on {0}", birthDate);
            Console.ReadLine();
        }
    }
}
