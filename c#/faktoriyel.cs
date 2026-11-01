using System;
class Fak
{

    static void Main()
    {
        Console.Write("Faktoriyeli istenen sayıyı giriniz: ");
        if (!int.TryParse(Console.ReadLine(), out int F))
        {
            Console.WriteLine("Dostum gerçekten bir yazının faktoriyelini almak istedi");
            return;
        }

        if (F <= 0)
        {
            Console.WriteLine("0 ın ve negatif sayıların faktoriyeli alınamaz");
        }
        else if (F == 1)
        {
            Console.WriteLine(1);
            return;
        }
        else { }

        int sayi = 1;

        while (F > 1)
        {
            sayi *= F;
            F--;
        }
        ;
        Console.WriteLine(sayi);
        Console.ReadKey();
    }

}
