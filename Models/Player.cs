namespace ChessApi.Models;

public class Player
{
    public Guid id { get; set; }
    public string? name { get; set; }
    public string? email { get; set; }
    public string? password { get; set; }
}