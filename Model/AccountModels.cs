using Model.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AccountModels
    {
        private OnlineTestDbContext context = null;

        public AccountModels()
        {
            this.context = new OnlineTestDbContext();
        }

        public bool Login(string username, string password)
        {
            object[] sqlParams = {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password)
            };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login @username,@password",sqlParams).SingleOrDefault();
            return res;
        }
    }
}
