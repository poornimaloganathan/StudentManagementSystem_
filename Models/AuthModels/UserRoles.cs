using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Api.Models.AuthModels
{
    /// <summary>
    /// A static class that defines the available user roles in the application.
    /// </summary>
    public static class UserRoles
    {
        /// <summary>
        /// The role name for the administrator.
        /// </summary>
        public const string Admin = "Admin";

        /// <summary>
        /// The role name for regular users.
        /// </summary>
        public const string User = "User";
    }
}
