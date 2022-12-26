using NLayer.Core.UnifOfWorks;
using NLayer.Repository.Contexts;

namespace NLayer.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnifOfWorks
    {
        protected readonly BaseDbContext _context;

        public UnitOfWork(BaseDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}