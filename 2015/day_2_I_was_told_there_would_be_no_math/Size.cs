using System.Linq;

namespace IWasToldThereWouldBeNoMath;

public class Size
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    #region Part1
    public int SmallestSize
    {
        get
        {
            return new[] { LengthWidth, LengthHeight, WidthHeight }.Min();
        }
    }
    public int LengthWidth
    {
        get
        {
            return Length * Width;
        }
    }
    public int LengthHeight
    {
        get
        {
            return Length * Height;
        }
    }
    public int WidthHeight
    {
        get
        {
            return Width * Height;
        }
    }
    public int SurfaceArea
    {
        get
        {
            return 2 * LengthHeight + 2 * LengthWidth + 2 * WidthHeight;
        }
    }
    public int TotalSurfaceArea
    {
        get
        {
            return SurfaceArea + SmallestSize;
        }
    }
    #endregion

    #region Part2
    public int SmallestDimension
    {
        get
        {
            return new[] { Length, Width, Height }.Min();
        }
    }
    public int SecondSmallestDimension
    {
        get
        {
            return new[] { Length, Width, Height }.OrderByDescending(x => x).Skip(1).First();
        }
    }
    public int RibbonLength
    {
        get
        {
            return SmallestDimension + SmallestDimension + SecondSmallestDimension + SecondSmallestDimension;
        }
    }

    public int BowLength
    {
        get
        {
            return Length * Width * Height;
        }
    }

    public int TotalRibbonLength
    {
        get
        {
            return RibbonLength + BowLength;
        }
    }
    #endregion

    public Size(int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public override string ToString()
    {
        return $"Length:{Length} Width:{Width} Height:{Height}";
    }
}