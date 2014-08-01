using MyCoach.Business.Domain.Model;
using System.Data.Entity;

namespace MyCoach.Data.EntityFramework
{
    public class MyCoachContext : ContextBase, IMyCoachContext
    {
        public IDbSet<ApplicationUser> ApplicationUsers { get; set; }
        public IDbSet<CoachProfile> CoachProfiles { get; set; }
        public IDbSet<ExpertiseDomain> Keywords { get; set; }
    }
}
