using System.Collections.Generic;
using System.Linq;
using robotMarsAttaque.Class;

namespace robotMarsAttaque
{
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

        // Handling Rover Soucies interaction
        public string HandleRoverSouciesInteraction(Position position)
        {
            if (HasObstacleAt(position))
            {
                // This can be enhanced to include more detailed interaction.
                return $"Soucies Rover detected an obstacle at {position.X}, {position.Y}.";
            }
            return string.Empty;
        }

        // Refactor obstacle's interaction based on commands
        public string HandleObstacleInteractionWithCommand(Position position, Command command)
        {
            if (HasObstacleAt(position))
            {
                // Customize this based on your requirement. 
                // For instance, based on the command type, the interaction might differ.
                return $"Obstacle encountered during command {command} at position {position.X}, {position.Y}.";
            }
            return string.Empty;
        }
    }
}
