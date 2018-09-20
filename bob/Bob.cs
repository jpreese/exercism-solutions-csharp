using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }

        if (statement.ToUpper() == statement && statement.Any(c => char.IsLetter(c)))
        {
            return "Whoa, chill out!";
        }

        if (statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}