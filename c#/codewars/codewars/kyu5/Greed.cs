namespace codewars.kyu5;

public class Greed
{
    // Three 1's => 1000 points
    // Three 6's =>  600 points
    // Three 5's =>  500 points
    // Three 4's =>  400 points
    // Three 3's =>  300 points
    // Three 2's =>  200 points
    // One   1   =>  100 points
    // One   5   =>   50 point
    public static int Score(int[] dice)
    {
        var score = 0;
        var counts = new int[6];
        foreach (var die in dice)
        {
            counts[die - 1]++;
        }
        for (var i = 0; i < 6; i++)
        {
            if (counts[i] >= 3)
            {
                score += (i > 0) ? (i + 1) * 100 : 1000;
                counts[i] -= 3;
            }
        }
        score += counts[0] * 100;
        score += counts[4] * 50;
        
        return score;
    }
}