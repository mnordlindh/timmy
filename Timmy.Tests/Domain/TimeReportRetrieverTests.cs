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
        [Test]
        public void GetTimeReports_CalledWithQuery_ShouldCallQueryForEachItem() {
            TimeReport tr1 = new TimeReport(default(User), default(DateTime), default(TimeSpan)),
                       tr2 = new TimeReport(default(User), default(DateTime), default(TimeSpan));

            var storageMock = Mock.Of<IQueryable<TimeReport>>(m => m.GetEnumerator() == new List<TimeReport> { tr1, tr2 }.AsQueryable().GetEnumerator());
            var query = new Mock<IQuery<TimeReport>>();

            var reports = new TimeReportRetriever(storageMock).GetTimeReports(query.Object);

            query.Verify(m => m.Match(tr1), Times.Once);
            query.Verify(m => m.Match(tr2), Times.Once);
        }
    }
}