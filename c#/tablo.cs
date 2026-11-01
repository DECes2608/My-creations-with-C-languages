class Program{

  static void Main(String[] args){



int sayi1 = 10;
            int sayi2 = 20;
            Console.WriteLine("{0} + {1} = {2} ", sayi1, sayi2, sayi1 + sayi2);
            goto son;
            Console.WriteLine("{0} x {1} = {2} ", sayi1, sayi2, sayi1 * sayi2);
            son:
            Console.ReadKey();
  }
}
