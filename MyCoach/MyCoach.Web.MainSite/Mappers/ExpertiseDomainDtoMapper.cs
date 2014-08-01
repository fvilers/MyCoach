using MyCoach.Business.Domain.Model;
using MyCoach.Services.Dtos;
using System;

namespace MyCoach.Web.MainSite.Mappers
{
    public class ExpertiseDomainDtoMapper : IMapper<ExpertiseDomain, ExpertiseDomainDto>
    {
        public ExpertiseDomainDto Map(ExpertiseDomain source)
        {
            if (source == null) throw new ArgumentNullException("source");

            var result = new ExpertiseDomainDto
            {
                Id = source.Id,
                Name = source.Name,
                Slug = source.Slug
            };

            return result;
        }
    }
}