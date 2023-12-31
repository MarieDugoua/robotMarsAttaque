﻿using robotMarsAttaque.Rover;

// Planet Class: Represents the planet's grid and obstacles.
public class Planet
{
    public int Width { get; }
    public int Height { get; }
    private readonly List<Obstacle> _obstacles;

    public Planet(int width, int height, IEnumerable<Obstacle> obstacles = null)
    {
        Width = width;
        Height = height;
        _obstacles = obstacles?.ToList() ?? new List<Obstacle>();
    }

    public Position AdjustPosition(Position position)
    {
        int adjustedX = (position.X + Width) % Width;
        int adjustedY = (position.Y + Height) % Height;
        return new Position(adjustedX, adjustedY);
    }

    public bool HasObstacleAt(Position position)
    {
        return _obstacles.Any(o => o.Position.X == position.X && o.Position.Y == position.Y);
    }

    public void AddObstacle(Obstacle obstacle)
    {
        _obstacles.Add(obstacle);
    }
}
