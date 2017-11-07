using System;
using System.Web;
using System.Web.Mvc;

namespace JayLen_Wang.Shenhuiming.Web.Common
{
    [AttributeUsage(AttributeTargets.All,Inherited =true)]
    public class UserAuthorizeAttribute:System.Web.Mvc.AuthorizeAttribute
    {
        private bool _enable { get; set; }
        public UserAuthorizeAttribute(bool enable = true)
        {
            _enable = enable;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return httpContext.User.Identity.IsAuthenticated;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (_enable)
            {
                var returnUrl = filterContext.HttpContext.Request.Url.AbsoluteUri;
                filterContext.HttpContext.Response.Redirect("/user/login?returnUrl=" + HttpUtility.UrlEncode(returnUrl));
            }
        }
    }
}