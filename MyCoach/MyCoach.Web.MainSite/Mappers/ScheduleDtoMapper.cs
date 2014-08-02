using MyCoach.Business.Domain.Model;
using MyCoach.Services.Dtos;
using System;

namespace MyCoach.Web.MainSite.Mappers
{
    public class ScheduleDtoMapper: IMapper<Schedule, ScheduleDto>
    {
        public ScheduleDto Map(Schedule source)
        {
            if (source == null) throw new ArgumentNullException("source");

            var result = new ScheduleDto
            {
                StartDateTime = source.StartDateTime,
                Duration =  source.Duration
            };

            return result;
        }
    }
}