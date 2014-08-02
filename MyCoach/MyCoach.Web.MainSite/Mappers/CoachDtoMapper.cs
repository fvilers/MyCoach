using MyCoach.Business.Domain.Model;
using MyCoach.Services.Dtos;
using System;
using System.Linq;

namespace MyCoach.Web.MainSite.Mappers
{
    public class CoachDtoMapper : IMapper<Coach, CoachDto>, IMapper<Coach, Func<int, string>, CoachDto>
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

        public CoachDto Map(Coach source1, Func<int, string> source2)
        {
            if (source1 == null) throw new ArgumentNullException("source1");
            if (source2 == null) throw new ArgumentNullException("source2");

            var result = Map(source1);

            if (source1.Photo != null)
            {
                result.PhotoUrl = source2(source1.Photo.Id);
            }

            return result;
        }
    }
}