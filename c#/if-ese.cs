
int age;

Console.Write("Yaşınızı giriniz: ");

try
{
    age = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Sayı yazmalısın, harf ya da sembol olmaz.");
    return;
}
catch (OverflowException)
{
    Console.WriteLine("Bu sayı çok büyük.");
    return;
}

if (age >= 100)
    Console.WriteLine("Giriş yapmak için yaşınız çok büyük!");
else if (age < 18)
    Console.WriteLine("Giriş yapmak için yaşınız çok küçük!");
else

