
using System.Collections.Generic;
using MyCoach.Shared.Enums;

namespace MyCoach.Business.Domain.Model
{
    public class Coach :ApplicationUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public string Summary { get; set; }
        public string Biography { get; set; }
        public string SkypeId { get; set; }
        public ICollection<ExpertiseDomain> ExpertiseDomains { get; set; }

        public Coach()
        {
            ExpertiseDomains = new HashSet<ExpertiseDomain>();
        }
    }
}
