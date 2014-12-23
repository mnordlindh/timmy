using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {
    public interface ITimeReportStorage {
        void Add(TimeReport timeReport);

        IQueryable<TimeReport> All();
    }

    public class TimeReportStorage : ITimeReportStorage {
        readonly List<TimeReport> _reports = new List<TimeReport>();

        public void Add(TimeReport timeReport) {
            _reports.Add(timeReport);    
        }

        public IQueryable<TimeReport> All() {
            return _reports.AsQueryable();
        }
    }
}
