using System;
using System.Collections.Generic;
using System.Linq;

public class ParkingLot
{
    public static void Main(string[] args)
    {
        var carsInParkingLot = new SortedSet<string>();

        while(true)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if(input[0] == "END")
            {
                break;
            }
            else if(input[0] == "IN")
            {
                carsInParkingLot.Add(input[1]);
            }
            else if(input[0] == "OUT")
            {
                carsInParkingLot.Remove(input[1]);
            }
        }

        foreach(string str in carsInParkingLot)
        {
            Console.WriteLine(str);
        }
    }
}