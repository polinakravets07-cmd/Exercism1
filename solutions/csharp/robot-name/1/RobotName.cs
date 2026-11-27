public class Robot
{
    private static readonly HashSet<string> usedNames = new HashSet<string>();
    private string name = "";

    public string Name
    {
        get
        {
            if (name == "")
            {
                lock (usedNames)
                {
                    do
                    {
                        name = $"{(char)Random.Shared.Next('A', 'Z' + 1)}" +
                               $"{(char)Random.Shared.Next('A', 'Z' + 1)}" +
                               $"{Random.Shared.Next(100, 1000)}";
                    }
                    while (!usedNames.Add(name));
                }
            }

            return name;
        }
    }

    public void Reset()
    {
        name = "";
    }
}