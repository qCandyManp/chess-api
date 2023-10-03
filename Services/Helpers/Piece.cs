namespace ChessApi.Services.Helpers;

abstract class Piece
{
    public char Color;
    public string Position;
    public string[] PossibleMoves;

    public Piece(char color, string position)
    {
        Color = color == 'w' ? 'w' : 'b';
        Position = position;
        PossibleMoves = CalcPossibleMoves(Position);
    }

    public abstract string[] CalcPossibleMoves(string position);
}
