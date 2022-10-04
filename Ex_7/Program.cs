Console.WriteLine("Please, input three-digit noun: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("The last number is ");
Console.WriteLine(Math.Abs(a%10));