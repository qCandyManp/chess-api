using ChessApi.Services.Helpers;

namespace ChessApi.Services;

class GamePositionService
{
    public static string Encode(GameState state)
    {
        return "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
    }

    public static bool ValidateMove(string position, string move)
    {
        GameState state = new GameState(position);

        return true;
    }
}