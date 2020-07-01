using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.Identity;
using Models.Repository;

namespace Helpers
{
    public class OnUserAuthorizationAttribute : AuthorizeAttribute
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        
    }
}
