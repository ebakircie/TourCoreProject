using System.ComponentModel.DataAnnotations;

namespace TourCoreProject.Models
{
    public class UserSignInVM
    {
        [Required(ErrorMessage ="Please enter a Username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a Password.")]
        public string Password{ get; set; }
    }
}
