static double Sum(double x, double y)
{
    return x + y;
}
double n1, n2;
Console.WriteLine("enter the first number");
double.TryParse(Console.ReadLine(), out n1);

Console.WriteLine("enter the second number");
double.TryParse(Console.ReadLine(), out n2);
Console.WriteLine($"{n1} + {n2} = {Sum(n2, n1)}");
