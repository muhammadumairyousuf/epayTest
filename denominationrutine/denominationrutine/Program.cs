// See https://aka.ms/new-console-template for more information
int[] avaliableCartidges = { 50, 100, 10 };
Console.WriteLine("Enter the amount?");
int amount=int.Parse(Console.ReadLine()!);
foreach (int i in avaliableCartidges)
{
    int count= amount / i;
    if(count > 0)
    {
        Console.WriteLine($"{count} x {i}");
        amount%=i;
    }
   
}
Console.ReadLine();
