using MyCoach.Shared.Enums;
using System.Collections.Generic;

namespace MyCoach.Services.Dtos
{
    public class CoachDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }
        public string Biography { get; set; }
        public string Summary { get; set; }
        public string SkypeId { get; set; }
        public IEnumerable<ExpertiseDomainDto> ExpertiseDomains { get; set; }
        public IEnumerable<ScheduleDto> Schedules { get; set; }
    }
}
