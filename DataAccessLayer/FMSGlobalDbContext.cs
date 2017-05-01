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

        public virtual DbSet<EmployeeAddressDetails> EmployeeAddressDetails { get; set; }
        public virtual DbSet<EmployeeBankDetails> EmployeeBankDetails { get; set; }
        public virtual DbSet<EmployeeEducationDetails> EmployeeEducationDetails { get; set; }
        public virtual DbSet<EmployeePersonalInfo> EmployeePersonalInfo { get; set; }
        public virtual DbSet<EmployeeExService> EmployeeExService { get; set; }
        public virtual DbSet<EmployeeFamilyDetails> EmployeeFamilyDetails { get; set; }
        public virtual DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public virtual DbSet<EmployeePhysicalStandard> EmployeePhysicalStandard { get; set; }
        public virtual DbSet<EmployeePolicyRecord> EmployeePolicyRecord { get; set; }
        public virtual DbSet<EmployeePreviousExperience> EmployeePreviousExperience { get; set; }
        public virtual DbSet<EmployeeProofs> EmployeeProofs { get; set; }
        public virtual DbSet<EmployeeSalaryDetails> EmployeeSalaryDetails { get; set; }
        public virtual DbSet<ClientInformation> ClientInformation { get; set; }
        public virtual DbSet<BillingDetails> BillingDetails { get; set; }
    }
}
