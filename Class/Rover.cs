public class Rover
{
    public Position Position { get; private set; }
    public Orientation Orientation { get; private set; }

    // Taille de la planète
    private readonly int _planetWidth;
    private readonly int _planetHeight;

    public Rover(int x, int y, Orientation orientation, int planetWidth, int planetHeight)
    {
        Position = new Position(x, y);
        Orientation = orientation;
        _planetWidth = planetWidth;
        _planetHeight = planetHeight;
    }

    public void Advance()
    {
        switch (Orientation)
        {
            case Orientation.N:
                Position.Y++;
                break;
            case Orientation.E:
                Position.X++;
                break;
            case Orientation.S:
                Position.Y--;
                break;
            case Orientation.W:
                Position.X--;
                break;
        }
        AdjustForTorus();
    }