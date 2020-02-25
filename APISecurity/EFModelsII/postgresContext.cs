using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace APISecurity.EFModelsII
{
    public partial class postgresContext : DbContext
    {
        public postgresContext()
        {
        }

        public postgresContext(DbContextOptions<postgresContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Aplication> Aplication { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<User1> User1 { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Server=dev-bd.c4eg064xqfsk.sa-east-1.rds.amazonaws.com;Port=5432;Database=postgres;User ID=sa;Password=Agosto2019$;")
        //       .EnableSensitiveDataLogging(true)
        //       .UseLoggerFactory(MyLoggerFactory);

        //    base.OnConfiguring(optionsBuilder);
        //}

        //public static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        //{
        //    builder.AddFilter((category, level) =>
        //        category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information)
        //        .AddConsole();
        //});

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aplication>(entity =>
            {
                entity.ToTable("Aplication", "Security");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Organization", "Security");

                entity.HasComment("Contiene las organizaciones (empresas)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Name).HasMaxLength(500);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "Security");
            });

            modelBuilder.Entity<User1>(entity =>
            {
                entity.ToTable("User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
