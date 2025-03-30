using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadanie 1");
        string[] colors = new string[4];
        colors[0] = "biały";
        colors[1] = "czerwony";
        colors[2] = "fioletowy";
        colors[3] = "pomaranczowy";

        Console.WriteLine($"Moj pierwszy kolor to {colors[0]}");
        Console.WriteLine($"Moj ostatni kolor to {colors[3]}");

        Console.WriteLine("\nZadanie 2");
        int[] liczby = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("for");
        for (int i = 0; i < liczby.Length; i++)
        {
            Console.WriteLine($"Liczba: {liczby[i]}");
        }
        Console.WriteLine("foreach");
        foreach (int i in liczby) { Console.WriteLine($"Liczba: {liczby[i]}"); ; }
        Console.WriteLine("while");
        int x = 0;
        while (x < liczby.Length)
        {
            Console.WriteLine($"Liczba: {liczby[x]}");
            x++;
        }
        Console.WriteLine("\nZadanie 3");
        List<string> fruits = new List<string>();
        fruits.Add("Pomidor");
        fruits.Add("Jabłko");
        fruits.Add("Marchewka");
        fruits.Add("Kiwi");
        string wynik = "";
        for (int i = 0;i < fruits.Count; i++)
        {
            wynik += fruits[i];
            if (i < fruits.Count - 1)
            {
                wynik += ", ";
            }
        }
        Console.WriteLine(wynik);
        fruits.Remove("Pomidor");
        fruits.RemoveAt(fruits.Count - 1);
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
