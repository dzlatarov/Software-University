using System;
using System.Reflection;

public static class StartUp
{
    public static void Main(string[] args)
    {
        Type personType = typeof(Person);
        FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);
    }   
}

