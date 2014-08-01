using MyCoach.Business.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace MyCoach.Data.EntityFramework.TypeConfigurations
{
    public class CoachProfileTypeConfiguration : EntityTypeConfiguration<CoachProfile>
    {
        public CoachProfileTypeConfiguration()
        {
            HasMany(x => x.ExpertiseDomains).WithMany();
        }
    }
}
