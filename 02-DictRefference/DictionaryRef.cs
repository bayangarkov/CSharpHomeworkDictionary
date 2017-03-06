using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyProject
{
    class Program
    {
        static void Main()
        {
            string inputSting = Console.ReadLine();

            var dict = new Dictionary<string, long>();


            while (inputSting != "end")
            {

                var getFirst = inputSting.Split(' ')[0]; // get the key
                var getSecond = inputSting.Split(' ')[2]; // get the value



                long number;
                if (long.TryParse(getSecond, out number))
                {
                    dict[getFirst] = number;
                }
                else
                {
                    if (dict.ContainsKey(getSecond)) // doesnt work
                    {
                        dict[getFirst] = dict[getSecond];
                    }
                }


                inputSting = Console.ReadLine();
            }

            foreach (var pair in dict)
            {
                var key = pair.Key;
                var val = pair.Value;

                Console.WriteLine($"{key} === {val}");
            }
        }
    }
}
