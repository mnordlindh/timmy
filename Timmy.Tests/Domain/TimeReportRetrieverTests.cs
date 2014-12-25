using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timmy.Domain;
using FluentAssertions;
using NUnit.Framework;
using Moq;

namespace Timmy.Tests.Domain {
    class TimeReportRetrieverTests {
        //[Test]
        //public void GetTimeReports_CalledWithUser_ShouldRetriveTimeReportsForUser() {
        //    var user = new User("123");
        //    var expected = new List<TimeReport> {
        //        new TimeReport(user, default(DateTime), default(TimeSpan)),
        //        new TimeReport(new User("456"), default(DateTime), default(TimeSpan))
        //    };
        //    var storageMock = Mock.Of<ITimeReportStorage>(m => m.All() == expected);

        //    var reports = new TimeReportRetriever(storageMock).GetTimeReports(new TimeReportsForUserQuery(user));

        //    reports.Should().OnlyContain(tr => tr.User.Id == user.Id);
        //}

        //[Test]
        //public void GetTimeReports_CalledWithUser_ShouldRetriveExistingTimeReportsFromStorage() {
        //    var user = new User("123");
            
        //    var expected = new List<TimeReport> {
        //        new TimeReport(user, default(DateTime), default(TimeSpan)),
        //        new TimeReport(user, default(DateTime), default(TimeSpan))
        //    };
        //    var storageMock = Mock.Of<ITimeReportStorage>(m => m.All() == expected);

        //    var reports = new TimeReportRetriever(storageMock).GetTimeReports(new TimeReportsForUserQuery(user));

        //    reports.ShouldAllBeEquivalentTo(expected);
        //}

        [Test]
        public void GetTimeReports_CalledWithQuery_ShouldCallQueryForEachItem() {
            var storageMock = Mock.Of<ITimeReportStorage>(m => m.All() == new List<TimeReport> {
                new TimeReport(default(User), default(DateTime), default(TimeSpan)),
                new TimeReport(default(User), default(DateTime), default(TimeSpan))
            });
            var query = new Mock<IQuery<TimeReport>>();
            query.Setup(m => m.Match(It.IsAny<TimeReport>())).Verifiable();

            var reports = new TimeReportRetriever(storageMock).GetTimeReports(query.Object);

            query.Verify(m => m.Match(It.IsAny<TimeReport>()), Times.Exactly(2));
        }
    }
}
