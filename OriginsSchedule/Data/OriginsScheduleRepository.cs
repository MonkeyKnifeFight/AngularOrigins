using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginsSchedule.Data
{
    public class OriginsScheduleRepository : IOriginsScheduleRepository
    {
        OriginsScheduleContext _ctx;
        public OriginsScheduleRepository(OriginsScheduleContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Event> GetEvents()
        {
            return _ctx.Events;
        }

        

        public bool Save()
        {
            try
            {
                return _ctx.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // TODO log this error
                return false;
            }
        }

        


        //public IQueryable<Topic> GetTopicsIncludingReplies()
        //{
        //    return _ctx.Topics.Include("Replies");
        //}


        
    }
}