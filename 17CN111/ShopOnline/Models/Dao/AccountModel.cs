using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dao
{
    public class AccountModel : IDisposable
    {
        ShopOnlineDbContext context;
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }
        public AccountModel()
        {
            context = new ShopOnlineDbContext();
        }

        public bool Login(string UserName,string PassWord)
        {
            object[] param=new SqlParameter[]
            {
                new SqlParameter("@UserName",UserName),
                new SqlParameter("@PassWord",PassWord)

            };
            var result = context.Database.SqlQuery<bool>("SP_Account_Login @UserName,@PassWord", param).SingleOrDefault();
            return result;
        }
    }
}
