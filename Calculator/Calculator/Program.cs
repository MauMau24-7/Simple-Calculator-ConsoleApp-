using System;

double x = 0;
double y = 0;
double result = 0;

try
{
    Console.WriteLine("What's the first number?:");
    x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What's the second number?:");
    y = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What basic operation to use?: (+, -, *, /)");
    switch (Console.ReadLine())
    {
        case "+":
            result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
            break;

        case "-":
            result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
            break;

        case "*":
            result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
            break;

        case "/":
            result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
            break;

        default:
            Console.WriteLine("That was not a valid option");
            break;
    }
}

catch (Exception ex)
{
    Console.WriteLine("Error: " + ex);
}



Console.ReadKey();

