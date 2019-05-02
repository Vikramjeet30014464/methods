using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Q1*/
            Console.WriteLine("This application will change the sign of a number...");
            Console.WriteLine("Please enter your number: ");
            Console.WriteLine($"The number with its sign changed would be: {ChangeSign(double.Parse(Console.ReadLine()))}");

            Console.ReadLine();

            /*Q2*/
            Console.WriteLine("This application will convert miles to km's... ");
            Console.Write("Please enter a distance in miles: ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"{miles} = {Converter(miles)}KM's");
        }
        
        /*Method for Q2*/
        static double ChangeSign(double miles)
        {
            return miles * 0.62137;
        }
        /*Method for Q1*/
        static double ChangeSign(double num)
        {
            return num * -1;
        }
        
        //2*/
          static void Main(string[] args)

        {   double apple = 10;
            Circumference(apple);
        }
        static double Circumference(double radius)
        {
            Maths.PI* radius;
        }
        
        }
    } 
}
