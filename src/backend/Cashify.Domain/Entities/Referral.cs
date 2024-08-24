namespace Cashify.Domain.Entities;

using Cashify.Domain.Common;

public sealed class Referral : Auditable
{
    public string Code { get; set; } = string.Empty;
    public bool IsRewarded { get; set; }
    public decimal RewardAmount { get; set; }

    public long ReferrerId { get; set; }
    public User Referrer { get; set; } = default!;

    public long ReferredId { get; set; }
    public User Referred { get; set; } = default!;
}