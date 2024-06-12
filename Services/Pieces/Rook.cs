using ChessApi.Services.Helpers;

namespace ChessApi.Services.Pieces
{
    public class Rook : Piece
    {
        public new char Color { get; }
        public new GameState GameState { get; }

        public Rook(GameState gameState, char color) : base(gameState, color)
        {
            GameState = gameState;
            Color = color;
        }

        public override Coordinate[] GetPossibleMoves()
        {
            return new Coordinate[] { };
        }

        public override bool CanMoveTo(Coordinate destination)
        {
            return true;
        }

        public override void MoveTo(Coordinate destination)
        {
        }
    }
}