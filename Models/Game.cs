namespace ChessApi.Models;

public class Game
{
    public Guid id { get; set; }
    public string? pgn { get; set; }
}