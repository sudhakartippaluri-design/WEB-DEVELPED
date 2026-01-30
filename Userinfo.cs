using System.ComponentModel.DataAnnotations;

namespace WebApplication18.Models
{
    public class Userinfo
    {

        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
                = string.Empty;


        public string Password { get; set; }
        = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; }
        = string.Empty;
        public DateTime Date { get; set; }
    }
}


