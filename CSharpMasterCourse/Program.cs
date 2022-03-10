
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMasterCourse
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my Math.");
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            

            Console.WriteLine($"Add {CustomMath.Add(num1, num2)}");
            Console.WriteLine($"Subtract {CustomMath.Subtract(num1, num2)}");
            Console.WriteLine($"Multiply {CustomMath.Multiply(num1, num2)}");
            Console.WriteLine($"Divide {CustomMath.Divide(num1, num2)}");


            Console.Beep();
            Console.ReadKey();
        }

    }
}







