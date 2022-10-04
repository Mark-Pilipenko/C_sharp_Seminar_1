Console.Write("Input noun, please:  ");
int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write("All integer nouns from -");
Console.Write(n);
Console.Write(" to ");
Console.Write(n);
Console.WriteLine(":");
int i = -n;
while (i < n)
{
    Console.Write(i);
    Console.Write(", ");
    i++;
}
Console.WriteLine(i);