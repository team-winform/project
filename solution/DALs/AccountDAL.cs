using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTOs;

namespace DALs
{
    public class AccountDAL
    {
        SqlConnection conn;

        public AccountDAL()
        {
            string conString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            conn = new SqlConnection(conString);
        }

        public List<AccountDTO> getTableAccounts()
        {
            conn.Open();
            List<AccountDTO> lstAccounts = new List<AccountDTO>();
            string query = "select * from account";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            try
            {
                while (rd.Read())
                {
                    AccountDTO acc = new AccountDTO();
                    acc.username = rd["username"].ToString();
                    acc.password = rd["password"].ToString();
                    acc.level = int.Parse(rd["level"].ToString());
                    acc.fullname = rd["fullname"].ToString();
                    acc.phone = rd["phone"].ToString();
                    lstAccounts.Add(acc);
                }
            }
            catch (SqlException sqle)
            {
                conn.Close();
                throw sqle;
            }
            conn.Close();
            return lstAccounts;
        }

        public void insertAccount(AccountDTO accountDTO)
        {
            conn.Open();
            string query = "insert into account(username, password, level, fullname, phone) values " +
                "(@username, @password, @level, @fullname, @phone)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", accountDTO.username);
            cmd.Parameters.AddWithValue("password", accountDTO.password);
            cmd.Parameters.AddWithValue("level", accountDTO.level);
            cmd.Parameters.AddWithValue("fullname", accountDTO.fullname);
            cmd.Parameters.AddWithValue("phone", accountDTO.phone);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqle)
            {
                conn.Close();
                throw sqle;
            }
            conn.Close();
        }

        public void updateAccount(AccountDTO accountDTO)
        {
            conn.Open();
            string query = "update account set " +
                "password = @password, " +
                "level = @level, " +
                "fullname = @fullname, " +
                "phone = @phone " +
                "where username = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("password", accountDTO.password);
            cmd.Parameters.AddWithValue("level", accountDTO.level);
            cmd.Parameters.AddWithValue("fullname", accountDTO.fullname);
            cmd.Parameters.AddWithValue("phone", accountDTO.phone);
            cmd.Parameters.AddWithValue("username", accountDTO.username);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
        }

        public void changeInfo(AccountDTO account, string fullname, string phone)
        {
            conn.Open();
            string query = "update account set " +
                "fullname = @fullname," +
                "phone = @phone " +
                "where username = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("fullname", fullname);
            cmd.Parameters.AddWithValue("phone", phone);
            cmd.Parameters.AddWithValue("username", account.username);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
        }

        public void changePassword(AccountDTO account, string newPassword)
        {
            conn.Open();
            string query = "update account set " +
                "password = @newPassword " +
                "where username = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("newPassword", newPassword);
            cmd.Parameters.AddWithValue("username", account.username);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
        }

        public void deleteAccount(AccountDTO accountDTO)
        {
            conn.Open();
            string query = "delete account where username = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", accountDTO.username);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }

        }

        public AccountDTO getAccount(string username, string password)
        {
            conn.Open();
            AccountDTO account = null;
            string query = "select * from account where username = @username and password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    account = new AccountDTO();
                    account.username = rd["username"].ToString();
                    account.password = rd["password"].ToString();
                    account.level = int.Parse(rd["level"].ToString());
                    account.fullname = rd["fullname"].ToString();
                    account.phone = rd["phone"].ToString();
                }
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
            return account;
        }

    }
}
