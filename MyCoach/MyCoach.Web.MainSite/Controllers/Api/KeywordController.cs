using MyCoach.Business.Domain.Model;
using MyCoach.Web.MainSite.Mappers;
using System.Linq;
using System.Web.Http;

namespace MyCoach.Web.MainSite.Controllers.Api
{
    [RoutePrefix("api/keywords")]
    public class KeywordController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var keywords = new[]
            {
                new Keyword { Name = "Développement" },
                new Keyword { Name = "Yoga" },
                new Keyword { Name = "Cryptographique" }
            };
            var dtos = keywords.Select(new KeywordDtoMapper().Map).ToArray();

            return Ok(dtos);
        }
    }
}
