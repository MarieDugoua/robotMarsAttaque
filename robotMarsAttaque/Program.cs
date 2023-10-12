using robotMarsAttaque.Class;

var rover = new Rover(0, 0, Orientation.N, 10, 10);

rover.Advance();
Console.WriteLine(rover); // Position: (0, 1), Orientation: N

rover.TurnRight();
rover.Advance();
Console.WriteLine(rover); // Position: (1, 1), Orientation: E

rover.Reverse();
Console.WriteLine(rover); // Position: (0, 1), Orientation: E

rover.TurnLeft();
rover.Advance();
Console.WriteLine(rover); // Position: (0, 2), Orientation: N