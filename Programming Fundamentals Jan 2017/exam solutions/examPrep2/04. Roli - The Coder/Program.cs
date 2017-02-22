namespace _04.Roli___The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Event
    {
        public string EventName { get; set; }
        public List<string> Participants { get; set; }
    }

    public class RoliTheCoder
    {
        public static void Main()
        {
            Dictionary<string, Event> events = new Dictionary<string, Event>();
            while (true)
            {
            here:
                string[] token = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                if (string.Join(" ", token) == "Time for Code")
                {
                    break;
                }
                else
                {
                    string eventIndex = token[0];
                    string eventName;
                    List<string> participants = new List<string>();
     
                    if (token[1].StartsWith("#"))
                    {
                        eventName = token[1];
                    }
                    else
                    {
                        goto here;
                    }

                    for (int i = 2; i < token.Length; i++)
                    {
                        if (token[i].StartsWith("@"))
                        {
                            participants.Add(token[i]);
                        }
                    }

                    if (!events.ContainsKey(eventIndex))
                    {
                        Event eve = new Event
                        {
                            EventName = eventName,
                            Participants = participants
                        };

                        events[eventIndex] = eve;
                    }
                    else
                    {
                        if (events[eventIndex].EventName == eventName)
                        {
                            events[eventIndex].Participants.AddRange(participants);
                        }
                    }
                }
            }

            foreach (var kvp in events.OrderByDescending(x => x.Value.Participants.Count()).ThenBy(x => x.Value.EventName))
            {
                Console.WriteLine($"{kvp.Value.EventName.TrimStart('#')} - {kvp.Value.Participants.Distinct().Count()}");
                foreach (var participant in kvp.Value.Participants.Distinct().OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}