using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public static class StudentsRepository
{
    public static bool isDataInitialized = false;
    private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

    public static void InitializeData()
    {
        if (!isDataInitialized)
        {
            OutputWriter.WriteMessageOnNewLine("Reading data...");
            studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
            ReadData();
        }
        else
        {
            OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitializedException);
        }
    }

    private static void ReadData()
    {
        string pattern = @"([A-Z][a-zA-Z#+]*_[A-Z][a-z]{2}_\d{4})\s+([A-Z][a-z]{0,3}\d{2}\d{2,4})\s+(\d+)";
        Regex rgx = new Regex(pattern);

        string line = Console.ReadLine();
        string[] allInputLines = File.ReadAllLines(line);
        

        while(!string.IsNullOrEmpty(line) && rgx.IsMatch(allInputLines[]))
        {
            string[] tokens = line.Split( ' ' );
            string course = tokens[0];
            string student = tokens[1];
            int mark = int.Parse(tokens[2]);

            if(!studentsByCourse.ContainsKey(course))
            {
                studentsByCourse.Add(course, new Dictionary<string, List<int>>());
            }

            if(!studentsByCourse[course].ContainsKey(student))
            {
                studentsByCourse[course].Add(student, new List<int>());
            }

            studentsByCourse[course][student].Add(mark);

            line = Console.ReadLine();
        }
        
        isDataInitialized = true;
        OutputWriter.WriteMessageOnNewLine("Data read!");
    }

    private static bool IsQueryForCoursePossible(string courseName)
    {
        if(isDataInitialized)
        {
            if (studentsByCourse.ContainsKey(courseName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
            }
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
        }

        return false;
    }

    public static bool IsQueryForStudentPossible(string courseName, string studentUserName)
    {
        if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
        {
            return true;
        }
        else
        {
            OutputWriter.DisplayException(ExceptionMessages.InexsistingStudentInDataBase);
        }

        return false;
    }

    public static void GetStudentScoreFromCourse(string courseName, string username)
    {
        if(IsQueryForStudentPossible(courseName, username))
        {
            OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
        }
    }

    public static void GetAllStudentsFromCourse(string courseName)
    {
        if(!IsQueryForCoursePossible(courseName))
        {
            OutputWriter.WriteMessageOnNewLine($"{courseName}:");
            foreach (var studentMarksEntry in studentsByCourse[courseName])
            {
                OutputWriter.PrintStudent(studentMarksEntry);
            }
        }
    }
}

