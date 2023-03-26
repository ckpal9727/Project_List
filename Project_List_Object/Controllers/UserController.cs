using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project_List_Object.Data;
using Project_List_Object.Models;
using Project_List_Object.Service;

namespace Project_List_Object.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser user;
		private readonly IMapper mapper;

		public UserController(IUser user,IMapper mapper)
        {
            this.user = user;
			this.mapper = mapper;
		}
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Create() 
        {
			var jobs = await user.GetJobs();
			TempData["jobs"] = jobs;
			return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(List<UserEditModel> userData)
        {
			var jobs= await user.GetJobs();
            TempData["jobs"] = jobs;
			if (!ModelState.IsValid)
			{
				return View();
			}
           foreach (var users in userData)
            {
              
                await user.AddUser(mapper.Map<UserData>(users));
            }
            return View(userData);
        }
        [HttpGet] public IActionResult Get()
        {
            return Ok();
        }
    }
}
