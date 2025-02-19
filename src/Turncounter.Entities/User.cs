namespace Turncounter.Entities
{
    public class User
    {
        int IdUser { get; set; }   
        string Username { get; set; }
        string Password { get; set; }   
        IEnumerable<Character> Characters { get; set; }

    }
}
