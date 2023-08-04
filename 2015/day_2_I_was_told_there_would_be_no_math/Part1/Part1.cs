using System.Linq;

namespace IWasToldThereWouldBeNoMath;

public class Size
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
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

    public Size(int length, int width, int height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public override string ToString()
    {
        return $"Length:{Length} Width:{Width} Heigth:{Height} LengthWidth:{LengthWidth} LengthHeight:{LengthHeight} WidthHeight:{WidthHeight}";
    }
}