using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;

namespace Models
{
    [MetadataType(typeof(UsersMeta))]
    public partial class Users : IUser<string>
    {
        private string _userRole;

        public virtual string FullName
        {
            get { return FirstName + " " + LastName; }
        }


        public string UserRole
        {
            get
            {
                if (string.IsNullOrEmpty(_userRole))
                {
                    _userRole = string.Join(",", UserRoles.Select(m => m.Name));
                }
                return _userRole;
            }
            set => _userRole = value;
        }

        [NotMapped]
        public string Password { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Users, string> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            userIdentity.AddClaim(new Claim("FullName", this.FullName));
            userIdentity.AddClaim(new Claim("Email", this.Email));
            userIdentity.AddClaim(new Claim("UserRoles", this.UserRole));
            return userIdentity;
        }


    }


    public class UsersMeta
    {
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }

    }
}