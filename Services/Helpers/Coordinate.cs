namespace ChessApi.Services.Helpers
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinate(string position)
        {
            X = position[0] - 'a';
            Y = position[1] - '1';
        }

        public override string ToString()
        {
            return $"{(char)('a' + X)}{Y + 1}";
        }
    }
}