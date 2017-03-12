using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_ForumTopics
{
    class ForumTopics
    {
        static void Main()
        {
            var dict = new Dictionary<string , HashSet<string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "filter")
            {
                var entry = inputLine.Split(new[] {' ', ',', '-', '>'}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var key = entry[0];

                if (!dict.ContainsKey(key))
                {
                    dict[key] = new HashSet<string>();
                }
                for (int i = 1; i < entry.Count; i++)
                {
                    dict[key].Add(entry[i]);
                }

                inputLine = Console.ReadLine();
            }

            var filter = Console.ReadLine().Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            

            foreach (var pair in dict)
            {
                var key = pair.Key;
                var val = pair.Value;

                var counter = 0;
                
                foreach (var word in filter)
                {
                    if (val.Contains(word))
                    {
                        counter++;
                    }
                }

                if (counter == filter.Count)
                {
                    Console.WriteLine($"{key} | #{string.Join(", #", val)}");
                    counter = 0;
                }

            }
        }
    }
}
