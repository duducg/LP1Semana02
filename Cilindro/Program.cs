using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 5
            Console.WriteLine("Cylinder Exercise:");
            
            //Prompt user for Cylinder params:
            //Height
            Console.Write("Please input height:");
            string height = Console.ReadLine();
            float h = float.Parse(height);
            

            //Radius
            Console.Write("Please input radius:");
            string radius = Console.ReadLine();
            float r = float.Parse(radius);

            //Calculate Volume
            float v = MathF.Pow(r,2.0f)*(MathF.PI)*h;

            Console.WriteLine($"Cylinder Volume = {v}");

            //Calculate Surface Are
            float s = 2 * (MathF.PI) * r * (r + h);

            Console.WriteLine($"Cylinder Surface Area = {s}");
            

                    

        }
    }
}
