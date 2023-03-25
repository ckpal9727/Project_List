using Microsoft.AspNetCore.Mvc;
using Project_List_Object.Data;
using Project_List_Object.Service;

namespace Project_List_Object.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser user;

        public UserController(IUser user)
        {
            this.user = user;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() 
        {
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(List<UserData> userData)
        {
           foreach (var users in userData)
            {
                await user.AddUser(users);
            }
            return View(userData);
        }
    }
}
