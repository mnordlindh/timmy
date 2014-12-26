using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timmy.Domain;

namespace Timmy.Tests.Domain {
    class TimeReporterTests {
        [Test]
        public void ReportTime_WithValidArguments_ShouldStoreTimeReport() {
            var storageMock = new Mock<IPersistor<TimeReport>>();

            new TimeReporter(storageMock.Object)
                .ReportTime(new User("123"), DateTime.Now, TimeSpan.FromHours(8));
            
            storageMock.Verify(m => m.Add(It.IsAny<TimeReport>()), Times.Once);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReportTime_WithNullUserArgument_ShouldThrow() {
            var storageMock = new Mock<IPersistor<TimeReport>>();

            new TimeReporter(storageMock.Object)
                .ReportTime(null, DateTime.Now, TimeSpan.FromHours(8));
        }

        // tests for rest of arguments, throws..
    }
}
