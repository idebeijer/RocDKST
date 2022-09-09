using System.ComponentModel.DataAnnotations;
using RocDKST.Api.Enums;

namespace RocDKST.Api.Models;

public class User
{
    public Guid UserId { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public DateTime DateOfLastEntry { get; set; }
    public Subscription Subscription { get; set; }
}