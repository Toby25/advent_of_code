using System;
using System.Numerics;

namespace PerfectlySphericalHousesInAVacuum;

public class Direction
{
    public Orientation Orientation { get; set; }
    public Vector2 Coordinate { get; set; }

    public Direction(char orientation)
    {
        switch (orientation)
        {
            case '^':
                Orientation = Orientation.North;
                Coordinate = new Vector2(0, 1);
                break;
            case '>':
                Orientation = Orientation.East;
                Coordinate = new Vector2(1, 0);
                break;
            case 'v':
                Orientation = Orientation.South;
                Coordinate = new Vector2(0, -1);
                break;
            case '<':
                Orientation = Orientation.West;
                Coordinate = new Vector2(-1, 0);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(orientation), orientation, null);
        }
    }

    public override string ToString()
    {
        return $"Orientation: {Orientation}\tCoordinates: {Coordinate}";
    }
}

public enum Orientation
{
    North,
    South,
    West,
    East
}