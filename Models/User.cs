namespace MinimalApiAuth.Models
{
  public class User
  {
    public int Id { get; set; }
    public string Username { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string Role { get; set; } = String.Empty;

  }
}
