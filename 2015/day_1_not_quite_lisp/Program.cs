
using System;
using NotQuiteLisp;

if (args[0] == "part1")
{
    var testInput = args[1];

    var startDate = DateTime.Now;
    var answer = testInput.GetFloor();
    var endDate = DateTime.Now;

    System.Console.WriteLine(answer);
    System.Console.WriteLine("It took {0}", endDate - startDate);
}
else if (args[0] == "part2")
{
    var testInput = args[1];

    var startDate = DateTime.Now;
    var answer = testInput.FirstInstanceOfBasement();
    var endDate = DateTime.Now;

    System.Console.WriteLine("Final: {0} Index: {1}", answer[0], answer[1]);
    System.Console.WriteLine("It took {0}", endDate - startDate);
}