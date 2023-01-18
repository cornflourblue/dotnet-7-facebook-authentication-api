namespace WebApi.Models.Accounts;

using WebApi.Entities;

public class AuthenticateResponse
{
    public int Id { get; set; }
    public long FacebookId { get; set; }
    public string? Name { get; set; }
    public string? ExtraInfo { get; set; }
    public string Token { get; set; }


    public AuthenticateResponse(Account account, string token)
    {
        Id = account.Id;
        FacebookId = account.FacebookId;
        Name = account.Name;
        ExtraInfo = account.ExtraInfo;
        Token = token;
    }
}