using Project_List_Object.Data;

namespace Project_List_Object.Service
{
    public interface IUser
    {
        public Task AddUser(UserData user);
    }
}
