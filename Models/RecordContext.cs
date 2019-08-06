using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngularCoreCrud.Models
{
    public partial class RecordContext : DbContext
    {
        public RecordContext()
        {
        }

        public RecordContext(DbContextOptions<RecordContext> options)
            : base(options)
        {
        }
        // hello ? awaz ari hay?ni no do apna?
        // whatsapp ka?hn
        // 03012551108 ok w8 powered off h bhai
        // skype ajao yahe pr. ya iski audio nai ccchlti kia?ni tm phone uthao. phone kri
        //??? phone kro ok bnd h yr...power on kr bhai
        // mera phone on hay. tm whatsapp pr kr ray ho na?
        //mery num py miss call do 03352264769


        public virtual DbSet<TblCities> TblCities { get; set; }
       public virtual DbSet<TblEmployee> TblEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Data Source=Record.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCities>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("tblCities");

                entity.Property(e => e.CityId)
                    .HasColumnName("CityID")
                    .ValueGeneratedNever();
            });

            
            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tblEmployee");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();
            });
        }
    }
}
