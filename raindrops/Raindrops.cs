public static class Raindrops
{
    public static string Convert(int number)
    {
        var conversion = string.Empty;

        if(number % 3 == 0)
        {
            conversion += "Pling";
        }

        if(number % 5 == 0)
        {
            conversion += "Plang";
        }

        if(number % 7 == 0)
        {
            conversion += "Plong";
        }

        return string.IsNullOrEmpty(conversion) ? number.ToString() : conversion;
    }
}