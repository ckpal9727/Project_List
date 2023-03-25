using Microsoft.EntityFrameworkCore;

namespace Project_List_Object.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<UserData> User { get; set; }
        public DbSet<UserJobsData> Jobs { get; set; }
    }
    
}
