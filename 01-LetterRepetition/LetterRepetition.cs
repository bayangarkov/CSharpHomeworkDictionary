using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LetterRepetition
{
    class LetterRepetition
    {
        static void Main()
        {
            var inputString = Console.ReadLine();

            var result = new Dictionary<char, int>();

            foreach (var str in inputString)
            {
                if (!result.ContainsKey(str))
                {
                    result[str] = 0;
                }

                result[str]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
