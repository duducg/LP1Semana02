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

            
        }
    }
}
