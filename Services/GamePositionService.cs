using ChessApi.Models;
using ChessApi.Services.Pieces;

namespace ChessApi.Services;

class GamePositionService
{
    public static string Encode(GameState state)
    {
        return GetPositionFromPieces(state.Pieces.ToArray());
    }

    public static GameState Decode(string position)
    {
        IPiece[] pieces = GetPiecesFromPosition(position);

        return new GameState(pieces);
    }

    public static bool ValidateMove(string position, string move)
    {
        IPiece[] pieces = GetPiecesFromPosition(position);

        GameState state = new GameState(pieces);

        return true;
    }

    private static IPiece[] GetPiecesFromPosition(string position)
    {
        return new IPiece[]
        {};
    }

    private static string GetPositionFromPieces(IPiece[] pieces)
    {
        return "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
    }
}