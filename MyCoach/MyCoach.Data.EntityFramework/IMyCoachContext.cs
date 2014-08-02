using MyCoach.Business.Domain.Model;
using System.Data.Entity;

namespace MyCoach.Data.EntityFramework
{
    public interface IMyCoachContext : IUnitOfWork, IAsyncUnitOfWork
    {
        IDbSet<ApplicationUser> ApplicationUsers { get; }
        IDbSet<ExpertiseDomain> Keywords { get; }
    }
}
