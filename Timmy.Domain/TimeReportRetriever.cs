using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {
    public class TimeReportRetriever {
        private IQueryable<TimeReport> _retriever;

        public TimeReportRetriever(IQueryable<TimeReport> retriever) {
            _retriever = retriever;
        }

        public IEnumerable<TimeReport> GetTimeReports(IQuery<TimeReport> query) {
            return _retriever.Where(query.Match).ToList();
        }
    }
}