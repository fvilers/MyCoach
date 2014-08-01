using Microsoft.AspNet.Identity;
using MyCoach.Business.Domain.Model;

namespace MyCoach.Data.Identity.Managers
{
    public class ApplicationUserManager : UserManager<ApplicationUser, int>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser, int> store)
            : base(store)
        {
        }
    }
}
