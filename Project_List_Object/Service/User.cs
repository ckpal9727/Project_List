using Microsoft.EntityFrameworkCore;
using Project_List_Object.Data;

namespace Project_List_Object.Service
{
    public class User : IUser
    {
        private readonly DataContext dataContext;

        public User(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task AddUser(UserData userData)
        {
            await dataContext.User.AddAsync(userData); 
            await dataContext.SaveChangesAsync();
        }

        public async Task<List<UserJobsData>> GetJobs()
        {
           return  await dataContext.Jobs.ToListAsync();
        }
    }
}
