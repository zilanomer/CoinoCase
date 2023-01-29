using Core.Entities;

namespace Entities.DTOs
{
    public class UserLoginDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
