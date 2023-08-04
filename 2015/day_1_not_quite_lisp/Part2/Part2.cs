namespace NotQuiteLisp;

public static class Part2
{
    public static int[] FirstInstanceOfBasement(this string input)
    {
        if (input.Length < 1) return new[] { 0, 0 };

        var final = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                final += 1;
            }
            else if (input[i] == ')')
            {
                final -= 1;
            }

            if (final <= -1)
            {
                return new[] { final, i + 1 };
            }
        }

        return new[] { 0, 0 };
    }
}