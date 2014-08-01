using MyCoach.Data.EntityFramework;
using MyCoach.Web.MainSite.Mappers;
using System;
using System.Linq;
using System.Web.Http;

namespace MyCoach.Web.MainSite.Controllers.Api
{
    [RoutePrefix("api/keywords")]
    public class KeywordController : ApiController
    {
        private readonly IMyCoachContext _coachContext;

        public KeywordController(IMyCoachContext coachContext)
        {
            if (coachContext == null) throw new ArgumentNullException("coachContext");
            _coachContext = coachContext;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var keywords = _coachContext.Keywords.ToArray();
            var mapper = new KeywordDtoMapper();
            var dtos = keywords.Select(mapper.Map).ToArray();

            return Ok(dtos);
        }
    }
}
