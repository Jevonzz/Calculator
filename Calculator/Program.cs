using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string function;
            bool restart;

            Console.WriteLine("Welcome To Calculator Program!");

            do
            {
                Console.WriteLine("Please Enter Your First Number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter Your Second Number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Your Desired Function(Symbol): ");
                Console.WriteLine("Add --- + ");
                Console.WriteLine("Substract --- - ");
                Console.WriteLine("Multiply --- * ");
                Console.WriteLine("Divide --- / ");
                function = Console.ReadLine();

                switch (function) {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Invalid Function!");
                        break;
                }
                Console.WriteLine("Do you want to restart the calculator? (Y/N)");
                if (Console.ReadLine() == "Y")
                {
                    restart = true;
                }
                else
                {
                    restart = false;
                }
            } while (restart == true);
        }
    }
}