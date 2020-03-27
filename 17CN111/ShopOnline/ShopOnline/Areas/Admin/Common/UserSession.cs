using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Areas.Admin.Common
{
    [Serializable]
    public class UserSession
    {
        public string UserName { set; get; }
    }
}