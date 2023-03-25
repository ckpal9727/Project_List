using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project_List_Object.Data
{
    public class UserData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [MaxLength(35)]
        public string Email { get; set; }
        public int JobId { get; set; }
        public virtual UserJobsData Job { get; set; }
    }
}
