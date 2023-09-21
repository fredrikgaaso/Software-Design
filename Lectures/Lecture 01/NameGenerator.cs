namespace Lecture_01;

public abstract class NameGenerator
{
    private static readonly string[] FirstNames = { "Fredrik", "Jokubas", "Micheal", "Noah" };
    private static readonly string[] LastNames = { "Jan", "Per", "Aas", "Gru" };

    public static string GenerateName()
    {
        Random random = new();
        string firstName = FirstNames[random.Next(0, FirstNames.Length)];
        string lastName = LastNames[random.Next(0, LastNames.Length)];
        return $"{firstName} {lastName}";
    }
}