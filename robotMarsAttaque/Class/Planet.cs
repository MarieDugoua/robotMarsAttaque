using robotMarsAttaque;

public class Planet
{
    public int Width { get; }
    public int Height { get; }

    public Planet(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public Position AdjustPosition(Position position)
    {
        int adjustedX = (position.X + Width) % Width;
        int adjustedY = (position.Y + Height) % Height;

        return new Position(adjustedX, adjustedY);
    }
}
