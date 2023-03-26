using AutoMapper;
using Project_List_Object.Data;
using Project_List_Object.Models;

namespace Project_List_Object.Profiless
{
	public class UserProfile:Profile
	{
		public UserProfile()
		{
			CreateMap<UserData,UserEditModel>().ReverseMap();
		}
	}
}
