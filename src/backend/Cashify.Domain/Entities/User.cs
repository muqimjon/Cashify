namespace Cashify.Domain.Entities;

using Cashify.Domain.Enums;

public sealed class User
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public DateTimeOffset DateOfBirth { get; set; }
    public Genders Gender { get; set; }
    public decimal Balance { get; set; }
    public Roles Role { get; set; }
    public int TelegramId { get; set; }
    public TelegramStates State { get; set; }
    public bool IsActive { get; set; }

    public long ContactId { get; set; }
    public Contact Contact { get; set; } = default!;
}