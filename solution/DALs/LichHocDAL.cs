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

            string query = "select * from LICHHOC where id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                LichHocDTO lichHocDTO = new LichHocDTO();
                
                lichHocDTO.id_LIH = rd["id_LIH"].ToString();
                lichHocDTO.id_LH = rd["id_LH"].ToString();
                lichHocDTO.thu = int.Parse(rd["thu"].ToString());
                lichHocDTO.tiet = rd["tiet"].ToString();

                lstLichHocs.Add(lichHocDTO);
            }
            
            conn.Close();
            return lstLichHocs;
        }

        public void insertLichHoc(LichHocDTO lichDTO)
        {
            conn.Open();

            string query = "insert into LichHoc values " +
                "(@id_LIH, @id_LH, @thu, @tiet, @ghiChu_LIH)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LIH", lichDTO.id_LIH);
            cmd.Parameters.AddWithValue("id_LH", lichDTO.id_LH);
            cmd.Parameters.AddWithValue("thu", lichDTO.thu);
            cmd.Parameters.AddWithValue("tiet", lichDTO.tiet);
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

        public void updateLichHoc(LichHocDTO lichDTO)
        {
            conn.Open();

            string query = "update LichHoc set " +
                "thu = @thu, " +
                "tiet = @tiet, " +
                "ghichu_LIH = @ghichu_LIH " +
                "where id_LIH = @id_LIH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("thu", lichDTO.thu);
            cmd.Parameters.AddWithValue("tiet", lichDTO.tiet);
            cmd.Parameters.AddWithValue("ghichu_LIH", lichDTO.ghiChu_LIH);
            cmd.Parameters.AddWithValue("id_LIH", lichDTO.id_LIH);

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
                    lih.thu = int.Parse(rd["thu"].ToString());
                    lih.tiet = rd["tiet"].ToString();
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
