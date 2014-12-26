using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Timmy.Domain;
using FluentAssertions;

namespace Timmy.Specs {
    [Binding]
    public class ViewTimeReportsSteps {
        private ITimeReportRetriever _retriever;
        private User _user;

        [Given(@"a user have time reports")]
        public void GivenAUserHaveTimeReports() {
            _user = new User("123");
            var _storage = Mock.Of<IQueryable<TimeReport>>(m => m.GetEnumerator() == new List<TimeReport>() {
                new TimeReport(_user, default(DateTime), default(TimeSpan))                
            }.AsQueryable().GetEnumerator());

            _retriever = new TimeReportRetriever(_storage);
        }

        [When(@"the user visits the ""(.*)""")]
        public void WhenTheUserVisitsThe(string page) {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"the user should see all his time reports")]
        public void ThenTheUserShouldSeeAllHisTimeReports() {
            var reports = _retriever.GetTimeReports(new TimeReportsForUserQuery(_user));

            reports.Should().NotBeEmpty();
        }
    }
}
