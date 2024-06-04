using System.Reflection;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            //excercise 1
            Console.WriteLine(Addition(a, b));          
            Console.WriteLine(Subtraction(a, b));
            Console.WriteLine(Multplication(a, b));
            Console.WriteLine(DivisionAndModulus(a, b));

            //exercise 2
            double radius = double.Parse(GetUserInput("Please enter a radius: "));         
            AreaOfCircle(radius);
            Console.ReadLine();

        }

        // methods for Addition, Subtraction, & Multiplication
        public static int Addition(int num1, int num2) {

            int result = num1 + num2;
            return result;
        }
        public static int Subtraction(int num1, int num2)
        {

            int result = num1 - num2;
            return result;
        }
        public static int Multplication(int num1, int num2)
        {

            int result = num1 * num2;
            return result;
        }



        // method for Division and Modulus
        public static string DivisionAndModulus(int num1, int num2)
        {

            int divisionResult = num1 / num2;
            int modulusResult = num1 % num2;
            string output = $"{num1} / {num2} is {divisionResult} remainder {modulusResult}";
            return output;
        }

        // method for Area Equation
        public static double AreaOfCircle(double radius) 
        {

            double pi = Math.PI;

            double pow = Math.Pow(radius, 2);

            double result = pi * pow;

            Console.Clear();
            Console.WriteLine($"The area of a circle with a radius of {radius} is {result}");

            return result;
        }

        // method for getting User Input
        public static string GetUserInput(string message) 
        { 
            Console.WriteLine(message);
            return Console.ReadLine();

        }



    }
    
}
