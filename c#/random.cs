using System;

class Program{

  static void Main(string[] args){
    Random random = new Random();

    int num2 = random.Next(1, 11);
    int num3 = random.Next(1, 11);
    int num1 = random.Next(1, 11);
    int equal = num1 + num2 + num3;
    Console.WriteLine($"there is three random numbers between 0-10 num1: {num1} num2: {num2} num3: {num3}");
    Console.WriteLine($"and there is the total: {num1 + num2 + num3}");
    if (equal < 10)
      Console.WriteLine("The Number isnt even 10");
    else if (equal < 20)
      Console.WriteLine("the number is greater than 10 but it isnt that good");
    else
      Console.WriteLine("It is a good random you are lucky");
  }
}


