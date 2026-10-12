using System;

class Printer
{
    static void Main()
    {
        Console.Write("Daha once program yazdin mi? (1: Evet, 0: Hayir): ");
        string input = Console.ReadLine() ?? "";
        if (input == "1")
        {
            Console.WriteLine("C#'a tekrar hos geldin!");
        }
        else if (input == "0")
        {
            Console.WriteLine("Bu benim ilk C# programim!");
        }
        else if (input == "sandivic")
        {
            Console.WriteLine("Sandvic secimi yapildi!");
        }
        else if (input == "canim istemiyor")
        {
            Console.WriteLine("O zaman bosver >.<");
        }
        else if (input == "ben kediyim adam ol")
        {
            Console.WriteLine("O zaman merhaba kedi dostum! :3");
        }
        else
        {
            Console.WriteLine("Gecersiz secim! Lutfen sadece 1 veya 0 girin.");
        }
    }
}