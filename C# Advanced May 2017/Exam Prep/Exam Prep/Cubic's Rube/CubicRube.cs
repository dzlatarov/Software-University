using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubic_s_Rube
{
    public class CubicsRube
    {
        public static void Main(string[] args)
        {
            var dimensions = int.Parse(Console.ReadLine());

            var cubiksRude = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Analyze")
                {
                    break;
                }

                var tokens = input
                    .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (tokens[0] < 0 || tokens[0] >= dimensions || tokens[1] < 0 || tokens[1] >= dimensions ||
                    tokens[2] < 0 || tokens[2] >= dimensions)
                {
                    continue;
                }

                var coordinates = $"{tokens[0]}{tokens[1]}{tokens[2]}";
                var add = tokens[3];

                if (!cubiksRude.ContainsKey(coordinates))
                {
                    cubiksRude.Add(coordinates, add);
                }
                else
                {
                    cubiksRude[coordinates] += add;
                }
            }

            Console.WriteLine(cubiksRude.Values.Sum());
            Console.WriteLine(Math.Pow(dimensions, 3) - cubiksRude.Count);
        }
    }
}
