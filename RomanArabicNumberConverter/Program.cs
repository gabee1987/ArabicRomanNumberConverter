using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanArabicNumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            ConverterLogic converter = new ConverterLogic();
            List<int> testNumbers = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                testNumbers.Add(random.Next(50));
            }

            foreach (var number in testNumbers)
            {
                string romanNumber = converter.ConvertArabicNumberToRoman(number);

                Console.Write("{0,2} in roman is ", number);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(romanNumber);
                Console.ResetColor();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
