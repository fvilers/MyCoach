using MyCoach.Business.Domain.Model;
using MyCoach.Services.Dtos;
using System;
using System.Linq;

namespace MyCoach.Web.MainSite.Mappers
{
    public class CoachDtoMapper : IMapper<Coach, CoachDto>
    {
        public CoachDto Map(Coach source)
        {
            if (source == null) throw new ArgumentNullException("source");

            var result = new CoachDto
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                Price = source.Price,
                Currency = source.Currency,
                Biography = source.Biography,
                Summary = source.Summary,
                SkypeId = source.SkypeId,
                ExpertiseDomains = source.ExpertiseDomains.Select(new ExpertiseDomainDtoMapper().Map).ToArray(),
                Schedules = source.Schedules.Select(new ScheduleDtoMapper().Map).ToArray()
            };

            return result;
        }
    }
}