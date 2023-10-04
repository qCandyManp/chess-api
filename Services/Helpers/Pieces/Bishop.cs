namespace ChessApi.Services.Helpers;

class Bishop : Piece
{
    public Bishop(char color, string position) : base(color, position) {}

    public override string[] CalcPossibleMoves(string position)
    {
        string[] possibleMoves = {};
        return possibleMoves;
    }
}