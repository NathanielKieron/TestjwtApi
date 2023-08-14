using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace JwtCreatorApi.Models
{
    public class UserDTO
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}
