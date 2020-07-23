using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Repository;

namespace Models
{
    public static class User
    {
        public static string UserId { get; set; }

        public static string GetUserName() =>
            new UnitOfWork().UsersRepo.Fetch(m => m.Id == UserId).Select(x => new { x.UserName }).FirstOrDefault()?.UserName;
        public static string GetFullName() =>
            new UnitOfWork().UsersRepo.Fetch(m => m.Id == UserId).Select(x => new { FullName = x.FirstName + " " + x.LastName }).FirstOrDefault()?.FullName;

        public static bool UserIsInRoles(string userRole)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var user = unitOfWork.UsersRepo.Fetch(x => x.UserRoles.Any(m => m.Name == userRole)).Any();
            if (user)
                return true;
            MessageBox.Show(
                @"You dont have any permission to access this method 
 Please Contact System Administrator", @"Access Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
