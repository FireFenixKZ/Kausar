using System.ComponentModel.DataAnnotations;

namespace Kausar.Model
{
    public class LoginVM
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
