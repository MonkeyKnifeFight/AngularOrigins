using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginsSchedule.Data
{
    public class Event
    {
        public string id { get; set; }
        public double eventnumber { get; set; }
        public string eventname { get; set; }
        public string featuretextdescription { get; set; }
        public Nullable<double> price { get; set; }
        public string eventcategory { get; set; }
        public Nullable<DateTimeOffset> eventdatestarttime { get; set; }
        public Nullable<double> maximumplayers { get; set; }
        
    }
}
