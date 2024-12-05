using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PR3;

public partial class Lb2PartnersContext : DbContext
{
    public Lb2PartnersContext()
    {
    }

    public Lb2PartnersContext(DbContextOptions<Lb2PartnersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnersProduct> PartnersProducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<TypesOfPartner> TypesOfPartners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=LB2_Partners;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_pkey");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            entity.Property(e => e.Tin).HasColumnName("TIN");

            entity.HasOne(d => d.TypeOfPartner).WithMany(p => p.Partners)
                .HasForeignKey(d => d.TypeOfPartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partners_typesOfPartner");
        });

        modelBuilder.Entity<PartnersProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Partners_Products_pkey");

            entity.ToTable("Partners_Products");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            entity.Property(e => e.SaleDate).HasColumnType("timestamp without time zone");

            entity.HasOne(d => d.Partner).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partnersProducts_partners");

            entity.HasOne(d => d.Product).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partnerProducts_products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Products_pkey");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            entity.Property(e => e.MinCostForPartner).HasColumnType("money");

            entity.HasOne(d => d.IdProductTypeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdProductType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_products_productTypes");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ProductTypes_pkey");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            entity.Property(e => e.ProductType1).HasColumnName("ProductType");
        });

        modelBuilder.Entity<TypesOfPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Users_pkey");

            entity.ToTable("TypesOfPartner");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
