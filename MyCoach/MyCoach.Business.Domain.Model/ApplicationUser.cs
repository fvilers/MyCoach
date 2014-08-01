using Microsoft.AspNet.Identity;

namespace MyCoach.Business.Domain.Model
{
    public class ApplicationUser : IUser<int>
    {

        public int Id {get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string PasswordHash { get; set; }
    }
}
