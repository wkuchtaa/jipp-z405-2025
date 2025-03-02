using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1");
            int number = 1;
            float money = 12;
            string text = "text";
            bool isLogged = true;
            char mychar = 'A';
            decimal price = 99;
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", number, money, text, isLogged, mychar, price);

            Console.WriteLine("\nZadanie 2");
            string myAge = "Age: ";
            int wifeAge = 18;
            string result = myAge + wifeAge;
            Console.WriteLine(result);

            Console.WriteLine("\nZadanie 3");
            bool isTrue = true, isFalse = false, isReallyTrue = true;
            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;
            Console.WriteLine("{0} {1} {2}", and, or, negative);

            Console.WriteLine("\nZadanie 4");
            int a = 5;
            int b = 12;
            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a % b;
            Console.WriteLine("{0} {1} {2} {3}", add, sub, div, mul);

            Console.WriteLine("\nZadanie 5");
            string a_ = "Ala ";
            string b_ = "ma ";
            string c_ = "kota.";
            string result_ = a_ + b_ + c_;
            Console.WriteLine("{0}", result_);
            //Dodawanie zmiennych typu string łączy wszystkie dodane zmienne w jeden ciąg znaków

            Console.WriteLine("\nInstrukcje sterujące i pętle\n\nZadanie 1");
            int n1 = 10;
            int n2 = 20;
            if (n1 > n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            if (n2 > n1)
            {
                Console.WriteLine("n2 jest większe od n1");
            }
            if (n1 == n2)
            {
                Console.WriteLine("n2 jeset równe n1");
            }
            Console.WriteLine("\nZadanie 2");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }
            int cos = 0;
            while (cos < 10)
            {
                Console.WriteLine("C#");
                cos++;
             }
            Console.WriteLine("\nZadanie 3");
            int n_zad3 = 10;
            for (int i = 0;i < n_zad3; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i + " - Parzysta");
                }
                else
                {
                    Console.WriteLine(i + " - Nieparzysta");
                }
            }
            Console.WriteLine("\nZadanie 4");
            int n_zad4 = 5;
            for (int i = 0; i < n_zad4; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
            Console.WriteLine("\nZadanie 5");
            int exam = 57;
            if (exam < 0 || exam > 100)
                Console.WriteLine("Wartość poza zakresem.");
            else if (exam <= 39)
                Console.WriteLine("Ocena Niedostateczna");
            else if (exam <= 54)
                Console.WriteLine("Ocena Dopuszczająca");
            else if (exam <= 69)
                Console.WriteLine("Ocena Dostateczna");
            else if (exam <= 84)
                Console.WriteLine("Ocena Dobra");
            else if (exam <= 98)
                Console.WriteLine("Ocena Bardzo Dobra");
            else
                Console.WriteLine("Ocena Celująca");
        }
    }
}
