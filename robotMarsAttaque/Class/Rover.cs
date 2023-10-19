using System;
namespace robotMarsAttaque.Class;

public class Rover
{
    public Position Position { get; private set; }
    public Orientation Orientation { get; private set; }

    private readonly Navigator _navigator;

    public Rover(Position initialPosition, Orientation orientation, Navigator navigator)
    {
        Position = initialPosition;
        Orientation = orientation;
        _navigator = navigator;
    }

    public void Advance()
    {
        Position = _navigator.Move(Position, Orientation);
    }

    public void Reverse()
    {
        Position = _navigator.Move(Position, Orientation, true);
    }

    // 90° to the left
    public void TurnLeft()
    {
        Orientation = (Orientation)(((int)Orientation + 3) % 4);
    }

    // 90° to the right
    public void TurnRight()
    {
        Orientation = (Orientation)(((int)Orientation + 1) % 4);
    }

    public override string ToString()
    {
        return $"Position: ({Position.X}, {Position.Y}), Orientation: {Orientation}";
    }
}

