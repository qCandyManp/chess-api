namespace ChessApi.Services.Helpers;

class GameState
{
    public Dictionary<string, Piece> Field;

    public GameState(string position)
    {
        Field = new Dictionary<string, Piece>();
    }
}