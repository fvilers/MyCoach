using System.Data.Entity;
using MyCoach.Business.Domain.Model;

namespace MyCoach.Data.EntityFramework
{
    public interface IMyCoachContext : IUnitOfWork
    {
        IDbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
