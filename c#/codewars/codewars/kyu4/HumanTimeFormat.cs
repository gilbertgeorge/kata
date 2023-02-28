namespace codewars.kyu4;

// Your task in order to complete this Kata is to write a function which formats a duration,
// given as a number of seconds, in a human-friendly way.
// The function must accept a non-negative integer. If it is zero, it just returns "now".
// Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.
public static class HumanTimeFormat
{
    public static string formatDuration(int seconds)
    {
        var result = "";
        var years = 0;
        var days = 0;
        var hours = 0;
        var minutes = 0;
        
        if (seconds == 0)
        {
            return "now";
        }
        if (seconds >= 31536000)
        {
            years = seconds / 31536000;
            seconds = seconds % 31536000;
        }
        if (seconds >= 86400)
        {
            days = seconds / 86400;
            seconds = seconds % 86400;
        }
        if (seconds >= 3600)
        {
            hours = seconds / 3600;
            seconds = seconds % 3600;
        }
        if (seconds >= 60)
        {
            minutes = seconds / 60;
            seconds = seconds % 60;
        }
        
        if (years > 0)
        {
            result += PrintHelper("year", years) + ", ";
        }
        if (days > 0)
        {
            result += PrintHelper("day", days) + ", ";
        }
        if (hours > 0)
        {
            result += PrintHelper("hour", hours) + ", ";
        }
        if (minutes > 0)
        {
            result += PrintHelper("minute", minutes) + ", ";
        }
        if (seconds > 0)
        {
            result += PrintHelper("second", seconds);
        }
        
        if (result.EndsWith(", "))
        {
            result = result.Substring(0, result.Length - 2);
        }
        if (result.Contains(','))
        {
            result = result.Substring(0, result.LastIndexOf(", ")) + " and " +
                     result.Substring(result.LastIndexOf(", ") + 2);
        }

        return result;
    }

    static string PrintHelper(string unit, int quantity)
    {
        var result = "";
        if (quantity == 1)
        {
            result = $"{quantity} {unit}";
        }
        else if (quantity > 1)
        {
            result = $"{quantity} {unit}s";
        }

        return result;
    }
}