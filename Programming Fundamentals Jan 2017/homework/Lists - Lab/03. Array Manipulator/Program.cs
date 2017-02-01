namespace _03.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> command = Console.ReadLine().Split(' ').ToList();

            List<int> result = new List<int>();
            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        Add(numbers, command);
                        break;

                    case "addMany":
                        AddMany(numbers, command);
                        break;

                    case "contains":
                        result.Add(Contains(numbers, command));
                        break;

                    case "remove":
                        Remove(numbers, command);
                        break;

                    case "sumPairs":
                        SumPairs(numbers, command);
                        break;

                    case "shift":
                        Shift(numbers, command);
                        break;
                }

                command = Console.ReadLine().Split(' ').ToList();
            }

            command.Clear();

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static int Contains(List<int> numbers, List<string> command)
        {
            int result = -1;
            if (numbers.Contains(Convert.ToInt32(command[1])))
            {
                result = numbers.IndexOf(Convert.ToInt32(command[1]));
            }

            return result;
        }

        public static List<int> Add(List<int> numbers, List<string> command)
        {
            numbers.Insert(Convert.ToInt32(command[1]), Convert.ToInt32(command[2]));
            return numbers;
        }

        public static List<int> AddMany(List<int> numbers, List<string> command)
        {
            List<int> addNumbers = new List<int>();
            for (int i = 2; i < command.Count; i++)
            {
                addNumbers.Add(Convert.ToInt32(command[i]));
            }

            numbers.InsertRange(Convert.ToInt32(command[1]), addNumbers);

            return numbers;
        }

        public static List<int> Remove(List<int> numbers, List<string> command)
        {
            numbers.RemoveAt(Convert.ToInt32(command[1]));

            return numbers;
        }

        public static List<int> SumPairs(List<int> numbers, List<string> command)
        {
            List<int> summedPairs = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i += 2)
            {
                summedPairs.Add(numbers[i] + numbers[i + 1]);
            }

            if (numbers.Count % 2 != 0)
            {
                summedPairs.Add(numbers.Last());
            }

            numbers.Clear();
            numbers.AddRange(summedPairs);
            return numbers;
        }

        public static List<int> Shift(List<int> numbers, List<string> command)
        {
            int shiftedValue = Convert.ToInt32(command[1]) % numbers.Count;
            List<int> shiftedNumbers = numbers.Take(shiftedValue).ToList();
            numbers.RemoveRange(0, shiftedValue);
            numbers.AddRange(shiftedNumbers);

            return numbers;
        }
    }
}