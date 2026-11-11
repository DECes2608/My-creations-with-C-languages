using System;

class Game {
    static void Main(string[] args) {
        int hp = 100;
        int toearn = 0;
        int dodge = 10;
        Random random = new Random();

        while (hp > 0) {
            int dhp = random.Next(30, 100);
            int dparry = random.Next(1, 50);
            int dap = random.Next(5, 15);
            int earn = dap + dhp + dparry;

            Console.WriteLine("\n=== A Enemy Appeared! ===");

            while (hp > 0 && dhp > 0) {
                int dpat = random.Next(1, 4);
                int ac = random.Next(1, 100);
                int ap = 20;

                Console.WriteLine("\nWhat do you want to do? (attack: 1, dodge: 2, heal: 3)");
                if (!int.TryParse(Console.ReadLine(), out int select)) select = 4;

                if (select == 1) {
                    if (dparry > ac) {
                        Console.WriteLine("Enemy parried your attack!");
                        hp -= ap;
                    } else {
                        dhp -= ap;
                        Console.WriteLine($"Enemys hp is {dhp}");
                    }
                } else if (select == 2) {
                    dodge++;
                    Console.WriteLine($"New dodge chance: {dodge}");
                } else if (select == 3) {
                    hp += 15;
                    Console.WriteLine($"Healed! New hp: {hp}");
                }
                else{
                  hp -= 10;
                  Console.WriteLine($"you chosed to suffer your new hp is: {hp} and your balls will explode in 2031 march 5");
                }
                // Düşman öldüyse dövüş döngüsünden çık
                if (dhp <= 0) break;

                if (dpat == 1) {
                    if (dodge > random.Next(1, 100)) {
                        Console.WriteLine("You dodged!");
                    } else {
                        hp -= dap;
                        Console.WriteLine($"Enemy hit you! Your hp: {hp}");
                    }
                } else if (dpat == 2) {
                    dparry += 5;
                    Console.WriteLine("Enemy parry chance increased!");
                }
            else{
                    Console.WriteLine("Enemy thinks that you weak chosed to do nothing");
                }
            }

            if (hp <= 0) {
                Console.WriteLine("You died! Game Over.");
                break;
            }

            Console.WriteLine($"You defeated the enemy! Earned: {earn}");
            toearn += earn;
            Console.WriteLine("Do you want to continue to next enemy? (y/n)");
            if (Console.ReadLine() != "y") {
                Console.WriteLine("Thanks for playing!");
                Console.WriteLine($"your score is {toearn}");
                break;
            }
        }
    }
}
