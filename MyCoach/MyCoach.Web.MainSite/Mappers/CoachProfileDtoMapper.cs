using MyCoach.Business.Domain.Model;
using MyCoach.Services.Dtos;
using System;

namespace MyCoach.Web.MainSite.Mappers
{
    public class CoachProfileDtoMapper : IMapper<CoachProfile, CoachProfileDto>
    {
        public CoachProfileDto Map(CoachProfile source)
        {
            if (source == null) throw new ArgumentNullException("source");

            var result = new CoachProfileDto
            {
            };

            return result;
        }
    }
}