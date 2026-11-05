using System;

class Ad{
 static void Main(){

Console.Write("merhaba adinizi girin: ");

String ad = Console.ReadLine();

int adu = ad.Length;

if (adu > 10)
{
    Console.WriteLine("adiniz cok uzun");
}
else if (adu < 5){
    Console.WriteLine("adiniz cok kisa");
}
else{
  Console.WriteLine("Ne guzel bir ad tam olmasi gereken uzunlukta");
}

 }
}
