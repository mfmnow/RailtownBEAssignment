using System.Collections.Generic;
using System.Threading.Tasks;
using Mfm.RailtownAi.Data.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Mfm.RailtownAi.Data.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly TestDbContext _context;

        public GenericRepository(TestDbContext testDbContext)
        {
            _context = testDbContext;
        }

        public virtual async Task Create(T entity)
        {
            _context.Set<T>();
            await _context.AddAsync<T>(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}
