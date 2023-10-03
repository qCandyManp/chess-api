using ChessApi.Services.Helpers;

namespace ChessApi.Services;

class GamePositionService
{
    private static readonly char[] fieldColumnMap = {'a','b','c','d','e','f','g','h'};

    public static string Encode(GameState state)
    {
        return "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
    }

    public static GameState Decode(string position)
    {
        string[] fenStringMap = position.Split(' ');

        Dictionary<string, Piece> field = new Dictionary<string, Piece>();
        string[] fenFieldRowStrings = fenStringMap[0].Split('/');
        for (int rowNumber = 1; rowNumber <= fenFieldRowStrings.Length; rowNumber++)
        {
            string? row = fenFieldRowStrings[rowNumber];
            foreach (char item in row)
            {
                if (Char.IsNumber(item))
                {
                    for (int i = 1; i <= (int) item; i++)
                    {
                        //TODO: Implement coordinate-name generation
                    }
                }
                else
                {
                    //TODO: Implement mapping for Piece-generation
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
        GameState state = Decode(position);

        return true;
    }
}