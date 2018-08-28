using System;
using System.Collections.Generic;

/// <summary>
/// <author>Billy Gates</author>
/// </summary>
namespace Users.Roles
{
    /// <summary>
    /// TODO: Extract an interface
    /// </summary>
    public class UserRolesService
    {
        public IEnumerable<string> FindUsersByRole(string roleName)
        {
            var mockUserRoles = new Dictionary<string, List<string>>
            {
                { "admin", new List<string>(new string[] { "billy" }) },
                { "gues", new List<string>(new string[] { "donald" }) },
                { "writer", null }
            };

            return mockUserRoles[roleName];
        }
    }
}
