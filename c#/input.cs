using System;

class Input{
  static void Main(){

      // For check age
   Console.Write("Please enter your age: "); //asking for input
   if (!int.TryParse(Console.ReadLine(), out int age))
   {
     Console.WriteLine("Bro dont make jokes on me just enter a int number");
       return;
   }

      // For check licance
   Console.Write("do you have driving licance (yes = 1/ no = 0 or true false):"); // same
   string licanceInput = Console.ReadLine() ?? "0";
   bool licance = (licanceInput == "1");

if (licanceInput == "1" || licanceInput == "true"){
  licance = true;
}
else if ( licanceInput == "0" || licanceInput == "false"){
  licance = false;
}
else{
  Console.WriteLine("Invalid input! Can't you even read??");
    return;
}
    if (licance && age >= 18){
      Console.WriteLine("You can drive a car");
    }
    else if (!licance && age < 18){
   Console.WriteLine("Sorry bro you are not even 18");
    }
    else if (!licance && age >= 18){
      Console.WriteLine("you have to get a licance first");
    }
    else
      Console.WriteLine("Are you kidding or just being stupid");
  }
}
