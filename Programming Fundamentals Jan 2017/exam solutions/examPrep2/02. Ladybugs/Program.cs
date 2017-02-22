namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class LadyBugs
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] ladyBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (int ladyBug in ladyBugs)
            {
                if (ladyBug >= 0 && ladyBug <= field.Length - 1)
                {
                    field[ladyBug] = 1;
                }
            }

            while (true)
            {
                string[] token = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (token[0] == "end")
                {
                    break;
                }
                else
                {
                    int ladyBug = Convert.ToInt32(token[0]);
                    string direction = token[1];
                    int ladyBugStep = Convert.ToInt32(token[2]);

                    if (direction == "left")
                    {
                        int ladyBugNewIndex = ladyBug - ladyBugStep;
                        if (ladyBug >= 0 && ladyBug <= field.Length - 1)
                        {
                            if (field[ladyBug] != 0)
                            {
                                field[ladyBug] = 0;

                                while (true)
                                {
                                    if (ladyBugNewIndex < 0 || ladyBugNewIndex > field.Length - 1) 
                                    {
                                        break;
                                    }
                                    else if (field[ladyBugNewIndex] == 1)
                                    {
                                        if(ladyBugStep > 0)
                                        {
                                            ladyBugNewIndex -= ladyBugStep;
                                        }
                                        else if (ladyBugStep < 0)
                                        {
                                            ladyBugNewIndex += ladyBugStep;
                                        }
                                        else
                                        {
                                            field[ladyBugNewIndex] = 1;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        field[ladyBugNewIndex] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        int ladyBugNewIndex = ladyBug + ladyBugStep;
                        if (ladyBug >= 0 && ladyBug <= field.Length - 1)
                        {
                            if (field[ladyBug] != 0)
                            {
                                field[ladyBug] = 0;

                                while (true)
                                {
                                    if (ladyBugNewIndex < 0 || ladyBugNewIndex > field.Length - 1)
                                    {
                                        break;
                                    }
                                    else if (field[ladyBugNewIndex] == 1)
                                    {
                                        if (ladyBugStep > 0)
                                        {
                                            ladyBugNewIndex += ladyBugStep;
                                        }
                                        else if (ladyBugStep < 0)
                                        {
                                            ladyBugNewIndex -= ladyBugStep;
                                        }
                                        else
                                        {
                                            field[ladyBugNewIndex] = 1;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        field[ladyBugNewIndex] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}