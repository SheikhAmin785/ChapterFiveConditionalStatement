using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFiveConditionalStatement
{
    class IfElseCondition
    {
        static void Main()
        {
            Console.WriteLine("Input two Numbers");

            Console.WriteLine("Enter first number");
            int firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int secondnumber = int.Parse(Console.ReadLine());

            int bignumber = firstnumber;

            if (secondnumber > firstnumber)
            {
                bignumber = secondnumber;
            }

            Console.WriteLine("the big number is:{0}", bignumber);

        }

        static void Main()
        {
            int x = 2;
            if (x > 3)
            {
                Console.WriteLine("x is greater than three");
            }
            else
            {
                Console.WriteLine("x is not greater than three");
            }
        }
        static void Main()
        {
            int a = 5;
            int b = 3;
            if (a == b)
            {
                Console.WriteLine("this two number are equal");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("number a is greater");
                }
                else
                {
                    Console.WriteLine("the number b is greater");
                }
            }
        }
        static void Switch()  //switch case statement
        {
            int number = 6;
            switch (number)
            {
                case 1:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine("the number is not prime!");break;

                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("the number is prime!");break;

                default:
                    Console.WriteLine("unknown number!");break;

            }

        }
    }
}
