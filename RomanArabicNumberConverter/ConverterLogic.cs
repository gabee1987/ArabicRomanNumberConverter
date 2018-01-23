using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanArabicNumberConverter
{
    public class ConverterLogic
    {
        public  readonly Dictionary<char, int> RomanNumberDictionary;
        public  readonly Dictionary<int, string> NumberRomanDictionary;

        public ConverterLogic()
        {
            RomanNumberDictionary = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            NumberRomanDictionary = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" },
            };
        }

        public string ConvertArabicNumberToRoman(int arabic)
        {
            var romanNumber = new StringBuilder();
            foreach (var item in NumberRomanDictionary)
            {
                while (arabic >= item.Key)
                {
                    romanNumber.Append(item.Value);
                    arabic -= item.Key;
                }
            }
            return romanNumber.ToString();
        }

        public int ConvertRomanNumberToArabic(string roman)
        {
            int total = 0;

            int current, previous = 0;
            char currentRoman, previousRoman = '\0';

            for (int i = 0; i < roman.Length; i++)
            {
                currentRoman = roman[i];

                previous = previousRoman != '\0' ? RomanNumberDictionary[previousRoman] : '\0';
                current = RomanNumberDictionary[currentRoman];

                if (previous != 0 && current > previous)
                {
                    total = total - (2 * previous) + current;
                }
                else
                {
                    total += current;
                }

                previousRoman = currentRoman;
            }

            return total;
        }
    }
}
