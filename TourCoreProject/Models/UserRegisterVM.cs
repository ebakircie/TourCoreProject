using System.ComponentModel.DataAnnotations;

namespace TourCoreProject.Models
{
    public class UserRegisterVM
    {
        [Required(ErrorMessage ="Please enter a Name!")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Please enter a Surname!")]
        public string Surname { get; set; }
       
        [Required(ErrorMessage = "Please enter a Username!")]
        public string UserName { get; set; }
       
        [Required(ErrorMessage = "Please enter a E-Mail Adress!")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please enter a Password!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please re-enter password!")]
        [Compare("Password",ErrorMessage ="Passwords does not match!")]
        public string ConfirmPassword { get; set; }


    }
}
