using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext dbContext;

        // Constructor injection of the NZWalksDbContext
        public SQLRegionRepository(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            // Using Entity Framework Core's ToListAsync() method to retrieve all regions from the database asynchronously
            return await dbContext.Regions.ToListAsync();
        }

        public async Task<Region?> GetById(Guid id)
        {
            dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
