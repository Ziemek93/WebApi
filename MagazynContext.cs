using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public partial class MagazynContext : DbContext
    {
        public MagazynContext()
        {
        }

        public MagazynContext(DbContextOptions<MagazynContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<DocumentsThings> DocumentsThings { get; set; }
        public virtual DbSet<Things> Things { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=DESKTOP-H5UPHA1\\ZiemoMSSQL;Database=Magazyn;User ID=sa;Password=Q1@;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasIndex(e => e.Nazwa)
                    .HasName("UQ__Document__F072DFBEC0A58C83")
                    .IsUnique();

                entity.Property(e => e.DataDokumentu)
                    .HasColumnName("data_dokumentu")
                    .HasColumnType("date");

                entity.Property(e => e.IdFku).HasColumnName("Id_fku");

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasColumnName("nazwa")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.NumerKlienta).HasColumnName("numer_klienta");

                entity.HasOne(d => d.IdFkuNavigation)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.IdFku)
                    .HasConstraintName("FK__Documents__Id_fk__7E37BEF6");
            });

            modelBuilder.Entity<DocumentsThings>(entity =>
            {
                entity.ToTable("Documents_Things");

                entity.Property(e => e.IdFkd).HasColumnName("Id_fkd");

                entity.Property(e => e.IdFkt).HasColumnName("Id_fkt");

                entity.Property(e => e.Ilosc).HasColumnName("ilosc");

                entity.HasOne(d => d.IdFkdNavigation)
                    .WithMany(p => p.DocumentsThings)
                    .HasForeignKey(d => d.IdFkd)
                    .HasConstraintName("FK__Documents__Id_fk__03F0984C");

                entity.HasOne(d => d.IdFktNavigation)
                    .WithMany(p => p.DocumentsThings)
                    .HasForeignKey(d => d.IdFkt)
                    .HasConstraintName("FK__Documents__Id_fk__04E4BC85");
            });

            modelBuilder.Entity<Things>(entity =>
            {
                entity.HasIndex(e => e.NazwaArtykulu)
                    .HasName("UQ__Things__72CCCFF7E2CB8270")
                    .IsUnique();

                entity.Property(e => e.CenaBrutto).HasColumnName("cena_brutto");

                entity.Property(e => e.CenaNetto).HasColumnName("cena_netto");

                entity.Property(e => e.NazwaArtykulu)
                    .IsRequired()
                    .HasColumnName("nazwa_artykulu")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.Login)
                    .HasName("UQ__Users__5E55825B70D2E115")
                    .IsUnique();

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
