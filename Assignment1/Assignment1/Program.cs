using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    /// <summary>
    /// First Assignemnt of Developing Games with C#
    /// Programming Assignment1
    /// The application will calculate the distance between two points and the angle between those points
    /// </summary>
    /// <param name = "args">Command-line args</param>
    class Program
    {
        //Main Function
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Course! The First Assignment is to Calculate the distance between two points and the angle between them");
            Console.WriteLine();
            Console.WriteLine("Enter the X value for the First Point:");

            //Capture the input from the Console
            float pointX1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Y value for the First Point:");
            //Capture the input from the Console
            float pointY1 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter the X value for the Second Point:");

            //Capture the input from the Console
            float pointX2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Y value for the Second Point:");

            //Capture the input from the Console
            float pointY2 = float.Parse(Console.ReadLine());

            //Printing the Values provided
            Console.WriteLine();
            Console.WriteLine("Provided Values");
            Console.WriteLine("First Point :(" + pointX1 + ", " + pointY1 + ")");
            Console.WriteLine("Second Point :(" + pointX2 + ", " + pointY2 + ")");

            //Declare variable to hold Delta X and Delta Y values
            float deltaX;
            float deltaY;

            //Calculate Delta X
            deltaX = pointX2 - pointX1;
            deltaY = pointY2 - pointY1;

            //Print Delta Values
            Console.WriteLine();
            Console.WriteLine("Delta X: " + deltaX);
            Console.WriteLine("Delta Y: " + deltaY);

            //Pythagarouse theorem
            // a2 + b2 = c2
            //Delcare variable to hold length,radians and angle values
            double length;
            double angle;
            double radians;

            length = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            //Display Length value to Console
            Console.WriteLine("Length is :" + length.ToString("F3"));

            //Calculate Radians using Math.Atan2
            radians = Math.Atan2(deltaY, deltaX);
            Console.WriteLine();
            Console.WriteLine("Radians : " + radians);
            Console.WriteLine();

            //Calculate Angle of the radians
            angle = radians * (180 / Math.PI);
            Console.WriteLine("Angle in Degrees :" + angle.ToString("F3"));



        }
    }
}
