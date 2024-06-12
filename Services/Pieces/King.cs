using ChessApi.Services.Helpers;

namespace ChessApi.Services.Pieces
{
    public class King : Piece
    {
        public new char Color { get; }
        public new GameState GameState { get; }

        public King(GameState gameState, char color) : base(gameState, color)
        {
            GameState = gameState;
            Color = color;
        }

        public override Coordinate[] GetPossibleMoves()
        {
            return new Coordinate[] { };
        }
    }
}