using System.Data.Entity;

namespace DataAccessLayer
{
    public class FMSDbInitializer : CreateDatabaseIfNotExists<FMSGlobalDbContext>
    {
        protected override void Seed(FMSGlobalDbContext context)
        {
            try
            {
                base.Seed(context);
            }
            catch (System.Exception exq)
            {
                var errorMsg = exq.Message;
                throw;
            }
        }
    }
}
