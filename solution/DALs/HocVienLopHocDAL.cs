using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using System.Configuration;
using System.Data.SqlClient;


namespace DALs
{
    public class HocVienLopHocDAL
    {
        SqlConnection conn;

        public HocVienLopHocDAL()
        {
            string constring = ConfigurationManager.ConnectionStrings["constring"].ToString();
            conn = new SqlConnection(constring);
        }

        public List<HocVienLopHocDTO> readDSHV(string maLop)
        {
            conn.Open();
            List<HocVienLopHocDTO> lstChiTietLop = new List<HocVienLopHocDTO>();
            string query = "select " +
                "HOCVIEN.id_HV, " +
                "HOCVIEN.ten_HV, " +
                "HOCVIEN_LOPHOC.id_LH, " +
                "HOCVIEN_LOPHOC.diem_1, " +
                "HOCVIEN_LOPHOC.diem_2, " +
                "HOCVIEN_LOPHOC.diem_3, " +
                "HOCVIEN_LOPHOC.diem_4, " +
                "HOCVIEN_LOPHOC.ghichu_HVLH " +
                "from HOCVIEN inner join HOCVIEN_LOPHOC on HOCVIEN.id_HV = HOCVIEN_LOPHOC.id_HV " +
                "where HOCVIEN_LOPHOC.id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    HocVienLopHocDTO hvlh = new HocVienLopHocDTO();
                    hvlh.id_HV = rd["id_HV"].ToString();
                    hvlh.id_LH = rd["id_LH"].ToString();
                    hvlh.ten_HV = rd["ten_HV"].ToString();
                    hvlh.diem1 = int.Parse(rd["diem_1"].ToString());
                    hvlh.diem2 = int.Parse(rd["diem_2"].ToString());
                    hvlh.diem3 = int.Parse(rd["diem_3"].ToString());
                    hvlh.diem4 = int.Parse(rd["diem_4"].ToString());
                    hvlh.ghiChu_HVLH = rd["ghiChu_HVLH"].ToString();
                    lstChiTietLop.Add(hvlh);
                }
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
            return lstChiTietLop;
        }

        public void insertHV_LH(HocVienLopHocDTO hvlh)
        {
            conn.Open();

            string query = "insert into HOCVIEN_LOPHOC" +
                "(id_LH, id_HV, diem_1, diem_2, diem_3, diem_4, ghichu_HVLH) values" +
                "(@id_LH, @id_HV, @diem1, @diem2, @diem3, @diem4, @ghichu_HVLH)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", hvlh.id_LH);
            cmd.Parameters.AddWithValue("id_HV", hvlh.id_HV);
            cmd.Parameters.AddWithValue("diem1", hvlh.diem1);
            cmd.Parameters.AddWithValue("diem2", hvlh.diem2);
            cmd.Parameters.AddWithValue("diem3", hvlh.diem3);
            cmd.Parameters.AddWithValue("diem4", hvlh.diem4);
            cmd.Parameters.AddWithValue("ghichu_HVLH", hvlh.ghiChu_HVLH);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
        }

        public void deleteHVLH(string maLop, string maHV)
        {
            conn.Open();
            
            string query = "delete HOCVIEN_LOPHOC where id_HV = @id_HV and id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            cmd.Parameters.AddWithValue("id_HV", maHV);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
        }
    }
}
