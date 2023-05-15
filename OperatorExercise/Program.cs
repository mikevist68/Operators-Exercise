using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {

        //public static AreaOfCircle();


        static void Main(string[] args)
        {
            int add = 5 + 6;
            int subtract = 4 - 2;
            int multiply = 1 * 1;
            int divide = 1 / 2;
            int modulous = 17 % 3;





            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} = {quotient} remainder {remainder}");

            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);

            // exercise 2 

            PrintAreaOfCircle();

        }


        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);

        }



    }

}
