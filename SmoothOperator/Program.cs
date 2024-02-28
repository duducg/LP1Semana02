using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for a non negative integer
            Console.Write("Please insert non negative integer: ");
            string user_in = Console.ReadLine();

            //convert input to type "byte"
            //bytes go from 0 >> 255 (total of 256)

            byte n = byte.Parse(user_in);       

            //Decrement
            Console.WriteLine($"n decremented by 1 : {--n}");

            //Increment
            Console.WriteLine($"n incremented by 1 : {++n}");

            //if input is 0 then the decrement will return 255
        
            //Exercise 4

            //Divide by 2
            Console.WriteLine($"n divided by 2 : {n/2}");

            //Shift left by 3 <<
            Console.WriteLine($"n shifted left by 3 : {n<<3}");

            //XOR with 5
            Console.WriteLine($"XOR with 5: {n ^ 5}");
            
            //is greater then 10
            Console.WriteLine($"Is n greater then 10? {n>10}");

            //Note: next time skip the string interpolation
        }
    }
}
