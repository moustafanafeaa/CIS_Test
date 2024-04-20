//--------------Delegates-----------------


using Task5;

int n1, n2;
Console.WriteLine("enter the first number");
int.TryParse(Console.ReadLine(), out n1);

Console.WriteLine("enter the second number");
int.TryParse(Console.ReadLine(), out n2);

MathOperation Sum = MathOperator.Addition;
Console.WriteLine($"{n1} + {n2} = {Sum(n1,n2)}");

MathOperation Subtract = MathOperator.subtraction;
Console.WriteLine($"{n1} - {n2} = {Subtract(n1, n2)}");

MathOperation Multiply = MathOperator.multiplication;
Console.WriteLine($"{n1} * {n2} = {Multiply(n1, n2)}");

MathOperation Divide = MathOperator.division;
Console.WriteLine($"{n1} / {n2} = {Divide(n1, n2)}");


