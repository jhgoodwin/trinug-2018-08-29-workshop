using System;
using System.Collections.Generic;
using Users.Roles;
using Xunit;

namespace User.Roles.Tests
{
    public class UserRolesServiceTest
    {
        /// <summary>
        /// As as a developer without any requirements, I have no clue what I need to return in edge cases
        /// so I am just going to do whatever!.
        /// </summary>
        [Fact]
        public void UserRolesServiceTest_FindUsersByRole_WhenWriter_AlwaysReturnsNully()
        {
            var svc = new UserRolesService();

            var actual = svc.FindUsersByRole("writer");

            Assert.Null(actual); // No writers allowed
        }

        /// <summary>
        /// As an API consumer, I would like to get a list of all users belonging to a given group 
        /// so that I can iterate over them.
        /// </summary>
        [Fact]
        public void UserRolesServiceTest_FindUsersByRole_Always_Iterable()
        {
            var svc = new UserRolesService();

            var actual = svc.FindUsersByRole("writer");

            // oops, I cant iterate over null!
            Assert.IsAssignableFrom<IEnumerable<string>>(actual);
        }
    }
}
