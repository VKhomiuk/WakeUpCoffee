using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace CoffeeShopBack.Models;

public partial class CoffeeShopDbContext : DbContext
{
    public CoffeeShopDbContext()
    {
    }

    public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; } = null!;

    public virtual DbSet<CoffeeShop> CoffeeShops { get; set; } = null!;

    public virtual DbSet<Location> Locations { get; set; } = null!;

    public virtual DbSet<MenuItem> MenuItems { get; set; } = null!;

    public virtual DbSet<Order> Orders { get; set; } = null!;

    public virtual DbSet<OrderLine> OrderLines { get; set; } = null!;

    public virtual DbSet<SocialMedia> SocialMedias { get; set; } = null!;

    public virtual DbSet<User> Users { get; set; } = null!;

    public virtual DbSet<Additional> Additionals { get; set; } = null!;

    public virtual DbSet<MenuItemAdditional> MenuItemAdditionals { get; set; } = null!;

    public virtual DbSet<OrderLineAdditional> OrderLineAdditionals { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=CoffeeShopDBTest;Integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.Property(e => e.CategoryId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.CoffeeShopId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.Title).HasMaxLength(50).IsUnicode(false).IsRequired();

            entity.HasOne(d => d.CoffeeShop).WithMany(p => p.Categories).HasForeignKey(d => d.CoffeeShopId);
        });

        modelBuilder.Entity<CoffeeShop>(entity =>
        {
            entity.HasKey(e => e.CoffeeShopId);

            entity.Property(e => e.CoffeeShopId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.Description).HasMaxLength(255).IsUnicode(false).IsRequired(false);
            entity.Property(e => e.Email).HasMaxLength(50).IsUnicode(false).IsRequired();
            entity.Property(e => e.Password).HasMaxLength(255).IsUnicode(false).IsRequired();
            entity.Property(e => e.Status).HasMaxLength(30).IsUnicode(false).IsRequired();
            entity.Property(e => e.Title).HasMaxLength(30).IsUnicode(false).IsRequired();
            entity.Property(e => e.WorkingHours).HasMaxLength(255).IsUnicode(false).IsRequired(false);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.Property(e => e.LocationId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.CoffeeShopId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.Latitude).HasMaxLength(15).IsUnicode(false).IsRequired();
            entity.Property(e => e.Longitude).HasMaxLength(15).IsUnicode(false).IsRequired();

            entity.HasOne(d => d.CoffeeShop).WithMany(p => p.Locations).HasForeignKey(d => d.CoffeeShopId);
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.MenuItemId);

            entity.Property(e => e.MenuItemId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.Amount).HasMaxLength(30).IsUnicode(false).IsRequired(false);
            entity.Property(e => e.CategoryId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.CookingTime).HasPrecision(0).IsRequired();
            entity.Property(e => e.Description).HasMaxLength(255).IsUnicode(false).IsRequired(false);
            entity.Property(e => e.Price).HasColumnType("smallmoney").IsRequired();
            entity.Property(e => e.Title).HasMaxLength(50).IsUnicode(false).IsRequired();

            entity.HasOne(d => d.Category).WithMany(p => p.MenuItems).HasForeignKey(d => d.CategoryId);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.Property(e => e.OrderId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.CoffeeShopId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.Comment).HasMaxLength(255).IsUnicode(false).IsRequired(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime").IsRequired();
            entity.Property(e => e.PaymentType).HasMaxLength(20).IsUnicode(false).IsRequired(false);
            entity.Property(e => e.Price).HasColumnType("smallmoney").IsRequired();
            entity.Property(e => e.ScheduledDate).HasColumnType("datetime").IsRequired();
            entity.Property(e => e.Status).HasMaxLength(50).IsUnicode(false).IsRequired();
            entity.Property(e => e.UserId).HasMaxLength(36).IsUnicode(false).IsRequired();

            entity.HasOne(d => d.CoffeeShop).WithMany(p => p.Orders).HasForeignKey(d => d.CoffeeShopId);
            entity.HasOne(d => d.User).WithMany(p => p.Orders).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<OrderLine>(entity =>
        {
            entity.HasKey(e => e.OrderLineId);

            entity.Property(e => e.OrderLineId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.MenuItemId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.MenuItemName).HasMaxLength(50).IsUnicode(false).IsRequired();
            entity.Property(e => e.OrderId).HasMaxLength(36).IsUnicode(false).IsRequired();

            entity.HasOne(d => d.MenuItem).WithMany(p => p.OrderLines).HasForeignKey(d => d.MenuItemId).OnDelete(DeleteBehavior.NoAction);
            entity.HasOne(d => d.Order).WithMany(p => p.OrderLines).HasForeignKey(d => d.OrderId);
        });

        modelBuilder.Entity<SocialMedia>(entity =>
        {
            entity.HasKey(e => e.SocialMediaId);

            entity.Property(e => e.SocialMediaId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.CoffeeShopId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.Link).IsUnicode(false).IsRequired();
            entity.Property(e => e.Title).HasMaxLength(20).IsUnicode(false).IsRequired();

            entity.HasOne(d => d.CoffeeShop).WithMany(p => p.SocialMedias).HasForeignKey(d => d.CoffeeShopId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.Email).HasMaxLength(50).IsUnicode(false).IsRequired();
            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false).IsRequired();
            entity.Property(e => e.Password).HasMaxLength(255).IsUnicode(false).IsRequired();
            entity.Property(e => e.PhoneNumber).HasMaxLength(17).IsUnicode(false).IsRequired(false);
            entity.Property(e => e.Role).HasMaxLength(10).IsUnicode(false).IsRequired();
            entity.Property(e => e.Surname).HasMaxLength(50).IsUnicode(false).IsRequired();
        });

        modelBuilder.Entity<Additional>(entity =>
        {
            entity.HasKey(e => e.AdditionalId);

            entity.Property(e => e.AdditionalId).HasMaxLength(36).IsUnicode(false).IsRequired();
            entity.Property(e => e.Title).HasMaxLength(50).IsUnicode(false).IsRequired();
            entity.Property(e => e.Price).HasColumnType("smallmoney").IsRequired();
        });

        modelBuilder.Entity<MenuItemAdditional>(entity =>
        {
            entity.HasKey(e => new { e.MenuItemId, e.AdditionalId });

            entity.HasOne(d => d.MenuItem).WithMany(p => p.MenuItemAdditionals).HasForeignKey(e => e.MenuItemId);
            entity.HasOne(d => d.Additional).WithMany(p => p.MenuItemAdditionals).HasForeignKey(e => e.AdditionalId);
        });

        modelBuilder.Entity<OrderLineAdditional>(entity =>
        {
            entity.HasKey(e => new { e.OrderLineId, e.AdditionalId });

            entity.HasOne(d => d.OrderLine).WithMany(p => p.OrderLineAdditionals).HasForeignKey(e => e.OrderLineId);
            entity.HasOne(d => d.Additional).WithMany(p => p.OrderLineAdditionals).HasForeignKey(e => e.AdditionalId);
        });

        modelBuilder.Entity<CoffeeShop>().HasIndex(e => e.Email).IsUnique();
        modelBuilder.Entity<User>().HasIndex(e => e.Email).IsUnique();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
