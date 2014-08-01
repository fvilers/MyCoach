using MyCoach.Business.Domain.Model;
using MyCoach.Services.Dtos;
using System;

namespace MyCoach.Web.MainSite.Mappers
{
    public class KeywordDtoMapper : IMapper<Keyword, KeywordDto>
    {
        public KeywordDto Map(Keyword source)
        {
            if (source == null) throw new ArgumentNullException("source");

            var result = new KeywordDto
            {
                Id = source.Id,
                Name = source.Name,
                Slug = source.Slug
            };

            return result;
        }
    }
}