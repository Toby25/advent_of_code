using System;
using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;
using System.Text.Json;
using IWasToldThereWouldBeNoMath;

var sizes = args;
Int64 totalSA = 0;
Int64 totalRibbon = 0;

for (int i = 0; i < sizes.Length; i++)
{
    var dimensions = sizes[i].Split("x");
    var size = new Size(int.Parse(dimensions[0]), int.Parse(dimensions[1]), int.Parse(dimensions[2]));
    System.Console.WriteLine("Dimensions: {0}\tTotal SA: {1}\tTotal Ribbon: {2}", size.ToString(), size.TotalSurfaceArea, size.TotalRibbonLength);
    System.Console.WriteLine("{0} {1}x{2}x{3} = {4}", size.RibbonLength, size.Length, size.Width, size.Height, size.BowLength);
    totalSA += size.TotalSurfaceArea;
    totalRibbon += size.TotalRibbonLength;
    System.Console.WriteLine("{0} {1}", totalSA, totalRibbon);
}

// void Test()
// {
//     var d = "5x6x7";

//     var dimensions = d.Split("x");
//     var size = new Size(int.Parse(dimensions[0]), int.Parse(dimensions[1]), int.Parse(dimensions[2]));
//     System.Console.WriteLine("Dimensions: {0}\tTotal SA: {1}", size.ToString(), size.TotalSurfaceArea);
//     totalSA += size.TotalSurfaceArea;
//     totalRibbon += size.TotalRibbonLength;
//     System.Console.WriteLine("{0} {1}", totalSA, totalRibbon);

//     return;
// }

// Test();