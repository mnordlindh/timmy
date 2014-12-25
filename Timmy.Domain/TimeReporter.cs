using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {
    public class TimeReporter {
        ITimeReportStorage _storage;

        public TimeReporter(ITimeReportStorage storage) {
            _storage = storage;
        }

        public void ReportTime(User user, DateTime reportedDate, TimeSpan timespan) {
            _storage.Add(new TimeReport(user, reportedDate, timespan));
        }
    }
}
