using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timmy.Domain;
using FluentAssertions;

namespace Timmy.Tests.Domain.Queries {
    class TimeReportsForUserQueryTests {
        [Test]
        public void Match_CalledWithMatchingUser_ShouldReturnTrue() {
            var user = new User("123");

            var result = new TimeReportsForUserQuery(user).Match(new TimeReport(user, default(DateTime), default(TimeSpan)));

            result.Should().BeTrue();
        }

        [Test]
        public void Match_CalledWithNonMatchingUser_ShouldReturnFalse() {
            var user = new User("123");

            var result = new TimeReportsForUserQuery(user).Match(new TimeReport(new User("456"), default(DateTime), default(TimeSpan)));

            result.Should().BeFalse();
        }
    }
}
