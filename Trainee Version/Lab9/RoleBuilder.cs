using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab9
{
    class RoleBuilder
    {
     
        private static string[] Roles = { "UNDEFINED", "DEVELOPER", "TEST_ENGINEER", "SR_DEVELOPER", "DESIGNER" };

        // GetRoleDescription return the roles of employees respect to RoleId
        public static string GetRoleDescription(int RoleId)
        {
           if(RoleId > 4 || RoleId < 1)
                return Roles[0];
           else
                return Roles[RoleId];
        }
    }
}
