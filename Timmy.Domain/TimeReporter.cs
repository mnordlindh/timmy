using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {
    public class TimeReporter {
        IPersistor<TimeReport> _persistor;

        public TimeReporter(IPersistor<TimeReport> persistor) {
            _persistor = persistor;
        }

        public void ReportTime(User user, DateTime reportedDate, TimeSpan timespan) {
            _persistor.Add(new TimeReport(user, reportedDate, timespan));
        }
    }
}
