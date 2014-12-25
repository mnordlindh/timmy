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
    }
}
