using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OriginsSchedule.Data
{
    public class OriginsScheduleContext : DbContext
    {
    public OriginsScheduleContext()
      : base("AzureConnection")
    {
      this.Configuration.LazyLoadingEnabled = false;
      this.Configuration.ProxyCreationEnabled = false;

      Database.SetInitializer(
        new MigrateDatabaseToLatestVersion<OriginsScheduleContext, OriginsScheduleMigrationsConfiguration>()
        );
    }

    public DbSet<Event> Events { get; set; }
    

  }
}