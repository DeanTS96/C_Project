// See https://aka.ms/new-console-template for more information
using System;
namespace MyNamespace{
    class MyClass {
        static void Main(string[] args) {
            bool on = true;
            do
            {
                Console.WriteLine("Please enter your first value or reply \"OFF\" to turn off the calculator.");
                var num1 = Console.ReadLine();
                if(num1.ToUpper() != "OFF")
                {
                    Console.WriteLine("Please enter the operation to use Multiply(*), Divide(/), Add(+), Subtract(-).");
                    string operation = Console.ReadLine();
                    Console.WriteLine("Please enter your second value");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    switch (operation)
                    {
                        case "*":
                            Console.WriteLine($"Hey, your answer is {Convert.ToDouble(num1) * num2}");
                            break;
                        case "/":
                            Console.WriteLine($"Hey, your answer is {Convert.ToDouble(num1) / num2}");
                            break;
                        case "+":
                            Console.WriteLine($"Hey, your answer is {Convert.ToDouble(num1) * num2}");
                            break;
                        case "-":
                            Console.WriteLine($"Hey, your answer is {Convert.ToDouble(num1) * num2}");
                            break;
                        default:
                        Console.WriteLine("No operation recieved");
                        break;
                    }; 
                } else 
                {
                    on = false;
                }
            }while(on);
            Console.WriteLine("Calculator off");
        }
    }
}
