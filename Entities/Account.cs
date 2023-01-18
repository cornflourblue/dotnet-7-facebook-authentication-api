namespace WebApi.Entities;

public class Account
{
    public int Id { get; set; }
    public long FacebookId { get; set; }
    public string? Name { get; set; }
    public string? ExtraInfo { get; set; }
}