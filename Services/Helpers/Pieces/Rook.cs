namespace ChessApi.Services.Helpers;

class Rook : Piece
{
    public Rook(char color, string position) : base(color, position) {}

    public override string[] CalcPossibleMoves(string position)
    {
        string[] possibleMoves = {};
        return possibleMoves;
    }
}