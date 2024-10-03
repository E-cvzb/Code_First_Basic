using Microsoft.EntityFrameworkCore;

namespace Code_First_Basic.Context
{
    public class PatikaFirstDbContext: DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options):base(options)
        {
            
        }

    }
}
