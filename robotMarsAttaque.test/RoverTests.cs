using robotMarsAttaque;
using robotMarsAttaque.Class;

public class RoverTests
{
    [Fact]
    public void Rover_Moves_Forward()
    {
        var mars = new Planet(10, 10);
        var navigator = new Navigator(mars);
        var rover = new Rover(new Position(0, 0), Orientation.N, navigator);

        rover.ExecuteCommand(Command.Advance);

        Assert.Equal(0, rover.Position.X);
        Assert.Equal(1, rover.Position.Y);
    }

    [Fact]
    public void Rover_Moves_Backward()
    {
        var mars = new Planet(10, 10);
        var navigator = new Navigator(mars);
        var rover = new Rover(new Position(0, 1), Orientation.N, navigator);

        rover.ExecuteCommand(Command.Reverse);

        Assert.Equal(0, rover.Position.X);
        Assert.Equal(0, rover.Position.Y);
    }

    [Fact]
    public void Rover_Turns_Left()
    {
        var mars = new Planet(10, 10);
        var navigator = new Navigator(mars);
        var rover = new Rover(new Position(0, 0), Orientation.N, navigator);

        rover.ExecuteCommand(Command.TurnLeft);

        Assert.Equal(Orientation.W, rover.Orientation);
    }

    [Fact]
    public void Rover_Turns_Right()
    {
        var mars = new Planet(10, 10);
        var navigator = new Navigator(mars);
        var rover = new Rover(new Position(0, 0), Orientation.N, navigator);

        rover.ExecuteCommand(Command.TurnRight);

        Assert.Equal(Orientation.E, rover.Orientation);
    }

    [Fact]
    public void Rover_Stops_For_Obstacle()
    {
        var mars = new Planet(10, 10);
        mars.AddObstacle(new Obstacle(0, 1));
        var navigator = new Navigator(mars);
        var rover = new Rover(new Position(0, 0), Orientation.N, navigator);

        rover.ExecuteCommand(Command.Advance);

        Assert.Equal(0, rover.Position.X);
        Assert.Equal(0, rover.Position.Y);
    }

    [Fact]
    public void Planet_Adjusts_Position()
    {
        var mars = new Planet(10, 10);
        var adjustedPosition = mars.AdjustPosition(new Position(-1, -1));

        Assert.Equal(9, adjustedPosition.X);
        Assert.Equal(9, adjustedPosition.Y);
    }
}

