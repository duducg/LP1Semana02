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
            Console.WriteLine($"Input decremented by 1 : {--n}");

            //Increment
            Console.WriteLine($"Input incremented by 1 : {++n}");

            //if input is 0 then the decrement will return 255
        
            

            
        }
    }
}
