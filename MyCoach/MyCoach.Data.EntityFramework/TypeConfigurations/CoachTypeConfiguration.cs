using MyCoach.Business.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace MyCoach.Data.EntityFramework.TypeConfigurations
{
    public class CoachTypeConfiguration : EntityTypeConfiguration<Coach>
    {
        public CoachTypeConfiguration()
        {
            ToTable("Coaches");
            HasMany(x => x.ExpertiseDomains).WithMany();
            HasMany(x => x.Schedules).WithRequired();
            HasOptional(x => x.Photo);
        }
    }
}
