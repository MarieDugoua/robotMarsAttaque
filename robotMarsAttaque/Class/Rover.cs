namespace robotMarsAttaque.Class
{
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

        public void ExecuteCommand(Command command)
        {
            switch (command)
            {
                case Command.Advance:
                    Position = _navigator.Move(Position, Orientation);
                    break;
                case Command.Reverse:
                    Position = _navigator.Move(Position, Orientation, true);
                    break;
                case Command.TurnLeft:
                    TurnLeft();
                    break;
                case Command.TurnRight:
                    TurnRight();
                    break;
            }
        }

        private void TurnLeft()
        {
            Orientation = (Orientation)(((int)Orientation + 3) % 4);
        }

        private void TurnRight()
        {
            Orientation = (Orientation)(((int)Orientation + 1) % 4);
        }

        public override string ToString()
        {
            return $"Position: ({Position.X}, {Position.Y}), Orientation: {Orientation}";
        }

        public string ExecuteCommands(IEnumerable<Command> commands)
        {
            foreach (var command in commands)
            {
                var previousPosition = new Position(Position.X, Position.Y);
                ExecuteCommand(command);
                if (Position.Equals(previousPosition) && command == Command.Advance)
                {
                    return $"Obstacle encountered at ({Position.X}, {Position.Y}). Stopping execution.";
                }
            }
            return $"Executed all commands. Current state: {ToString()}";
        }
    }
}
