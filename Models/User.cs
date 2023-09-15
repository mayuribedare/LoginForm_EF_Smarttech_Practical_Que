using System.ComponentModel.DataAnnotations;

namespace UserLoginProject.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(60, MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Status { get; set; }

        [DataType(DataType.Date)]
         public DateTime ExpiryDate { get; set; }
    }

}

