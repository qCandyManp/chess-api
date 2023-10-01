namespace ChessApi.Models;

public class Game
{
    public Guid id { get; set; }
    public string? position { get; set; } // FEN-notation
    public string? history { get; set; } // PGN-notation

    public Game()
    {
        this.position = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
    }
}