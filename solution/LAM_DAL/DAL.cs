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

        public Dictionary<String,String> findKhoaHocByMa(String ma)
        {
            Dictionary<String, String> result = new Dictionary<string, string>();
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
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

        public DataTable getDiemDanh(String maLop)
        {
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select hv.id_HV,hv.ten_HV,hv.sodt_HV,count(dd.id) as 'nghi' from HOCVIEN as hv inner join HOCVIEN_LOPHOC as hl on hl.id_HV = hv.id_HV left join DiemDanh as dd on dd.id_HV = hv.id_HV where hl.id_LH = @maLop group by hv.id_HV,hv.ten_HV,hv.sodt_HV";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("maLop", maLop);
            SqlDataReader rd = command.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            conn.Close();
            return tb;
        }

        public DataTable getAllLopHoc()
        {
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select * from LOPHOC";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader rd = command.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            conn.Close();
            return tb;
        }

        public int diemDanh(String maHV,String maLH,DateTime date)
        {
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "insert into DiemDanh(id_HV,id_LH,ngayDiemDanh) values(@maHV,@maLH,@date)";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("maHV", maHV);
            command.Parameters.AddWithValue("maLH", maLH);
            command.Parameters.AddWithValue("date", date);
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public Boolean checkLopHocDaDiemDanh(DateTime date,String maLop)
        {
            String connectString = ConfigurationManager.ConnectionStrings["connectString"].ToString();
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select LOPHOC.ten_LH,DiemDanh.ngayDiemDanh from LOPHOC inner join DiemDanh on LOPHOC.id_LH=DiemDanh.id_LH where convert(varchar(10),DiemDanh.ngayDiemDanh,120) = convert(varchar(10),@now,120) and LOPHOC.id_LH=@ma";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("now", date);
            command.Parameters.AddWithValue("ma", maLop);
            SqlDataReader rd = command.ExecuteReader();
            Boolean result = rd.HasRows;
            conn.Close();
            return result;
        }
    }
}
