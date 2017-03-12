using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            var allRegions = new Dictionary<string, HashSet<int>>();

            var inputData = Console.ReadLine();

            while (inputData != "Aggregate")
            {
                var getRegion = inputData.Split(' ')[0];
                var getShells = Convert.ToInt32(inputData.Split(' ')[1]);

                if (!allRegions.ContainsKey(getRegion))
                {
                    allRegions[getRegion] = new HashSet<int>();
                }
                allRegions[getRegion].Add(getShells);
                

                inputData = Console.ReadLine();

            }

            foreach (var pars in allRegions)
            {
                var key = pars.Key;
                var val = pars.Value;
                var sumOfShells = val.Sum();
                var averageSum = val.Average();
                var bigShells = sumOfShells - averageSum;

                Console.WriteLine($"{key} -> {String.Join(", ", val)} ({bigShells:f0})");
            }
        }
    }
}
