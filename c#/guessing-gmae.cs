using System;

class Program{
  static void Main(string[] args){
    Random random = new Random();

    int num = random.Next(1, 101);
    int attemp = 0;
    Console.WriteLine("---Welcome to guessing game--- \n guess a number between 1-100");

    while (true){
      if (!int.TryParse(Console.ReadLine(),out int guess)){
        Console.WriteLine("Please enter a number");
          continue;
      }
    attemp++;
      if (guess < num)
        Console.WriteLine("up");
      else if (guess > num)
        Console.WriteLine("down");
      else{
        Console.WriteLine("Good job you did it!!!!");
        Console.WriteLine($"Your tried {attemp} times");
          break;
      }
    }
  }
}
