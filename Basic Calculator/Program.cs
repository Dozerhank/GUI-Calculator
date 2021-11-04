using System;

namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1, value2;
            char operation;
            Console.WriteLine("Basic Calculator Program");
            Console.Write("Enter the first integer: ");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second integer: ");
            value2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operator: ");
            operation = Convert.ToChar(Console.ReadLine());

            double result = 0;
            switch(operation)
            {
                case '+':
                    result = value1 + value2;
                    Console.WriteLine("The result is: {0}", result);
                    break;
                case '-':
                    result = value1 - value2;
                    Console.WriteLine("The result is: {0}", result);
                    break;
                case '*':
                    result = value1 * value2;
                    Console.WriteLine("The result is: {0}", result);
                    break;
                case '/':
                    if (value2 != 0)
                    {
                        result = value1 / value2;
                        Console.WriteLine("The result is: {0}", result);
                    }
                    else
                    {
                        Console.WriteLine("Error: cannot divide by zero.");
                    }
                    
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
    }
}
