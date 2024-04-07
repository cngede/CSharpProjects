using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables and initialize to zero
            int num1 = 0; int num2 = 0;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r ");
            Console.WriteLine("-------------------------\n");
    
        // Ask the user to type the first number
        Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type a number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to choose an option
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");

            // use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;

                case "2":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "3":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;

                case "4":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for user to respond before closing
            Console.Write("Press any key to close the console calculatopr app ...");
            Console.ReadKey();


        }
    }

}



