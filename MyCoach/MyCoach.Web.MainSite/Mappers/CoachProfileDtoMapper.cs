using MyCoach.Business.Domain.Model;
using MyCoach.Services.Dtos;
using System;
using System.Linq;

namespace MyCoach.Web.MainSite.Mappers
{
    public class CoachProfileDtoMapper : IMapper<CoachProfile, CoachProfileDto>
    {
        public CoachProfileDto Map(CoachProfile source)
        {
            if (source == null) throw new ArgumentNullException("source");

            var result = new CoachProfileDto
            {
                Id = source.Id,
                FirstName = source.FirstName,
                LastName = source.LastName,
                Price = source.Price,
                Currency = source.Currency,
                Biography = source.Biography,
                ExpertiseDomains = source.ExpertiseDomains.Select(new ExpertiseDomainDtoMapper().Map).ToArray()
            };

            return result;
        }
    }
}