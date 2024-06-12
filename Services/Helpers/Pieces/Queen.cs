namespace ChessApi.Services.Helpers;

class Queen : Piece
{
    public Queen(char color, string position) : base(color, position) {}

    public override string[] CalcPossibleMoves(string position)
    {
        string[] possibleMoves = {};
        return possibleMoves;
    }
}