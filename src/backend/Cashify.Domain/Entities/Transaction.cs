﻿namespace Cashify.Domain.Entities;

using Cashify.Domain.Common;
using Cashify.Domain.Enums;

public sealed class Transaction : Auditable
{
    public decimal Amount { get; set; }
    public CashBackStatus Status { get; set; }

    public long UserId { get; set; }
    public User User { get; set; } = default!;

    public long StoreId { get; set; }
    public Store Store { get; set; } = default!;
}