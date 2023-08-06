using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using PerfectlySphericalHousesInAVacuum;

var input = args;

List<Direction> directions = new();
var santa = new Santa();

for (int i = 0; i < input[0].Length; i++)
{
    var direction = new Direction(input[0][i]);
    santa.AddToTrip(direction.Coordinate);
}

var calculatedTrip = santa.CalculateAndGroupTrip()!;
var housesVisited = 0;

for (int i = 0; i < calculatedTrip!.Count; i++)
{
    var some = calculatedTrip[i];

    if (some.Count >= 1)
    {
        housesVisited++;
    }

    for (int j = 0; j < some.Count; j++)
    {
        System.Console.WriteLine(some[j]);
    }
}

System.Console.WriteLine(housesVisited);