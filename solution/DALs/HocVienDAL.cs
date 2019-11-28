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
    public class HocVienDAL
    {
        String conString;
        public HocVienDAL()
        {
            this.conString = ConfigurationManager.ConnectionStrings["conString"].ToString();
        }

        public DataTable getListHocVien(String maLop)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            String sql = "select hv.* from HocVien hv inner join HocVien_LopHoc hvlh on hv.id_HV=hvlh.id_HV where hvlh.id_LH=@maLop";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("maLop", maLop);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            con.Close();
            return tb;
        }

        public int add(String ma,String ten,String sdt,DateTime ngaySinh,String diaChi,DateTime ngayTao)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            String sql = "insert into HocVien values(@ma,@ten,@sdt,@ngaySinh,@diaChi,@ngayTao,NULL)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("sdt", sdt);
            cmd.Parameters.AddWithValue("ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("diaChi", diaChi);
            cmd.Parameters.AddWithValue("ngayTao", ngayTao);
            int result=cmd.ExecuteNonQuery();
            con.Close();

            return result;
        }

        public int join(String maHV,String maLH)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            String sql = "insert into HocVien_LopHoc(id_HV,id_LH) values(@maHV,@maLH)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("maHV", maHV);
            cmd.Parameters.AddWithValue("maLH", maLH);
            int result = cmd.ExecuteNonQuery();

            con.Close();
            return result;
        }

        public int update(String ma, String ten, String sdt, DateTime ngaySinh, String diaChi,DateTime ngaySua)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            String sql = "update HocVien set ten_HV=@ten,sodt_HV=@sdt,ngaysinh_HV=@ngaySinh,diachi_HV=@diaChi,ngaysua=@ngaySua where id_HV=@ma";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.Parameters.AddWithValue("ten", ten);
            cmd.Parameters.AddWithValue("sdt", sdt);
            cmd.Parameters.AddWithValue("ngaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("diaChi", diaChi);
            cmd.Parameters.AddWithValue("ngaySua", ngaySua);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public int delete(String ma)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            String sql = "delete from HocVien where id_HV=@ma";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma", ma);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public Dictionary<String,String> getHocVien(String ma)
        {
            Dictionary<String,String> result= null;
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            String sql = "select * from HocVien where id_HV = @maHV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("maHV", ma);
            Console.WriteLine(cmd.Parameters["maHV"].Value);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                result = new Dictionary<string, string>();
                result.Add("ten_HV", rd["ten_HV"].ToString());
                result.Add("sodt_HV",rd["sodt_HV"].ToString());
                result.Add("ngaysinh_HV",rd["ngaysinh_HV"].ToString());
                result.Add("diachi_HV", rd["diachi_HV"].ToString());
            }
            con.Close();
            return result;
        }
    }
}
