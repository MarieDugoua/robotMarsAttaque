using robotMarsAttaque;
using robotMarsAttaque.Class;

public class Navigator
{
    private readonly Planet _planet;

    public Navigator(Planet planet)
    {
        _planet = planet;
    }

    public Position Move(Position currentPosition, Orientation orientation, bool reverse = false)
    {
        switch (orientation)
        {
            case Orientation.N:
                currentPosition.Y += reverse ? -1 : 1;
                break;
            case Orientation.E:
                currentPosition.X += reverse ? -1 : 1;
                break;
            case Orientation.S:
                currentPosition.Y += reverse ? 1 : -1;
                break;
            case Orientation.W:
                currentPosition.X += reverse ? 1 : -1;
                break;
        }

        return _planet.AdjustPosition(currentPosition);
    }
}
