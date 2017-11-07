using JayLen_Wang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace JayLen_Wang.Shenhuiming.Web.Common
{
    public class UserRoleAttribute:System.Web.Mvc.ActionFilterAttribute
    {
        public UserRoleAttribute()
        {
            Role = Role.Guest;
        }

        public Role Role { get; set; }
        public bool Mode { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Role == Role.Guest)
            {
                return;
            }
            var currentUser = (UserIdentity)Thread.CurrentPrincipal.Identity;
            if (Mode)
            {
                if (currentUser.Role != Role)
                {
                    throw new HttpException(401, "您没有权限查看此页面");
                }
            }
            else
            {
                if (currentUser.Role == Role)
                {
                    throw new HttpException(401, "您没有权限查看此页面");
                }
            }

            return;
        }

    }
}