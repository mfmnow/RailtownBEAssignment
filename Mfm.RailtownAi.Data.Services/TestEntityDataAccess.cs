using Mfm.RailtownAi.Data.Contracts;
using Mfm.RailtownAi.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mfm.RailtownAi.Data.Services
{
    public class TestEntityDataAccess : GenericRepository<TestEntity>, ITestEntityDataAccess
    {
        private readonly ITestDbContext _context;

        public TestEntityDataAccess(TestDbContext testDbContext) : base(testDbContext)
        {
            _context = testDbContext;
        }

        public async Task CreateTestEntity(string test, string createdBy = "")
        {
            var entity = new TestEntity
            {
                Test = test,
                CreatedBy = createdBy
            };
            await Create(entity);
        }

        public async Task<List<TestEntity>> GetTestEntitiies()
        {
            return await GetAll();
        }
    }
}
