using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Api.Models.AuthModels
{
    /// <summary>
    /// ApplicationUser class will inherit the class IdentityUser so that we can add a field Name to User's Identity table in database
    /// </summary>
    public class ApplicationUser : IdentityUser
    {

        /// <summary>
        /// Gets or sets the name of the user. Maximum length is 30 characters.
        /// </summary>
        [MaxLength(30)]
        public string? Name { get; set; }
    }
}
