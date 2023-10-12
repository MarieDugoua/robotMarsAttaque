public void Reverse()
{
    switch (Orientation)
    {
        case Orientation.N:
            Position.Y--;
            break;
        case Orientation.E:
            Position.X--;
            break;
        case Orientation.S:
            Position.Y++;
            break;
        case Orientation.W:
            Position.X++;
            break;
    }
    AdjustForTorus();
}

public void TurnLeft()
{
    Orientation = (Orientation)(((int)Orientation + 3) % 4);
}

public void TurnRight()
{
    Orientation = (Orientation)(((int)Orientation + 1) % 4);
}

// Gestion toro�dale
private void AdjustForTorus()
{
    if (Position.X < 0)
        Position.X = _planetWidth - 1;
    else if (Position.X >= _planetWidth)
        Position.X = 0;

    if (Position.Y < 0)
        Position.Y = _planetHeight - 1;
    else if (Position.Y >= _planetHeight)
        Position.Y = 0;
}

public override string ToString()
{
    return $"Position: ({Position.X}, {Position.Y}), Orientation: {Orientation}";
}
}