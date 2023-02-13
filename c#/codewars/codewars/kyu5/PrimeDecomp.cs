namespace codewars.kyu5;

public class PrimeDecomp
{
    public static string factors(int lst) 
    {
        List<int> factors = new List<int>();
        if (lst == 1)
            factors.Add(1);
        else
        {
            int factor = 2;
            int step = 2;
            while (factor * factor <= lst)
            {
                if (lst % factor == 0)
                {
                    factors.Add(factor);
                    lst /= factor;
                }
                else if (factor < 3)
                {
                    factor++;
                }
                else if (factor < 5)
                {
                    factor += 2;
                }
                else
                {
                    factor += step;
                    step = 6 - step;
                }
            }
            factors.Add(lst);
        }


        return PrintFactors(factors);
    }

    private static string PrintFactors(List<int> factors)
    {
        string result = "";
        int count = 1;
        for (int i = 0; i < factors.Count; i++)
        {
            if (i == factors.Count - 1)
            {
                if (count > 1)
                    result += $"({factors[i]}**{count})";
                else
                    result += $"({factors[i]})";
            }
            else if (factors[i] == factors[i + 1])
            {
                count++;
            }
            else
            {
                if (count > 1)
                    result += $"({factors[i]}**{count})";
                else
                    result += $"({factors[i]})";
                count = 1;
            }
        }
        return result;
    }
}