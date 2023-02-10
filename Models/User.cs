namespace POC_NET7.Models;

public class User
{
    public int UserId { get; set; }
    public string Firstname { get; set; } = "";
    public string Lastname { get; set; } = "";
    public int YearOfBirth { get; set; }
    public int Age { get; set; }
    public List<Phone> Phones {get; set;}
}