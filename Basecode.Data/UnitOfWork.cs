using Basecode.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Basecode.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public DbContext Database { get; private set; }

        public UnitOfWork(BasecodeContext serviceContext)
        {
            Database = serviceContext;
        }

        public void SaveChanges()
        {
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
