namespace ChessApi.Services.Helpers;

class King : Piece
{
    public King(char color, string position) : base(color, position) {}

    public override string[] CalcPossibleMoves(string position)
    {
        string[] possibleMoves = {};
        return possibleMoves;
    }
}