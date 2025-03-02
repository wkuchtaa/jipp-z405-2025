using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1\n");
            int number = 1;
            float money = 12;
            string text = "text";
            bool isLogged = true;
            char mychar = 'A';
            decimal price = 99;
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", number, money, text, isLogged, mychar, price);

            Console.WriteLine("\nZadanie 2\n");
            string myAge = "Age: ";
            int wifeAge = 18;
            string result = myAge + wifeAge;
            Console.WriteLine(result);

            Console.WriteLine("\nZadanie 3\n");
            bool isTrue = true, isFalse = false, isReallyTrue = true;
            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;
            Console.WriteLine("{0} {1} {2}", and, or, negative);

            Console.WriteLine("\nZadanie 4\n");
            int a = 5;
            int b = 12;
            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a % b;
            Console.WriteLine("{0} {1} {2} {3}", add, sub, div, mul);
        }
    }
}