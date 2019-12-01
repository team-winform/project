using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using DTOs;

namespace DALs
{
    public class LichHocDAL
    {
        SqlConnection conn;

        public LichHocDAL()
        {
            string conString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            conn = new SqlConnection(conString);
        }

        public List<LichHocDTO> readLichHocs(string maLop)
        {
            conn.Open();
            List<LichHocDTO> lstLichHocs = new List<LichHocDTO>();

            string query = "select * from LICHHOC where id_LH = @id_LH order by tuan ASC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                LichHocDTO lichHocDTO = new LichHocDTO();
                
                lichHocDTO.id_LIH = rd["id_LIH"].ToString();
                lichHocDTO.id_LH = rd["id_LH"].ToString();
                lichHocDTO.tuan = int.Parse(rd["tuan"].ToString());
                lichHocDTO.thu = int.Parse(rd["thu"].ToString());
                lichHocDTO.noiDung = rd["noidung"].ToString();
                lstLichHocs.Add(lichHocDTO);
            }
            
            conn.Close();
            return lstLichHocs;
        }

        public List<int> getThuUsingMaLop(string maLop)
        {
            conn.Open();
            List<int> result = new List<int>();

            string query = "select distinct thu from LICHHOC where id_LH = @id_LH order by thu ASC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                result.Add(int.Parse(rd["thu"].ToString()));
            }

            conn.Close();
            return result;
        }

        public List<int> getThuForbidden(string maPhongHoc, string maLop, int thoiGian, DateTime from, DateTime to)
        {
            conn.Open();
            List<int> result = new List<int>();

            string query = "select * from fn_GetThuForbidden(@id_PH, @id_LH, @thoiGian, @from, @to) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_PH", maPhongHoc);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            cmd.Parameters.AddWithValue("thoiGian", thoiGian);
            cmd.Parameters.AddWithValue("from", from);
            cmd.Parameters.AddWithValue("to", to);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                result.Add(int.Parse(rd["thu"].ToString()));
            }

            conn.Close();
            return result;
        }

        public void insertLichHoc(LichHocDTO lichDTO)
        {
            conn.Open();

            string query = "insert into LichHoc " +
                "(id_LH, tuan, thu, noidung, ghiChu_LIH) values " +
                "(@id_LH, @tuan, @thu, @noidung, @ghiChu_LIH)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", lichDTO.id_LH);
            cmd.Parameters.AddWithValue("tuan", lichDTO.tuan);
            cmd.Parameters.AddWithValue("thu", lichDTO.thu);
            cmd.Parameters.AddWithValue("noidung", lichDTO.noiDung);
            cmd.Parameters.AddWithValue("ghiChu_LIH", lichDTO.ghiChu_LIH);
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

        public void deleteLichHoc(string id_LichHoc)
        {
            conn.Open();

            string query = "delete LichHoc where id_LIH = @id_LIH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LIH", id_LichHoc);
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

        public void deleteLichHocUsingMaLop(string maLop)
        {
            conn.Open();

            string query = "delete LichHoc where id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
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

        public List<LichHocDTO> getLichHocById_LopHoc(string id_LopHoc)
        {
            conn.Open();
            List<LichHocDTO> lstLichHocs = new List<LichHocDTO>();
            string query = "select * from LichHoc where id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", id_LopHoc);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    LichHocDTO lih = new LichHocDTO();
                    lih.id_LIH = rd["id_LIH"].ToString();
                    lih.id_LH = rd["id_LH"].ToString();
                    lih.tuan = int.Parse(rd["tuan"].ToString());
                    lih.thu = int.Parse(rd["thu"].ToString());
                    lih.noiDung = rd["noidung"].ToString();
                    lih.ghiChu_LIH = rd["ghichu_LIH"].ToString();
                    lstLichHocs.Add(lih);
                }
            }
            catch (SqlException sqle)
            {
                conn.Close();
                throw sqle;
            }

            conn.Close();
            return lstLichHocs;
        }
    }
}
