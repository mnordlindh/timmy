//using NUnit.Framework;
//using System;
//using TechTalk.SpecFlow;
//using Timmy.Domain;

//namespace Timmy.Specs {
//    [Binding]
//    public class ConsultantReportsTimeSteps {
//        TimeReporter _timeReporter = new TimeReporter(new TimeReportStorage());
//        User _user = new User("123");
//        DateTime _reportedTime = DateTime.Parse("2014-12-23");

//        [When(@"a consultant reports (.*) hours")]
//        public void WhenAConsultantReportsHours(int hours) {
//            _timeReporter.ReportTime(_user, _reportedTime, TimeSpan.FromHours(hours));
//        }

//        [Then(@"the time report for that day should state (.*) hours")]
//        public void ThenTheTimeReportForThatDayShouldStateHours(int hours) {
//            var timeReport = _timeReporter.GetTimeReport(_user, _reportedTime);

//            Assert.AreEqual(timeReport.TimeSpan.Hours, hours);
//        }
//    }
//}
