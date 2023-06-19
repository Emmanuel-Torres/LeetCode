namespace Problems.P1732;

public class P1732_Implementation
{
    public int LargestAltitude(int[] gain)
    {
        var highest = 0;
        var currentAlt = 0;

        foreach(var i in gain)
        {
            currentAlt += i;
            if (currentAlt > highest)
            {
                highest = currentAlt;
            }
        }

        return highest;
    }
}