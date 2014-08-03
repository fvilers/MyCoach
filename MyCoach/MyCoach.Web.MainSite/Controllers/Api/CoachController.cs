using Antlr.Runtime.Tree;
using MyCoach.Business.Domain.Model;
using MyCoach.Data.EntityFramework;
using MyCoach.Web.MainSite.Mappers;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MyCoach.Web.MainSite.Controllers.Api
{
    [EnableCors(origins: "http://localhost:8000", headers: "*", methods: "*")]
    [RoutePrefix("api/coaches")]
    public class CoachController : ApiController
    {
        private const decimal Delta = 0.20m;
        private readonly IMyCoachContext _coachContext;

        public CoachController(IMyCoachContext coachContext)
        {
            if (coachContext == null) throw new ArgumentNullException("coachContext");
            _coachContext = coachContext;
        }

        private IQueryable<Coach> Coaches
        {
            get
            {
                return _coachContext.ApplicationUsers.OfType<Coach>()
                                                    .Include(x => x.ExpertiseDomains)
                                                    .Include(x => x.Photo)
                                                    .Include(x => x.Schedules);
            }
        }

        [Route("")]
        public async Task<IHttpActionResult> Get([FromUri(Name = "keyword")] int[] keywords = null, [FromUri] decimal? price = null, [FromUri]  int page = 1, [FromUri] int pageSize = 10)
        {
            var query = Coaches;

            if (keywords != null)
            {
                query = query.Where(coach =>
                    keywords.All(keywordId => coach.ExpertiseDomains.Any(expertiseDomain => keywordId == expertiseDomain.Id)));
            }

            if (price != null)
            {
                query = query.Where(coach => coach.Price * (1 - Delta) <= price && coach.Price * (1 + Delta) >= price);
            }

            query = query.OrderBy(x => x.Id); // TODO: sort on schedules

            var totalCount = await query.CountAsync();
            var coaches = await query.Skip((page - 1) * pageSize).Take(pageSize).ToArrayAsync();

            var mapper = new CoachDtoMapper();
            var dtos = coaches.Select(coach => mapper.Map(coach, id => Url.Link("GetPicture", new { id }))).ToArray();
            var allFetched = ((page - 1) * pageSize + coaches.Count()) == totalCount;

            return Ok(new
            {
                coaches = dtos,
                coachesCount = totalCount,
                allFetched = allFetched

            });
        }

        [Route("{id:int}")]
        public async Task<IHttpActionResult> Get(int id)
        {
            var query = from x in Coaches
                        where x.Id == id
                        select x;
            var mapper = new CoachDtoMapper();
            var coach = await query.FirstOrDefaultAsync();

            if (coach == null)
            {
                return NotFound();
            }

            var dto = mapper.Map(coach, pictureId => Url.Link("GetPicture", new { id = pictureId }));

            return Ok(dto);
        }
    }
}
