using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }  //lowercase 'n' is ok here for DTOs as you can map to Entity UserName easily

        [Required]
        public string Password { get; set; }
    }
}