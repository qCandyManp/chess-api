
using ChessApi.Services;
using ChessApi.Services.Helpers;
using ChessApi.Services.Pieces;

public abstract class Piece : IPiece
{
    public GameState GameState { get; }
    public char Color { get; }

    GameState IPiece.GameState => throw new NotImplementedException();

    public Piece(GameState gameState, char color)
    {
        GameState = gameState;
        Color = color;
    }

    public abstract Coordinate[] GetPossibleMoves();

    public bool CanMoveTo(Coordinate destination)
    {
        return true;
    }

    public void MoveTo(Coordinate destination)
    {
        return;
    }
}