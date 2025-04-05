using System.ComponentModel.DataAnnotations;

namespace SemestrTwoBlazor.Model
{
    public class User
    {
        [Key] public int Id { get; set; }
        [Required][EmailAddress] public string Email { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Required] public string Password { get; set; }
        public string _isAdmin { get; set; }
    }
}
