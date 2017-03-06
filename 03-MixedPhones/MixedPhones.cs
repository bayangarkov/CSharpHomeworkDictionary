using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MixedPhones
{
    class MixedPhones
    {
        static void Main()
        {
            var inputStr = Console.ReadLine();

            var dict = new SortedDictionary<string, decimal>();
            
            
            while (inputStr != "Over")
            {
                var getFirst = inputStr.Split(' ')[0];
                var getSecond = inputStr.Split(' ')[2];

                decimal number;
            
                if (decimal.TryParse(getFirst, out number))
                {
                    dict.Add(getSecond,number);
                }
                else
                {
                    dict.Add(getFirst,Convert.ToDecimal(getSecond));
                }
            
                inputStr = Console.ReadLine();
            
            }

            foreach (var pair in dict)
            {
                var key = pair.Key;
                var val = pair.Value;

                Console.WriteLine(key + " -> " + val);
            }

        }
    }
}
