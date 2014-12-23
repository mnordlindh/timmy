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

        public TimeReport GetTimeReport(User _user, DateTime _reportedTime) {
            return _storage.All().FirstOrDefault(tr => tr.User.Id == _user.Id && tr.Time.Date == _reportedTime.Date);
        }
    }
}
