namespace Cashify.Domain.Entities;

using Cashify.Domain.Common;

public sealed class Store : Auditable
{
    public string Name { get; set; } = string.Empty;
    public decimal CashBackPersentage { get; set; }
    public bool IsActive { get; set; }

    public long ContactId { get; set; }
    public Contact Contact { get; set; } = default!;

    public long AddressId { get; set; }
    public Address Address { get; set; } = default!;
    
    public long OwnerId { get; set; }
    public User Owner { get; set; } = default!;
}