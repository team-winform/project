using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;

namespace BLLs
{
    public class LoginBLL
    {
        AccountDAL accDAL = new AccountDAL();
        
        public LoginBLL()
        {
        }

        public AccountDTO login(string username, string password)
        {
            return accDAL.getAccount(username, password);
        }
    }
}
