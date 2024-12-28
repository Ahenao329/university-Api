using Microsoft.EntityFrameworkCore;
using UniversityApi.Models.DataModels;

namespace UniversityApi.DataAccess
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {
            
        }
        // TODO: Add DbSets (Tables od our Data base) 
        public DbSet<User>? Users { get; set; }
    }
}
