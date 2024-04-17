using System.ComponentModel.DataAnnotations;

namespace DemoSSR.Client.Models
{
    public class AuthForm
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Display(Name = "Michael", Description = "le mot de passe ?", Prompt = "Kapout draconis")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
