using ChessApi.Services.Pieces;

namespace ChessApi.Services;

public class GameState
{
    public List<IPiece> Pieces { get; set; }

    public GameState(IPiece[] pieces)
    {
        Pieces = new List<IPiece>(pieces);
    }
}