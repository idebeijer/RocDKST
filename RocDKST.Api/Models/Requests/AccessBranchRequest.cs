using System.ComponentModel.DataAnnotations;

namespace RocDKST.Api.Models.Requests;

public class AccessBranchRequest
{
    [Required]
    public Guid UserId { get; set; }
    [Required]
    public string Time { get; set; } = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
}