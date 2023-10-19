using robotMarsAttaque;
using robotMarsAttaque.Class;

// Initialisation de la planète et du navigateur
Planet mars = new Planet(10, 10);
Navigator navigator = new Navigator(mars);

// Initialisation du Rover avec une position, une orientation et le navigateur
Rover rover = new Rover(new Position(0, 0), Orientation.N, navigator);

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
