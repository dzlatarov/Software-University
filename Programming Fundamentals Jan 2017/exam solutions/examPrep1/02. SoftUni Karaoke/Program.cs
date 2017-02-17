namespace _02.SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaroke
    {
        public static void Main(string[] args)
        {
            string[] officialParticipantNames = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] officialSongNamesUntrimemd = Console.ReadLine().Split(new char[] { ',' }).ToArray();

            List<string> officialSongNames = new List<string>();

            foreach (string str in officialSongNamesUntrimemd)
            {
                officialSongNames.Add(str.Trim());
            }

            Dictionary<string, List<string>> participantAwards = new Dictionary<string, List<string>>();
            List<string> givenAwards = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "dawn")
                {
                    break;
                }
                else
                {
                    string[] inputSplit = input.Split(',').ToArray();

                    string participantName = inputSplit[0].Trim();
                    string songName = inputSplit[1].Trim();
                    string awardName = inputSplit[2].Trim();

                    if (officialParticipantNames.Contains(participantName) && officialSongNames.Contains(songName) && !givenAwards.Contains(awardName))
                    {
                        if (participantAwards.ContainsKey(participantName))
                        {
                            participantAwards[participantName].Add(awardName);
                        }
                        else
                        {

                            participantAwards[participantName] = new List<string>();
                            participantAwards[participantName].Add(awardName);
                        }

                        givenAwards.Add(awardName);
                    }
                }
            }


            if (participantAwards.Count() == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var kvp in participantAwards.OrderByDescending(x => participantAwards[x.Key].Count()).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {participantAwards[kvp.Key].Count()} awards");
                    foreach (string str in kvp.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{str}");
                    }
                }
            }
        }
    }
}