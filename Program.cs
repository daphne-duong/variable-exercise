using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculate area of a circle
            double radius = 15;
            double pi = 3.14;
            double area;

            area = radius * radius * pi;
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}cm^2\n\n");

            //Calculate cost to carpet a room
            double length = 8.5;
            double width = 6;
            double costPerMetre = 20;
            double carpetArea;
            double totalCost;

            carpetArea = length * width;
            totalCost = costPerMetre * carpetArea;

            Console.WriteLine($"The area of a {length} x {width} room is {carpetArea}m^2");
            Console.WriteLine($"The cost of carpet at ${costPerMetre} per m^2 is ${totalCost}\n\n");

            //Calculate magic numbers
            int startNumber;
            int magicNumber;

            startNumber = 5;
            magicNumber = startNumber + 2;
            magicNumber = magicNumber * 2;
            magicNumber = magicNumber - 2;
            magicNumber = magicNumber / 2;
            magicNumber = magicNumber - startNumber;

            Console.WriteLine($"The magic number is number: {magicNumber}\n\n");

            Console.ReadKey();
        }
    }
}

