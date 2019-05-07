using System;
using System.Linq;

namespace RomanToDec
{
    public class RomanToDecimal
    {
        public static int RomanToDec(string s)
        {
            char []digits = {'M', 'D', 'C', 'L', 'X', 'V', 'I'};
            int []values = {1000, 500, 100, 50, 10, 5, 1};
            int result = 0;
            bool incorrect = true;
            for (int i = s.Length - 1; i > 0; i -= 2)
            {
                int val1 = 0; int val2 = 0;
                incorrect = true;
                for (int j = 0; j < digits.Length; ++j)
                {
                    if (s.ElementAt(i) == digits[j])
                    {
                        val1 = values[j];
                        incorrect = false;
                    }
                    if (s.ElementAt(i - 1) == digits[j])
                    {
                        val2 = values[j];
                        incorrect = false;
                    }
                }
                if (incorrect)
                    return 0;
                if (val1 != 0)
                {
                    if (val1 > val2)
                        result += (val1 - val2);
                    else
                        result += (val2 + val1);
                }
            }
            if (s.Length % 2 != 0)
            {
                int val1 = 0; int val2 = 0;
                incorrect = true;
                for (int j = 0; j < digits.Length; ++j)
                {
                    if (s.ElementAt(0) == digits[j])
                    {
                        val1 = values[j];
                        incorrect = false;
                    }
                    if (s.ElementAt(1) == digits[j])
                    {
                        val2 = values[j];
                        incorrect = false;
                    }
                }
                if (incorrect)
                    return 0;
                if (val1 >= val2)
                    result += val1;
                else
                    result -= val2;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Print a roman number (>= 3000): ");
            string s = Console.ReadLine();
            if (RomanToDec(s) != 0)
                Console.WriteLine(s + " = " + RomanToDec(s).ToString());
            else
                Console.WriteLine("Input was not correct");
            Console.Write("Press Enter ... ");
            Console.ReadKey();
        }
    }
}