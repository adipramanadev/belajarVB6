using Microsoft.EntityFrameworkCore;

namespace simpleapi.Entities;

public partial class CobadotnetContext : DbContext
{
    public CobadotnetContext()
    {
    }

    public CobadotnetContext(DbContextOptions<CobadotnetContext> options)
        : base(options)
    {
    }

    public  DbSet<Product> Products { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=cobadotnet");
            }
        }
   


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("product");

            entity.Property(e => e.Harga)
                .HasMaxLength(32)
                .HasColumnName("harga");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nama)
                .HasMaxLength(32)
                .HasColumnName("nama");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
