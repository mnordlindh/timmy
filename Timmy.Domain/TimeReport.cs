using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timmy.Domain {
    public class TimeReport {
        public readonly User User;
        public readonly DateTime Time;
        public readonly TimeSpan TimeSpan;

        public TimeReport(User user, DateTime time, TimeSpan timespan) {
            User = user;
            Time = time;
            TimeSpan = timespan;
        }
    }
}
