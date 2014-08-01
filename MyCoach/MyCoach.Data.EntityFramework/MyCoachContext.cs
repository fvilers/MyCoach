using MyCoach.Business.Domain.Model;
using System.Data.Entity;

namespace MyCoach.Data.EntityFramework
{
    public class MyCoachContext : ContextBase, IMyCoachContext
    {
        public IDbSet<ApplicationUser> ApplicationUsers { get; set; }
        public IDbSet<Keyword> Keywords { get; set; }
    }
}
