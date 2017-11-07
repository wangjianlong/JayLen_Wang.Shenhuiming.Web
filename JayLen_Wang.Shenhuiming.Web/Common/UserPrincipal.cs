using JayLen_Wang.Models;
using System;
using System.Security.Principal;

namespace JayLen_Wang.Shenhuiming.Web.Common
{
    public class UserPrincipal:System.Security.Principal.IPrincipal
    {

        public UserPrincipal(IIdentity identity)
        {
            Identity = identity;
        }

        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }


    public class UserIdentity : System.Security.Principal.IIdentity
    {
        public static readonly UserIdentity Guest = new UserIdentity() {Role=Role.Guest };

        public int UserId { get; set; }
        public string LoginName { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public string AuthenticationType { get { return "Web.Session"; } }
        public bool IsAuthenticated
        {
            get { return UserId > 0; }
        }
    }
}