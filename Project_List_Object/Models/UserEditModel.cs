using Project_List_Object.Data;
using System.ComponentModel.DataAnnotations;

namespace Project_List_Object.Models
{
    public class UserEditModel
    {
		[Required]
		[MaxLength(20)]
		[MinLength(3)]
		public string FirstName { get; set; }
        public string LastName { get; set; }
		[Required]
		[MaxLength(35)]
		public string Email { get; set; }

		public int JobId { get; set; }
		public virtual  UserJobsData? Job { get; set; }
	}
}
