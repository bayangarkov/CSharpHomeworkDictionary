using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var outup = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                var entry = input
                    .Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var key = entry[0];
                int value;

                var checkNumber = Int32.TryParse(entry[1], out value);

                if (checkNumber == true)
                {
                    if (!outup.ContainsKey(key))
                    {
                        outup[key] = new List<int>();
                    }
                    for (int i = 1; i < entry.Count; i++)
                    {
                        outup[key].Add(int.Parse(entry[i]));
                    }
                }
                else
                {
                    if (outup.ContainsKey(entry[1]))
                    {
                        outup[key] = new List<int>(outup[entry[1]]);
                    }

                }

                input = Console.ReadLine();
            }
            foreach (var name in outup)
            {
                var personName = name.Key;
                var values = name.Value;

                Console.WriteLine($"{personName} === {string.Join(", ", values)}");
            }
        }
    }
}