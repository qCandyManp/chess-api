using ChessApi.Models;
using ChessApi.Services.Pieces;

namespace ChessApi.Services;

class GamePositionService
{
    private static readonly char[] fieldColumnMap = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

    public static string Encode(GameState state)
    {
        return GetPositionFromPieces(state.Pieces.ToArray());
    }

    public static GameState Decode(string position)
    {
        IPiece[] pieces = GetPiecesFromPosition(position);

        return new GameState(pieces);
    }

    public static GameState Decode(string position)
    {
        string[] fenStringMap = position.Split(' ');

        Dictionary<string, Piece?> field = new Dictionary<string, Piece?>();
        string[] fenFieldRowStrings = fenStringMap[0].Split('/');
        for (int rowNumber = fenFieldRowStrings.Length; rowNumber > 0; rowNumber--)
        {
            string? row = fenFieldRowStrings[rowNumber];
            int i = 1;
            foreach (char item in row)
            {
                string coordinate = $"{fieldColumnMap[i]}{rowNumber}";
                if (Char.IsNumber(item))
                {
                    for (int j = 0; j < (int)item; j++)
                    {
                        field.Add(coordinate, null);
                        i++;
                    }
                }
                else
                {
                    switch (item)
                    {
                        case 'R':
                            field.Add(coordinate, new Rook('w', coordinate));
                            break;
                        case 'N':
                            field.Add(coordinate, new Knight('w', coordinate));
                            break;
                        case 'B':
                            field.Add(coordinate, new Bishop('w', coordinate));
                            break;
                        case 'Q':
                            field.Add(coordinate, new Queen('w', coordinate));
                            break;
                        case 'K':
                            field.Add(coordinate, new King('w', coordinate));
                            break;
                        case 'P':
                            field.Add(coordinate, new Pawn('w', coordinate));
                            break;
                        case 'r':
                            field.Add(coordinate, new Rook('b', coordinate));
                            break;
                        case 'n':
                            field.Add(coordinate, new Knight('b', coordinate));
                            break;
                        case 'b':
                            field.Add(coordinate, new Bishop('b', coordinate));
                            break;
                        case 'q':
                            field.Add(coordinate, new Queen('b', coordinate));
                            break;
                        case 'k':
                            field.Add(coordinate, new King('b', coordinate));
                            break;
                        case 'p':
                            field.Add(coordinate, new Pawn('b', coordinate));
                            break;
                    }
                    i++;
                }
            }
        }

        return new GameState(
            field,
            fenStringMap[1].ToCharArray()[0],
            fenStringMap[2],
            fenStringMap[3],
            Int32.Parse(fenStringMap[4]),
            Int32.Parse(fenStringMap[5])
        );
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