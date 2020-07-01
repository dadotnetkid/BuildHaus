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
       
    }
}
