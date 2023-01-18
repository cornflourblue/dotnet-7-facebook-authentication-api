namespace WebApi.Models.Accounts;

using System.ComponentModel.DataAnnotations;

public class AuthenticateRequest
{
    [Required]
    public string? AccessToken { get; set; }
}