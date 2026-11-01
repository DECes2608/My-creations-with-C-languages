Console.Write("Lütfen sıcaklığı giriniz: ");

double temp = Convert.ToDouble(Console.ReadLine());

if (temp >= 10 && temp <= 30)
{
    Console.WriteLine("Sıcaklık normal.");
}
else if (temp > 50 || temp < -50)
{
    Console.WriteLine("Dışarı çıkmak için çok tehlikeli bir sıcaklık.");
}
else if (temp > 30)
{
    Console.WriteLine("Dışarısı biraz sıcak.");
}
else if (temp < 10)
{
    Console.WriteLine("Dışarısı biraz soğuk.");
}
else
{
    Console.WriteLine("buraya nasıl geldin?");
}