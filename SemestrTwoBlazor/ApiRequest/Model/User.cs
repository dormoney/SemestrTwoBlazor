using System.ComponentModel.DataAnnotations;

namespace SemestrTwoBlazor.ApiRequests.Model
{
    public class UserData
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class RegisterRequest
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
