using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using PerfectlySphericalHousesInAVacuum;

var input = args;

List<Direction> directions = new();
var santa = new Santa();
var robotSanta = new Santa();

for (int i = 0; i < input[0].Length; i++)
{
    var direction = new Direction(input[0][i]);
    if (i % 2 == 0)
    {
        robotSanta.AddToTrip(direction.Coordinate);
    }
    else
    {
        santa.AddToTrip(direction.Coordinate);
    }
}

var calculatedSantaTrip = santa.CalculateAndGroupTrip()!;
var calculatedRobotSantaTrip = robotSanta.CalculateAndGroupTrip()!;
var santaHousesVisited = 0;
var robotSantaHousesVisited = 0;

for (int i = 0; i < calculatedSantaTrip!.Count; i++)
{
    var some = calculatedSantaTrip[i];

    if (some.Count >= 1)
    {
        santaHousesVisited++;
    }

    for (int j = 0; j < some.Count; j++)
    {
        System.Console.WriteLine(some[j]);
    }
}

for (int i = 0; i < calculatedRobotSantaTrip!.Count; i++)
{
    var some = calculatedRobotSantaTrip[i];

    if (some.Count >= 1)
    {
        robotSantaHousesVisited++;
    }

    for (int j = 0; j < some.Count; j++)
    {
        System.Console.WriteLine(some[j]);
    }
}

System.Console.WriteLine(robotSantaHousesVisited);
System.Console.WriteLine(santaHousesVisited);