using System;
using System.Reflection;

public static class StartUp
{
    public static void Main(string[] args)
    {
        var family = new Family();

        var numberOfPeople = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfPeople; i++)
        {
            var personInfo = Console.ReadLine()
                .Split(' ');
            var personName = personInfo[0];
            var personAge = int.Parse(personInfo[1]);

            var person = new Person(personName, personAge);
            family.AddMember(person);
        }

        var oldestPerson = family.GetOldestMember();
        Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        //
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
    }
}