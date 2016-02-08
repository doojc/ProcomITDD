using ProcommITDD.Library.Model.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProcommITDD.Library.Repository.EF
{
    public partial class DdPlatformContext : DbContext //IdentityDbContext<ApplicationUser>
    {
        public DdPlatformContext()
            : base("name=DdPlatformContext") { }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Preset> Presets { get; set; }
        public virtual DbSet<Scope> Scopes { get; set; }
        public virtual DbSet<Compliance> Complaiances { get; set; }
        public virtual DbSet<Informant> Informants { get; set; }
        public virtual DbSet<ProjectInformant> ProjectInformants { get; set; }
        public virtual DbSet<ProjectQuestion> ProjectQuestions { get; set; }

        public static DdPlatformContext Create()
        {
            return new DdPlatformContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Compliance>()
                .HasMany(e => e.Projects)
                .WithMany(e => e.Compliances)
                .Map(m => m.ToTable("ProjectCompliance"));

            modelBuilder.Entity<Project>()
                .HasMany(e => e.Scopes)
                .WithMany(e => e.Projects)
                .Map(m => m.ToTable("ScopeProject"));

            modelBuilder.Entity<Preset>()
                .HasMany(e => e.Questions)
                .WithMany(e => e.Presets)
                .Map(m => m.ToTable("PresetQuestion"));

            modelBuilder.Entity<ProjectQuestion>()
                .HasRequired(m => m.Question)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProjectQuestion>()
                .HasOptional(f => f.Answer)
                .WithRequired(s => s.ProjectQuestion);

        }
    }
}
