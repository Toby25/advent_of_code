using System;

var testInput = args[0];

var startDate = DateTime.Now;
var answer = testInput.GetFloor();
var endDate = DateTime.Now;

System.Console.WriteLine(answer);
System.Console.WriteLine("It took {0}", endDate - startDate);

public static class Extension
{
    public static int GetFloor(this string? input)
    {
        int final = 0;

        for (int i = 0; i < input!.Length; i++)
        {
            if (input[i] == '(')
            {
                final += 1;
            }
            else if (input[i] == ')')
            {
                final -= 1;
            }
        }

        return final;
    }
}