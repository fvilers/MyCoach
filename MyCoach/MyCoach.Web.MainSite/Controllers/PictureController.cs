using MyCoach.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MyCoach.Web.MainSite.Controllers
{
    [RoutePrefix("pictures")]
    public class PictureController : Controller
    {
        private readonly IMyCoachContext _coachContext;

        public PictureController(IMyCoachContext coachContext)
        {
            if (coachContext == null) throw new ArgumentNullException("coachContext");
            _coachContext = coachContext;
        }

        [Route("{id:int}", Name = "GetPicture")]
        public async Task<ActionResult> Get(int id)
        {
            var query = from x in _coachContext.Images
                        where x.Id == id
                        select x;
            var picture = await query.FirstOrDefaultAsync();

            if (picture == null)
            {
                return HttpNotFound();
            }

            return File(picture.Content, picture.ContentType);
        }
    }
}
