Console.Write("Input first noun ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second noun ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b)
{
    Console.Write(a);
    Console.Write(" = ");
    Console.Write(b);
    Console.WriteLine("^2");
}
else 
{
    Console.Write(a);
    Console.Write(" <> ");
    Console.Write(b);
    Console.WriteLine("^2"); 
}