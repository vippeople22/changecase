using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changecase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Begin with getting the text from the user
            Console.WriteLine("Input text to be converted");
            string ToBeConverted = (Console.ReadLine());
            // Check if we want to convert to lower or uppercase
            Console.WriteLine("Convert to Uppercase or Lowercase (u/l)");
            string LowerOrUpper = (Console.ReadLine());

            if (LowerOrUpper == "u")
            {
                Console.WriteLine("\r\n\n" + ToBeConverted.ToUpper());
            }
            else
            {
                Console.WriteLine("\r\n\n" + ToBeConverted.ToLower());
            }

        }
    }
}