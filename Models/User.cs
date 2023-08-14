using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace JwtCreatorApi.Models
{
    public class User
    {
        public string UserName { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}
