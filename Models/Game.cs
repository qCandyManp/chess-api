namespace ChessApi.Models;

public class Game
{
    public Guid Id { get; set; }
    public string? Position { get; set; } // FEN-notation
    public string? History { get; set; } // PGN-notation

    public Game()
    {
        Position = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
    }
}