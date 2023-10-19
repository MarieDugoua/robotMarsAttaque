namespace robotMarsAttaque
{
    public class Obstacle
    {
        public Position Position { get; }

        public Obstacle(int x, int y)
        {
            Position = new Position(x, y);
        }
    }
}