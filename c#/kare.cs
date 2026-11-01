class Program
{
  static void Main(string[] args){

    Console.Write("enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("enter the number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("what symbol: ");
    String symbol = Console.ReadLine();

    for (int i = 0; i < rows; i++){
  for (int j = 0; j < colums; j++){
    Console.Write(symbol);
     }
    Console.WriteLine();
    }
Console.ReadKey();
}
}
