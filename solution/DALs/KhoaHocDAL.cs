using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DALs
{
    public class KhoaHocDAL
    {
        private String connectString;
        public KhoaHocDAL()
        {
            this.connectString = ConfigurationManager.ConnectionStrings["conString"].ToString();
        }

        public DataTable getAllKhoaHoc()
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select * from KHOAHOC";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader rd = command.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            conn.Close();
            return tb;
        }

        public int addKhoaHoc(String ma, String ten, int gia, DateTime ngayTao, DateTime ngaySua, String ghiChu)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "insert into KHOAHOC values(@ma,@ten,@gia,@ngayTao,@ngaySua,@ghiChu)";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("ma", ma);
            command.Parameters.AddWithValue("ten", ten);
            command.Parameters.AddWithValue("gia", gia);
            command.Parameters.AddWithValue("ngayTao", ngayTao);
            command.Parameters.AddWithValue("ngaySua", ngaySua);
            command.Parameters.AddWithValue("ghiChu", ghiChu);
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }


        public int updateKhoaHoc(String ma, String ten, int gia, DateTime ngayTao, DateTime ngaySua, String ghiChu)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "update KHOAHOC set ten_KH=@ten,gia_KH=@gia,ngaysua=@ngaySua,ghichu_KH=@ghiChu where id_KH=@ma";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("ten", ten);
            command.Parameters.AddWithValue("gia", gia);
            command.Parameters.AddWithValue("ngaySua", ngaySua);
            command.Parameters.AddWithValue("ghiChu", ghiChu);
            command.Parameters.AddWithValue("ma", ma);
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public int deleteKhoaHoc(String ma)
        {
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "delete from KHOAHOC where id_KH=@ma";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("ma", ma);
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public Dictionary<String, String> findKhoaHocByMa(String ma)
        {
            Dictionary<String, String> result = new Dictionary<string, string>();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select * from KHOAHOC where id_KH=@ma";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("ma", ma);
            SqlDataReader rd = command.ExecuteReader();
            while (rd.Read())
            {
                result.Add("ten_KH", rd["ten_KH"].ToString());
                result.Add("gia_KH", rd["gia_KH"].ToString());
                result.Add("ghichu_KH", rd["ghichu_KH"].ToString());
            }
            conn.Close();
            return result;
        }
    }
}
