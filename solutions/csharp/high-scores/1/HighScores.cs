public class HighScores
{
    private readonly List<int> list;

    public HighScores(List<int> list)
    {
        this.list = list;
    }

    public List<int> Scores()
    {
        return list;
    }

    public int Latest()
    {
        return list[list.Count - 1];
    }

    public int PersonalBest()
    {
        return list.Max();
    }

    public List<int> PersonalTopThree()
    {
        return list.OrderByDescending(score => score).Take(3).ToList();
    }
}