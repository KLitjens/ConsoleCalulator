using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main()
        {

            Calculator();

        }

        static void Calculator()
        {
            double num1 = 0.0;
            double num2 = 0.0;

            Console.WriteLine("Please enter the first number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the following to the desired opperation: \n \tAddition = [+] \n\tSubtraction = [-] \n\tMultiplication = [*] \n\tDivision = [/]");
            char operation = Convert.ToChar(Console.Read());
            double result;
            Console.WriteLine("Result of " + num1 + operation + num2);
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine(result);
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

 
    }
}
