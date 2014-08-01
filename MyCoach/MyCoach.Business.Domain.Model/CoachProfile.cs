using MyCoach.Shared.Enums;
using System.Collections.Generic;

namespace MyCoach.Business.Domain.Model
{
    public class CoachProfile : Entity<CoachProfile>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public string Biography { get; set; }
        public ICollection<ExpertiseDomain> ExpertiseDomains { get; set; }

        public CoachProfile()
        {
            ExpertiseDomains = new HashSet<ExpertiseDomain>();
        }
    }
}
