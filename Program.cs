using System;

namespace ChapterFiveConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = 700;
            Console.WriteLine(weight >= 500);

            int a = 5;
            int b = 7;
            bool condition = (b > a) && (a + b < a * b);
            Console.WriteLine(condition);

            bool result = (2 < 3) && (3 < 4);

            bool result = (2 < 3) || (1 == 2);
        }
    }
}

//if if-else
//switch case
//comparision operator == != >= <= boolean value true false
//logical operator and or  = &&,||
