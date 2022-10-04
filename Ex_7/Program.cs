Console.WriteLine("Please, input three-digit noun: ");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
while (a < 100|a > 999)
{
    Console.WriteLine("Incorrect noun!");
    Console.WriteLine("Please, input three-digit noun: ");
    a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
Console.Write("The last number is ");
Console.WriteLine(a%10);