using RocDKST.Api.Enums;

namespace RocDKST.Api.Models;

public class Class
{
    public int Id { get; set; }
    public User Trainer { get; set; }
    public List<User> Users { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public ClassType Type { get; set; }
}