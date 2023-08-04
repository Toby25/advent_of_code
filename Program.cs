using System;
using System.Net.WebSockets;
using System.Text.Json;
using IWasToldThereWouldBeNoMath;

var sizes = args;
Int64 totalSA = 0;

for (int i = 0; i < sizes.Length; i++)
{
    var dimensions = sizes[i].Split("x");
    var size = new Size(int.Parse(dimensions[0]), int.Parse(dimensions[1]), int.Parse(dimensions[2]));
    System.Console.WriteLine("Dimensions: {0}\tTotal SA: {1}", size.ToString(), size.TotalSurfaceArea);
    totalSA += size.TotalSurfaceArea;
    System.Console.WriteLine(totalSA);
}