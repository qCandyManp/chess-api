namespace ChessApi.Services.Helpers;

class Pawn : Piece
{
    public Pawn(char color, string position) : base(color, position) {}

    public override string[] CalcPossibleMoves(string position)
    {
        string[] possibleMoves = {};
        return possibleMoves;
    }
}