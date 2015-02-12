using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginsSchedule.Data
{
    public interface IOriginsScheduleRepository
    {
        IQueryable<Event> GetEvents();
        
        bool Save();

        
    }
}
