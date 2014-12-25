using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {
    public class TimeReportRetriever {
        private ITimeReportStorage _storage;

        public TimeReportRetriever(ITimeReportStorage storage) {
            _storage = storage;
        }

        public IEnumerable<TimeReport> GetTimeReports(IQuery<TimeReport> query) {
            return _storage.All().Where(tr => query.Match(tr)).ToList();
        }
    }
}