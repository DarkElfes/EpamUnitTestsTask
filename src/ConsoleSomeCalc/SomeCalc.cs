namespace ConsoleSomeCalc;

public static class SomeCalc
{
    public static int CountMaxUnequalConsecutiveCharacters(string? input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }

    public static int CountMaxConsecutiveEqualLetters(string? input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int maxCount = 0;
        int currentCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (!IsLatinLetter(input[i]))
            {
                currentCount = 0;
                continue;
            }

            if (i > 0 && input[i] == input[i - 1])
                currentCount++;
            else
                currentCount = 1;

            maxCount = Math.Max(maxCount, currentCount);
        }

        return maxCount;
    }

    public static int CountMaxConsecutiveEqualDigits(string? input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        int maxCount = 0;
        int currentCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (!char.IsDigit(input[i]))
            {
                currentCount = 0;
                continue;
            }

            if (i > 0 && input[i] == input[i - 1])
                currentCount++;
            else
                currentCount = 1;

            maxCount = Math.Max(maxCount, currentCount);
        }

        return maxCount;
    }

    private static bool IsLatinLetter(char c) =>
        (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
}
