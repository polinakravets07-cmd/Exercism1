public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;

        foreach (char letter in input.ToUpper())
        {
            if ("AEIOULNRST".Contains(letter))
                score += 1;
            else if ("DG".Contains(letter))
                score += 2;
            else if ("BCMP".Contains(letter))
                score += 3;
            else if ("FHVWY".Contains(letter))
                score += 4;
            else if (letter == 'K')
                score += 5;
            else if ("JX".Contains(letter))
                score += 8;
            else if ("QZ".Contains(letter))
                score += 10;
        }
        return score;
    }
}