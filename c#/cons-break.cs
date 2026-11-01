
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

switch (age)
{
    case int n when (age >= 100):
        Console.WriteLine("Giriş yapmak için yaşınız çok büyük!");
        break;
    case int n when (age < 18):
        Console.WriteLine("Giriş yapmak için yaşınız çok küçük!");
        break;
    default:
        Console.WriteLine("Giriş yapabilirsiniz.");
        break;
}
