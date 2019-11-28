using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALs;
using DTOs;
using System.Data.SqlClient;

namespace BLLs
{
    public class TaiKhoanCuaToiBLL
    {
        AccountDAL accDAL = new AccountDAL();
        public void doiThongTinCaNhan(AccountDTO accDTO, string fullname, string phone)
        {

            accDAL.changeInfo(accDTO, fullname, phone);
            GlobalInfo.accountGlobal = accDAL.getAccount(accDTO.username, accDTO.password);

        }

        public void doiMatKhau(string matkhauhientai, string matKhauMoi1, string matKhauMoi2)
        {
            if (!matKhauMoi1.Equals(matKhauMoi2))
                throw new Exception("Mật khẩu mới phải nhập trùng khớp");
            else if (!Utils.MD5Hash(matkhauhientai).Equals(GlobalInfo.accountGlobal.password))
            {
                throw new Exception("Mật khẩu cũ không đúng");
            }
            else
            {
                accDAL.changePassword(GlobalInfo.accountGlobal, Utils.MD5Hash(matKhauMoi1));
            }

        }

        public void dangXuat()
        {
            GlobalInfo.accountGlobal = null;
        }
    }
}
