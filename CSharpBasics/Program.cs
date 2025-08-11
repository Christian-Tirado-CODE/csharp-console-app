namespace CSharpBasics;

public readonly struct PictureFrame
{
    public PictureFrame(int width, int length, string shape, string color, string mountingType, string frameType)
    {
        Width = width;
        Length = length;
        Shape = shape;
        Color = color;
        MountingType = mountingType;
        FrameType = frameType;


    }

    public int Width { get; init; }
    public int Length { get; init; }
    public string Shape { get; init; }
    public string Color { get; init; }
    public string MountingType { get; init; }
    public string FrameType { get; init; }

    public override string ToString() => $"Picture Frame: Dimensions={Length} X {Width}, Shape={Shape}, Color={Color}, MountingType={MountingType}, FrameType={FrameType}";

    }  
class Program
{
    static void Main(string[] args)
    {
        PictureFrame pf = new(8, 10, "Rectangular", "Black", "Wall mount", "Collage picture frame");
        Console.WriteLine(pf.ToString());

    }
}
