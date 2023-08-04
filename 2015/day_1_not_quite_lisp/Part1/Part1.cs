namespace NotQuiteLisp;

public static class Part1
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