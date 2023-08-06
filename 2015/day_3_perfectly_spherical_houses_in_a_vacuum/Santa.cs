using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace PerfectlySphericalHousesInAVacuum;

public class Santa
{
    public List<Vector2>? Trip { get; set; } = new();

    public void AddToTrip(Vector2 point)
    {
        Trip!.Add(point);
    }

    public List<List<Vector2>>? CalculateAndGroupTrip()
    {
        var calculatedTrip = new List<Vector2>();

        for (int i = 0; i < Trip!.Count - 1; i++)
        {
            if (i == 0)
            {
                calculatedTrip.Add(Trip[i]);
            }
            else
            {
                calculatedTrip.Add(calculatedTrip[i - 1] + Trip[i]);
            }
        }

        var orderedTrip =
            calculatedTrip!
                .GroupBy(x => new Vector2(x.X, x.Y))
                .Select(x => x
                    .Select(y => new Vector2(y.X, y.Y))
                    .ToList())
                .ToList();

        return orderedTrip;
    }
}