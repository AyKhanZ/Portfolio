using DbEcommerceApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DbEcommerceApp.Data.DbContexts;

public class EcommerceDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderProduct> OrderProducts { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserDetail> UserDetails { get; set; }
    public DbSet<UserPayment> UserPayments { get; set; }
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<BasketProduct> BasketProducts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        ConfigurationBuilder builder = new();

        builder.AddJsonFile("appsettings.json");

        IConfigurationRoot config = builder.Build();

        var connectionString = config.GetConnectionString("Ecommerce");

        optionsBuilder.UseSqlServer(connectionString);

        base.OnConfiguring(optionsBuilder);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).IsRequired().HasMaxLength(25);


            entity.HasMany(p => p.Products).WithOne(c => c.Category);
        });


        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(o => o.Id);
            entity.Property(o => o.Date).IsRequired(); 
            entity.Property(o => o.Quantity).IsRequired(); 
            entity.Property(o => o.TotalPrice).IsRequired().HasColumnType("decimal(18,2)");  
            entity.Property(o => o.OrderStatus).IsRequired();
             

            entity.HasOne(u => u.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(u => u.UserId)
            .OnDelete(DeleteBehavior.Restrict);


            entity.HasMany(op => op.OrderProducts).WithOne(o => o.Order);
        });



        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.Property(op => op.Quantity).IsRequired();


            entity.HasOne(o => o.Order)
            .WithMany(o => o.OrderProducts)
            .HasForeignKey(op => op.OrderId)
            .OnDelete(DeleteBehavior.Cascade);


            entity.HasOne(p => p.Product)
            .WithMany(p => p.OrderProducts)
            .HasForeignKey(p => p.ProductId)
            .OnDelete(DeleteBehavior.Cascade);
        });



        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(p => p.Id); 
            entity.Property(p => p.Price).IsRequired(); 
            entity.Property(p => p.Image).IsRequired().HasMaxLength(100); 
            entity.Property(p => p.Name).IsRequired().HasMaxLength(50); 
            entity.Property(p => p.Make).IsRequired().HasMaxLength(25); 
            entity.Property(p => p.Description).IsRequired().HasMaxLength(1000);


            entity.HasOne(с => с.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(с => с.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

             
            entity.HasMany(op => op.OrderProducts).WithOne(op => op.Product);
        });



        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Login).IsRequired().HasMaxLength(30);
            entity.Property(u => u.Name).IsRequired().HasMaxLength(30);
            entity.Property(u => u.Surname).IsRequired().HasMaxLength(30);
            entity.Property(u => u.Password).IsRequired().HasMaxLength(30);
            entity.Property(u => u.Email).IsRequired().HasMaxLength(50);
            entity.Property(u => u.Icon).HasMaxLength(200);
            entity.Property(u => u.IsAdmin);
             

            entity.HasIndex(u => u.Login).IsUnique();

            entity.HasMany(o => o.Orders).WithOne(u => u.User);

            entity.HasMany(up => up.UserPayments).WithOne(u => u.User);


            entity.HasOne(u => u.UserDetail)
                .WithOne(ud => ud.User)
                .HasForeignKey<UserDetail>(ud => ud.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        });



        modelBuilder.Entity<Basket>(entity =>
        {
            entity.HasKey(ud => ud.Id);

            entity.HasOne(b => b.User)
                  .WithMany(u => u.Baskets)
                  .HasForeignKey(b => b.UserId);

        });



        modelBuilder.Entity<BasketProduct>(entity =>
        {
            entity.HasKey(bp => new { bp.BasketId, bp.ProductId });

            entity.HasOne(bp => bp.Basket)
            .WithMany(b => b.BasketProducts)
            .HasForeignKey(bp => bp.BasketId);


            entity.HasOne(c => c.Product)
            .WithMany(c => c.BasketProducts)
            .HasForeignKey(c => c.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
        });



        modelBuilder.Entity<UserPayment>(entity =>

        {

            entity.HasKey(ud => ud.Id);
            entity.Property(up => up.CVV).HasMaxLength(3);
            entity.Property(up => up.EXP).HasMaxLength(5);
            entity.Property(up => up.SixteenDigitCode).HasMaxLength(16);



            entity.HasOne(u => u.User)
            .WithMany(u => u.UserPayments)
            .HasForeignKey(u => u.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        });



        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasKey(ud => ud.Id);
            entity.Property(ud => ud.City).HasMaxLength(100);
            entity.Property(ud => ud.Country).HasMaxLength(100);
            entity.Property(ud => ud.Address).HasMaxLength(100);
            entity.Property(ud => ud.PostalCode).HasMaxLength(100);
            entity.Property(ud => ud.PhoneNumber).HasMaxLength(100);


            entity.HasOne(u => u.User).WithOne(ud => ud.UserDetail);
        });
    }
}