using MyCoach.Business.Domain.Model;
using MyCoach.Data.EntityFramework.TypeConfigurations;
using System;
using System.Data.Entity;

namespace MyCoach.Data.EntityFramework
{
    public class MyCoachContext : ContextBase, IMyCoachContext
    {
        public IDbSet<ApplicationUser> ApplicationUsers { get; set; }
        public IDbSet<CoachProfile> CoachProfiles { get; set; }
        public IDbSet<ExpertiseDomain> Keywords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null) throw new ArgumentNullException("modelBuilder");

            modelBuilder.Configurations.Add(new CoachProfileTypeConfiguration());
        }
    }
}
