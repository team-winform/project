using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALs;
using DTOs;

namespace BLLs
{
    public class QuanLyTaiKhoanBLL
    {
        AccountDAL accountDAL = new AccountDAL();

        public List<AccountDTO> getAccountTable()
        {
            return accountDAL.getTableAccounts();
        }

        public void addAccount(AccountDTO accountDTO)
        {
            if (accountDTO == null)
            {

            }
            else if (!accountDAL.isAccountExists(accountDTO.username))
            {
                accountDTO.password = Utils.MD5Hash(accountDTO.password);
                accountDAL.insertAccount(accountDTO);
            }
            else
                showMessageError("Tài khoản đã tồn tại");
        }

        public void updateAccount(AccountDTO accountDTO)
        {
            if (accountDTO != null)
            {
                accountDTO.password = Utils.MD5Hash(accountDTO.password);
                accountDAL.updateAccount(accountDTO);
            }
        }

        public void deleteAccount(string username)
        {
            if (username == "admin")
            {
                showMessageError("Không thể xoá tài khoản admin");
            }
            else if (username.Trim() == "")
                showMessageError("Username không được để trống");
            else
                accountDAL.deleteAccount(username);
        }

        public void showMessageError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
