using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ProjectX.Models.Mapping;

namespace ProjectX.Models
{
    public partial class EsquentaContainerContext : DbContext
    {
        static EsquentaContainerContext()
        {
            Database.SetInitializer<EsquentaContainerContext>(null);
        }

        public EsquentaContainerContext()
            : base("Name=EsquentaContainerContext")
        {
        }

        public DbSet<LocalSet> LocalSets { get; set; }
        public DbSet<PostSet> PostSets { get; set; }
        public DbSet<UserSet> UserSets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LocalSetMap());
            modelBuilder.Configurations.Add(new PostSetMap());
            modelBuilder.Configurations.Add(new UserSetMap());
        }
    }
}
