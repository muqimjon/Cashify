using Cashify.Application.Common;
using Cashify.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cashify.Infrastructure.Persistance.EntityFramework;

public class AppDbContext : DbContext, IAppDbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Referral> Referrals { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<StoreReview> Reviews { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
}