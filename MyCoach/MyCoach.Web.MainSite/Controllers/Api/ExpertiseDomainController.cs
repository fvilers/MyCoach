using MyCoach.Data.EntityFramework;
using MyCoach.Web.MainSite.Mappers;
using System;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MyCoach.Web.MainSite.Controllers.Api
{
    [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
    [RoutePrefix("api/expertise-domains")]
    public class ExpertiseDomainController : ApiController
    {
        private readonly IMyCoachContext _coachContext;

        public ExpertiseDomainController(IMyCoachContext coachContext)
        {
            if (coachContext == null) throw new ArgumentNullException("coachContext");
            _coachContext = coachContext;
        }

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var keywords = _coachContext.Keywords.ToArray();
            var mapper = new ExpertiseDomainDtoMapper();
            var dtos = keywords.Select(mapper.Map).ToArray();

            return Ok(dtos);
        }
    }
}
