using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {
    public class TimeReportsForUserQuery : IQuery<TimeReport> {
        private User _user;

        public TimeReportsForUserQuery(User user) {
            _user = user;
        }

        public bool Match(TimeReport report) {
            return _user.Id == report.User.Id;
        }
    }
}
