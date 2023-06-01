namespace Problems.P3;
public class P3_Implementation
{
    private string _history;
    public P3_Implementation()
    {
        _history = "";
    }

    public int LengthOfLongestSubstring(string s)
    {
        var max = 0;
        var count = 0;

        foreach(var symbol in s)
        {
            if (HasSymbol(symbol))
            {
                UpdateHistory(symbol);
                if (count > max)
                {
                    max = count;
                }
                count = _history.Length;
            }

            AddSymbol(symbol);
            count++;
        }

        if (count > max)
        {
            max = count;
        }

        return max;
    }

    private bool HasSymbol(char symbol)
    {
        return _history.Contains(symbol);
    }

    private void UpdateHistory(char symbol)
    {
        var index = Array.IndexOf(_history.ToCharArray(), symbol);
        _history = _history.Remove(0, index + 1);
    }

    private void AddSymbol(char symbol)
    {
        _history = _history + symbol;
    }
}
