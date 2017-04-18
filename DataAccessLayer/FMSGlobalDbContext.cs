using DataAccessLayer.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DataAccessLayer
{
    public class FMSGlobalDbContext : DbContext
    {
       public FMSGlobalDbContext() : base("FMSConnectionString")
        {
            Database.SetInitializer<FMSGlobalDbContext>(new FMSDbInitializer());
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public static FMSGlobalDbContext Create()
        {
            return new FMSGlobalDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public virtual DbSet<EmployeePersonalInfo> EmployeePersonalInfo { get; set; }
    }
}
