namespace codewars.kyu5;

public static class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        int max = (int)Math.Sqrt(n);
        int temp = n;
        int j = 0;
        for(int i = 2; i <= max; i++) 
        {
            while(temp % i == 0 && temp > 1) 
            {
                temp /= i;
                j++;
            }

            if (temp == 1) return (i, j);
            temp = n;
            j = 0;
        }
        
        return null;
    }
}