using MyCoach.Business.Domain.Model;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace MyCoach.Data.EntityFramework
{
    public class MyCoachContext : DbContext, IMyCoachContext
    {

        public IDbSet<ApplicationUser> ApplicationUsers { get; set; }
        public new Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
