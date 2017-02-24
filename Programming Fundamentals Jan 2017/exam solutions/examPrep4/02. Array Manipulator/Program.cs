namespace _02.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayManipulator
    {
        public static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", array)}]");
                    break;
                }
                else if (command[0] == "max")
                {
                    Max(array, command);
                }
                else if (command[0] == "min")
                {
                    Min(array, command);
                }
                else if (command[0] == "first")
                {
                    First(array, command);
                }
                else if (command[0] == "last")
                {
                    Last(array, command);
                }
                else if (command[0] == "exchange")
                {
                    Exchange(array, command);
                }
            }
        }

        public static void Max(List<int> array, string[] command)
        {
            if (command[1] == "odd" && array.Count(x => x % 2 != 0) > 0)
            {
                Console.WriteLine(array.LastIndexOf(array.Where(x => x % 2 != 0).Max()));
            }
            else if (command[1] == "even" && array.Count(x => x % 2 == 0) > 0)
            {
                Console.WriteLine(array.LastIndexOf(array.Where(x => x % 2 == 0).Max()));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        public static void Min(List<int> array, string[] command)
        {
            if (command[1] == "odd" && array.Count(x => x % 2 != 0) > 0)
            {
                Console.WriteLine(array.LastIndexOf(array.Where(x => x % 2 != 0).Min()));
            }
            else if (command[1] == "even" && array.Count(x => x % 2 == 0) > 0)
            {
                Console.WriteLine(array.LastIndexOf(array.Where(x => x % 2 == 0).Min()));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        public static List<int> Exchange(List<int> array, string[] command)
        {
            int count = Convert.ToInt32(command[1]);
            if (count < 0 || count > array.Count - 1)
            {
                Console.WriteLine("Invalid index");
                return array;
            }
            else
            {
  
                List<int> arrayFirstSplit = array.Take(count + 1).ToList();
                
                for(int i = 0; i <= count; i++)
                {
                    array.RemoveAt(0);
                }
                array.AddRange(arrayFirstSplit);

                return array;
            }
        }

        public static void First(List<int> array, string[] command)
        {
            int count = Convert.ToInt32(command[1]);
            string oddEven = command[2];

            List<int> firstList = new List<int>();
            if (count < 0 || count > array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int counter = 0;
                if (oddEven == "odd")
                {
                    foreach (int integer in array.Where(x => x % 2 != 0))
                    {
                        firstList.Add(integer);
                        counter++;

                        if (counter == count)
                        {
                            break;
                        }
                    }
                }
                if (oddEven == "even")
                {
                    foreach (int integer in array.Where(x => x % 2 == 0))
                    {
                        firstList.Add(integer);
                        counter++;

                        if (counter == count)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine($"[{string.Join(", ", firstList)}]");
            }
        }

        public static void Last(List<int> array, string[] command)
        {
            int count = Convert.ToInt32(command[1]);
            string oddEven = command[2];
          
            List<int> firstList = new List<int>();
            if (count < 0 || count > array.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                array.Reverse();
                int counter = 0;
                if (oddEven == "odd")
                {
                    foreach (int integer in array.Where(x => x % 2 != 0))
                    {
                        firstList.Add(integer);
                        counter++;

                        if (counter == count)
                        {
                            break;
                        }
                    }
                }
                if (oddEven == "even")
                {
                    foreach (int integer in array.Where(x => x % 2 == 0))
                    {
                        firstList.Add(integer);
                        counter++;

                        if (counter == count)
                        {
                            break;
                        }
                    }
                }

                firstList.Reverse();
                array.Reverse();
                Console.WriteLine($"[{string.Join(", ", firstList)}]");
            }
        }
    }
}