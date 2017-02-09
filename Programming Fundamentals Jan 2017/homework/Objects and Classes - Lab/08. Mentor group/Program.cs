namespace _08.Mentor_group
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;

    public class MentorGroup
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Students> students = new Dictionary<string, Students>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', ',').ToArray();

                if (string.Join(" ", input) == "end of dates")
                {
                    break;
                }
                else
                {
                    string name = input[0];
                    List<DateTime> dates = new List<DateTime>();
                    for (int i = 1; i < input.Length; i++)
                    {
                        dates.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }

                    if (!students.ContainsKey(name))
                    {
                        students[name] = new Students
                        {
                            Name = name,
                            DatesAttended = dates
                        };
                    }
                    else
                    {
                        students[name].DatesAttended.AddRange(dates);
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();

                if (string.Join(" ", input) == "end of comments")
                {
                    break;
                }
                else
                {
                    string name = input[0];
                    string comment = input[1];

                    if (students.ContainsKey(name))
                    {
                        if (students[name].Comments == null)
                        {
                            List<string> comments = new List<string>();
                            comments.Add(comment);
                            students[name].Comments = comments;
                        }
                        else
                        {
                            students[name].Comments.Add(comment);
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, Students> kvp in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine("Comments:");
                if (!(kvp.Value.Comments == null))
                {
                    foreach (var comment in kvp.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in kvp.Value.DatesAttended.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }
    }
}