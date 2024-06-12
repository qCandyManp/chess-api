using ChessApi.Services.Helpers;

namespace ChessApi.Services.Pieces;

public interface IPiece
{
    public GameState GameState { get; }
    public char Color { get; }

    public Coordinate[] GetPossibleMoves();
    public bool CanMoveTo(Coordinate destination);
    public void MoveTo(Coordinate destination);
}
