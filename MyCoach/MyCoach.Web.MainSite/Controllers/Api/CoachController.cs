using MyCoach.Data.EntityFramework;
using MyCoach.Web.MainSite.Mappers;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MyCoach.Web.MainSite.Controllers.Api
{
    [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
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
        public IHttpActionResult Get([FromUri] int[] keywords = null)
        {
            var query = _coachContext.CoachProfiles.Include(x => x.ExpertiseDomains);

            if (keywords != null)
            {
                query = query.Where(coachProfile =>
                    keywords.All(keywordId => coachProfile.ExpertiseDomains.Any(expertiseDomain => keywordId == expertiseDomain.Id)));
            }

            var coachProfiles = query.ToArray();
            var mapper = new CoachProfileDtoMapper();
            var dtos = coachProfiles.Select(mapper.Map).ToArray();

            return Ok(dtos);
        }

        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            var query = from x in _coachContext.CoachProfiles.Include(x => x.ExpertiseDomains)
                        where x.Id == id
                        select x;
            var mapper = new CoachProfileDtoMapper();
            var coachProfile = query.FirstOrDefault();

            if (coachProfile == null)
            {
                return NotFound();
            }

            var dto = mapper.Map(coachProfile);

            return Ok(dto);
        }
    }
}
