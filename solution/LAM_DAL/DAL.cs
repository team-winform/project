using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace LAM_DAL
{
    public class DAL
    {

        public DataTable getAllKhoaHoc()
        {
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select * from KHOAHOC";
            SqlCommand command = new SqlCommand(sql,conn);
            SqlDataReader rd = command.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            conn.Close();
            return tb;
        }

        public int addKhoaHoc(String ma,String ten,int gia,DateTime ngayTao,DateTime ngaySua,String ghiChu)
        {
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
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
            int result=command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public int updateKhoaHoc(String ma, String ten, int gia, DateTime ngayTao, DateTime ngaySua, String ghiChu)
        {
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
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
    }
}
