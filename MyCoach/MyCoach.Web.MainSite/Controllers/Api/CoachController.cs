using MyCoach.Data.EntityFramework;
using MyCoach.Web.MainSite.Mappers;
using System;
using System.Linq;
using System.Web.Http;

namespace MyCoach.Web.MainSite.Controllers.Api
{
    [RoutePrefix("api/coaches")]
    public class CoachController : ApiController
    {
        private readonly IMyCoachContext _coachContext;

        public CoachController(IMyCoachContext coachContext)
        {
            if (coachContext == null) throw new ArgumentNullException("coachContext");
            _coachContext = coachContext;
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            var keywords = _coachContext.CoachProfiles.ToArray();
            var mapper = new CoachProfileDtoMapper();
            var dtos = keywords.Select(mapper.Map).ToArray();

            return Ok(dtos);
        }
    }
}
