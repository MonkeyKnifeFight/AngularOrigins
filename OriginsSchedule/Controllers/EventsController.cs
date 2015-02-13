using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OriginsSchedule.Data;

namespace OriginsSchedule.Controllers
{
    public class EventsController : ApiController
    {
        private IOriginsScheduleRepository _repo;
        public EventsController(IOriginsScheduleRepository repo)
        {
            _repo = repo;
        }
        
        public IEnumerable<Event> Get()
        {
            IQueryable<Event> results;

                           results = _repo.GetEvents();
            
            var Events = results.OrderByDescending(t => t.eventcategory)
                                .Take(10000)
                                .ToList();

            return Events;
        }

        
    }
}
