using Microsoft.EntityFrameworkCore;

namespace Diary_net_9.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        { 
                            
        }
    }
}
