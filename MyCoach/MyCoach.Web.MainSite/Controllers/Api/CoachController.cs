﻿using MyCoach.Business.Domain.Model;
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
        public IHttpActionResult Get()
        {
            var keywords = _coachContext.ApplicationUsers.OfType<Coach>().Include(x => x.ExpertiseDomains).ToArray();
            var mapper = new CoachDtoMapper();
            var dtos = keywords.Select(mapper.Map).ToArray();

            return Ok(dtos);
        }
    }
}
