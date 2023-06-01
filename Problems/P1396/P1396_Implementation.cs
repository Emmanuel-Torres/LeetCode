namespace Problems.P1396;

public class P1396_Implementation
{
    private readonly Dictionary<string, List<double>> _tripAverages;
    private List<(int id, string stationName, int t)> _trips;
    public P1396_Implementation()
    {
        _tripAverages = new();
        _trips = new();
    }

    public void CheckIn(int id, string stationName, int t)
    {
        _trips.Add((id, stationName, t));
    }

    public void CheckOut(int id, string stationName, int t)
    {
        var trip = _trips.FirstOrDefault(t => t.id == id);
        _trips = _trips.Where(t => t.id != id).ToList();

        var key = trip.stationName + "-" + stationName;
        var value = _tripAverages.GetValueOrDefault(key) ?? new();
        _tripAverages.Remove(key);

        value.Add(t - trip.t);

        _tripAverages.Add(key, value);
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        var value = _tripAverages.GetValueOrDefault(startStation + "-" + endStation) ?? new();
        double sum = 0;

        foreach (var n in value)
        {
            sum += n;
        }

        return sum / value.Count();
    }
}