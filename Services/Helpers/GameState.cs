namespace ChessApi.Services.Helpers;

class GameState
{
    public Dictionary<string, Piece?> Field;
    public char MoveRight;
    public string CastlingRights;
    public string EnPassant;
    public int Plies;
    public int Moves;

    public GameState(
        Dictionary<string, Piece?> field,
        char moveRight,
        string castlingRights,
        string enPassant,
        int plies,
        int moves
    )
    {
        Field = field;
        MoveRight = moveRight;
        CastlingRights = castlingRights;
        EnPassant = enPassant;
        Plies = plies;
        Moves = moves;
    }
}