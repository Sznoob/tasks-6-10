using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Programm
    {
        static void Main(string[] args)
        {

            // task 7

            Console.Write("Enter the Year in four digits: ");
            try
            {
                int year = Convert.ToInt16(Console.ReadLine());

                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                    Console.WriteLine("Year is a Leap Year.");
                else
                    Console.WriteLine("Year is not a Leap Year. ");
            }
            catch
            {
                Console.WriteLine("Incorrect input");
            }


            //task 8

            Console.WriteLine("Give a first number: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Give a second number: ");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Give a third number: ");
            int c = Convert.ToInt16(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The biggest number is: " + a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine("The biggest number is: " + b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine("The biggest number is: " + c);
            }

            int summary = 0;
            int userValue;
            do
            {
                Console.WriteLine("Give a number");

                userValue = Convert.ToInt16(Console.ReadLine());
                summary = summary + userValue;
                Console.WriteLine("Summary is " + summary);
            }
            while (userValue != 0);


            //task 10
            int[] values = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            foreach (var result in values)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine("HEP! ");
                }
                else
                {
                    Console.WriteLine("Value isn't even. ");
                }

            }






            Console.Read();
        }
    }
}