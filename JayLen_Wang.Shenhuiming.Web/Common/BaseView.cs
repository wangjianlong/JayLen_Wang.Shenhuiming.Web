using System;
using System.Threading;
using System.Web.Mvc;

namespace JayLen_Wang.Shenhuiming.Web.Common
{
    public class BaseView<TModel>:WebViewPage<TModel>
    {
        public UserIdentity Identity { get; private set; }
        public BaseView()
        {
            Identity = Thread.CurrentPrincipal.Identity as UserIdentity;
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}