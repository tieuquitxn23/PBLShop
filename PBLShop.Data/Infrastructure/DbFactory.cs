namespace PBLShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PBLShopDbContext dbContext;

        public PBLShopDbContext Init()
        {
            return dbContext ?? (dbContext = new PBLShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}