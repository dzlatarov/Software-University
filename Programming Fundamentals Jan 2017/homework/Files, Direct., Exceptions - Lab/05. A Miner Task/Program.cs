
namespace _03.A_Miner_Task
{
    using System.Collections.Generic;
    using System.IO;

    public class MinerTask
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> input = new Dictionary<string, int>();

            string[] inputTxt = File.ReadAllLines("input.txt");
            int i = 0;
            while (true)
            {
                string keyName = inputTxt[i];
                if (keyName == "stop")
                {
                    break;
                }
                else if (input.ContainsKey(keyName))
                {
                    input[keyName] += int.Parse(inputTxt[i + 1]);
                }
                else
                {
                    input[keyName] = int.Parse(inputTxt[i + 1]);
                }

                i += 2;
            }

            List<string> output = new List<string>();
            foreach (KeyValuePair<string, int> kvp in input)
            {
                output.Add($"{kvp.Key} -> {kvp.Value}");
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}