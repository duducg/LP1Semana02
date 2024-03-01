using System;
using System.Net;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            //string vars
            string option,mf,ef,nf;
            mf = "Magic Fire :/";
            ef = "Electric Fire :/";
            nf = "Normal fire :/";
            
            //Prompt user for a number
            Console.Write("Please give me an integer number: ");
            string user_in = Console.ReadLine();

            //parse user input to int:
            int n = int.Parse(user_in);
            

            //iterator value initialized to 1
            int cn = 1;
            
            Console.WriteLine($"Number of shots: {n}");
            //start loop here
            while (cn < n)
            {
                //resets every loop cycle
                option = "";
                
                //every 3 iterations:
                if (cn % 3 ==0)
                {
                    //MAGIC FIRE!
                    option = "magic";
                }
                //every 5 iterations:
                if (cn % 5 ==0)
                {
                    //ELECTRIC FIRE!
                    option = "electric";
                }
                //Both above conditions are true:
                if (cn % 5 ==0 && cn % 3 ==0)
                {
                    //BOTH
                    option = "both";
                }
                //default
                string response = "";
                switch (option)
                {
                    case "magic":
                        response = mf;
                        break;
                    case "electric":
                        response = ef;
                        break;
                    case "both":
                        response = mf + " " + ef;
                        break;
                    default:
                        response = nf;
                        break;
                }
                
                Console.WriteLine(cn +": " + response);


                //increment
                cn++;
            }
            

            
        }
    }
}
