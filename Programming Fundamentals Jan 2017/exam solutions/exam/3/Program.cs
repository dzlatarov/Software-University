namespace _3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            List<long> surviningBees = new List<long>();

            long hornetsSum = hornets.Sum();
            int index = 0;
            for(int i = 0; i < beehives.Count; i++)
            {
                if(index > hornets.Count - 1)
                {
                    break;
                }
                else if(hornetsSum > beehives[i])
                {

                }
                else if(hornetsSum == beehives[i])
                {
                    hornetsSum -= hornets[index];
                    index++;
                }
                else if(hornetsSum < beehives[i])
                {
                    surviningBees.Add(beehives[i] - hornetsSum);
                    hornetsSum -= hornets[index];
                    index++;
                }
            }

            if(surviningBees.Count > 0)
            {
                Console.WriteLine(string.Join(" ", surviningBees));
            }   
            else
            {
                for(int i = index; i < hornets.Count; i++)
                {
                    Console.Write($"{hornets[i]} ");
                }
            }
               
        }
    }
}