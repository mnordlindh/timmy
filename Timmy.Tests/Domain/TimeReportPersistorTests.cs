using Moq;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timmy.Domain;
using FluentAssertions;

namespace Timmy.Tests.Domain {
    class TimeReportListPersistorTests {
        [Test]
        public void Add_ShouldPersistTimeReport() {
            var timeReport = new TimeReport(default(User), default(DateTime), default(TimeSpan));

            var listMock = new Mock<ICollection<TimeReport>>();

            var listPersistor = new ListPersistor<TimeReport>(listMock.Object);

            listPersistor.Add(timeReport);

            listMock.Verify(m => m.Add(timeReport), Times.Once);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Add_TimeReportIsNull_ShouldThrow() {
            var listMock = new Mock<ICollection<TimeReport>>();

            var listPersistor = new ListPersistor<TimeReport>(listMock.Object);

            listPersistor.Add(null);
        }
    }
}