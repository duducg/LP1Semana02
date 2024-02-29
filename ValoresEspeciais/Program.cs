using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {               
            //Executes WriteLine from interpolated string
            //Used to save time

            //declare min and max strings class level vars:
            string min, max;

            void WriteString(string type)
            {
                //call this method after i reassign "min" and "max"
                //Save time I think
                string str = "";

                //just needs "type" as param
                str = $"- {type} - min: {min} | max: {max}";

                Console.WriteLine(str);
            }
            
            
            //Max and Min 
            Console.WriteLine("<<< Data type max and min values >>>\n");

            //int
            min = int.MinValue.ToString();
            max = int.MaxValue.ToString();
            WriteString("integer");
            
            //uint
            min = uint.MinValue.ToString();
            max = uint.MaxValue.ToString();
            WriteString("uint");

            //sbyte
            min = sbyte.MinValue.ToString();
            max = sbyte.MaxValue.ToString();
            WriteString("sbyte");

            //short
            min = short.MinValue.ToString();
            max = short.MaxValue.ToString();
            WriteString("short");

            //ushort
            min = ushort.MinValue.ToString();
            max = ushort.MaxValue.ToString();
            WriteString("ushort");

            //long
            min = long.MinValue.ToString();
            max = long.MaxValue.ToString();
            WriteString("long");

            //ulong
            min = ulong.MinValue.ToString();
            max = ulong.MaxValue.ToString();
            WriteString("ulong");

            //byte
            min = byte.MinValue.ToString();
            max = byte.MaxValue.ToString();
            WriteString("byte");

            //char
            min = char.MinValue.ToString();
            max = char.MaxValue.ToString();
            WriteString("char");

            //float
            min = float.MinValue.ToString();
            max = float.MaxValue.ToString();
            WriteString("float");

            //double
            min = double.MinValue.ToString();
            max = double.MaxValue.ToString();
            WriteString("double");

            //decimal
            min = decimal.MinValue.ToString();
            max = decimal.MaxValue.ToString();
            WriteString("decimal");

            //Line Break for spacing:
            Console.WriteLine("\n<--------------------------------------->\n");

            //Infinity            
            
            //double
            double dNInf = double.NegativeInfinity;
            double dPInf = double.PositiveInfinity;

            Console.WriteLine("\ndouble:");
            Console.WriteLine($"- Negative Infinity: {dNInf}");
            Console.WriteLine($"- Positive Infinity: {dPInf}");

            //float
            float fNInf = float.NegativeInfinity;
            float fPInf = float.PositiveInfinity;

            Console.WriteLine("\nfloat:");
            Console.WriteLine($"- Negative Infinity: {fNInf}");
            Console.WriteLine($"- Positive Infinity: {fPInf}");
            
            Console.WriteLine("\n<--------------------------------------->\n");
            //NaN

            Console.WriteLine("\nNaN values:");
            //via dividing infinity
            double dNaN_a = dPInf / dPInf;
            float fNaN_a = fNInf / fNInf;

            Console.WriteLine($"- Double NaN: {dNaN_a}");
            Console.WriteLine($"- Float NaN: {fNaN_a}");


            //direct

            double dNaN_b = double.NaN;
            float fNaN_b =  float.NaN;

            Console.WriteLine($"- Double direct NaN: {dNaN_b}");
            Console.WriteLine($"- Float direct NaN: {fNaN_b}"); 

            Console.WriteLine("\n<--------------------------------------->\n");

            //Exercise 7 - Overflow and Underflow

            //Overflow
            
            uint maxUInt = uint.MaxValue;
            Console.WriteLine($"Max uint value : {maxUInt}");

            uint pOverUInt = maxUInt++; //returns 0
            Console.WriteLine($"Overflowed uint value : {pOverUInt}"); 

            Console.WriteLine("\n<--------------------------------------->\n");

            //float overflows

            float d = float.MaxValue;
            Console.WriteLine($"Max float value = {d}"); //default max

            float fa = 2* float.MaxValue;
            Console.WriteLine($"Max float value x 2 = {fa}"); //infinity

            float fb = float.MaxValue + 1;
            Console.WriteLine($"Max float value + 1 = {fb}"); //doesn't change

            //float underflow
            //happens when casting to a less precise type
            //or when operating with values that that are outside the type's
            //"digit space range"
            Console.WriteLine("\n<--------------------------------------->\n");
            
            float fc = 0.00005f; //floats have a digit space of 7
            Console.WriteLine($"Initial float value: {fc}");
            float fd = fc + 10000.0f; //floats have a digit space of 7
            Console.WriteLine($"Added float value: {fd}");
            //data is lost


            
            


            
        }
    }
}
