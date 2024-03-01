using System;
using System.Diagnostics;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {   
            string question, response = "";

            //exit flag
            bool exit = false;

            while (exit != true)
            {
                //Prompt user for a question     
                Console.Write("What is your question? ");
                question = Console.ReadLine();

                //If question is an available option = respond
                switch (question)
                {   
                    //Exit
                    case "EXIT":
                        exit = true;
                        break;
                    case "What is love?":
                        string a, b, c;
                        a = "Baby don't hurt me,";
                        b = "\nDon't hurt me,";
                        c = "\nNo more...";
                        response = a + b + c;
                        break;
                    case "Can you tell me a joke?":
                        response = "Bazinga!";
                        break;
                    case "Have you heard about the word?":
                        response = "Surely you mean the \"Bird\"?";
                        break;
                    case "Marco?":
                        response = "Polo!";
                        break;
                    default:
                        response = "Invalid question, please try again.";
                        break;
                }

                //Print response
                if (exit !=true)
                {
                    //Only triggers if "EXIT" wasn't chosen
                    Console.WriteLine(response);

                }                


            }
            //Only prints if EXIT is true:
            Console.WriteLine("Thank you, come back soon...");
            

            
        }
    }
}
