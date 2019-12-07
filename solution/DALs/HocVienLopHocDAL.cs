using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DTOs;
using System.Data.SqlClient;

namespace DALs
{
    public class HocVienLopHocDAL
    {
        private static HocVienLopHocDAL instance;
        public static HocVienLopHocDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HocVienLopHocDAL();
                return instance;
            }
        }

        SqlConnection conn;

        public HocVienLopHocDAL()
        {
            string conString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            conn = new SqlConnection(conString);
        }

        public List<HocVienLopHocDTO> getsByClassName(string className)
        {
            List<HocVienLopHocDTO> hvlhList = new List<HocVienLopHocDTO>();
            conn.Open();
            string sql = "select hvlh.id_HV, hvlh.id_LH, hvlh.diem_1, hvlh.diem_2, hvlh.danhgia, " +
                "hvlh.diem_do_an, hvlh.xet_tot_nghiep, hvlh.xeploai, hvlh.ghichu_HVLH, lophoc.ten_LH, hocvien.ten_HV" +
                " from hocvien_lophoc as hvlh inner join hocvien on hvlh.id_HV = hocvien.id_HV inner join lophoc on hvlh.id_LH = lophoc.id_LH where lophoc.ten_LH = @className";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("className", className);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                HocVienLopHocDTO hvlh = HocVienLopHocMapper.map(dr);
                hvlhList.Add(hvlh);
            }
            conn.Close();
            return hvlhList;
        }

        public bool setPoint(HocVienLopHocDTO hl, int pointType)
        {
            conn.Open();
            try
            {
                string sql = "";
                SqlCommand cmd;
                if (pointType == 1)
                {
                    sql = "update hocvien_lophoc set diem_1 = @d1 where id_HV = @idhv and id_LH = @idlh";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("d1", hl.Point1);
                }
                else if (pointType == 2)
                {
                    sql = "update hocvien_lophoc set diem_2 = @d2 where id_HV = @idhv and id_LH = @idlh";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("d2", hl.Point2);
                }
                else
                {
                    sql = "update hocvien_lophoc set diem_do_an = @dda where id_HV = @idhv and id_LH = @idlh";
                    cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("dda", hl.PointFinal);
                }

                cmd.Parameters.AddWithValue("idhv", hl.StudentId);
                cmd.Parameters.AddWithValue("idlh", hl.ClassId);

                int rowEffect = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowEffect == 0)
                    return false;
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.Message);
                conn.Close();
                return false;
            }
            return true;
        }

        public bool setRate(HocVienLopHocDTO hl)
        {
            conn.Open();
            string sql = "update hocvien_lophoc set danhgia = @rate where id_HV = @idhv and id_LH = @idlh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idhv", hl.StudentId);
            cmd.Parameters.AddWithValue("idlh", hl.ClassId);
            cmd.Parameters.AddWithValue("rate", hl.Rate);
            int rowEffect = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowEffect == 0)
                return false;
            return true;
        }

        public bool setGraduatAndRank(HocVienLopHocDTO hl)
        {
            conn.Open();
            try
            {
                string sql = "update hocvien_lophoc set xet_tot_nghiep = @tn, xeploai = @xl where id_HV = @idhv and id_LH = @idlh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idhv", hl.StudentId);
                cmd.Parameters.AddWithValue("idlh", hl.ClassId);
                cmd.Parameters.AddWithValue("tn", hl.Graduating);
                cmd.Parameters.AddWithValue("xl", hl.Rank);
                int rowEffect = cmd.ExecuteNonQuery();
                Console.WriteLine(rowEffect);
                conn.Close();
                if (rowEffect == 0)
                    return false;
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                conn.Close();
                return false;
            }
            
            return true;
            
        }

        public List<HocVienLopHocDTO> readDSHV(string maLop)
        {
            Console.WriteLine("da vao readdshv");
            conn.Open();
            List<HocVienLopHocDTO> lstChiTietLop = new List<HocVienLopHocDTO>();
            string query = "select " +
                "HOCVIEN.id_HV, " +
                "HOCVIEN.ten_HV, " +
                "HOCVIEN_LOPHOC.diem_1, " +
                "HOCVIEN_LOPHOC.diem_2, " +
                "HOCVIEN_LOPHOC.danhgia, " +
                "HOCVIEN_LOPHOC.diem_do_an, " +
                "HOCVIEN_LOPHOC.xet_tot_nghiep, " +
                "HOCVIEN_LOPHOC.xeploai, " +
                "HOCVIEN_LOPHOC.ghichu_HVLH " +
                "from HOCVIEN inner join HOCVIEN_LOPHOC on HOCVIEN.id_HV = HOCVIEN_LOPHOC.id_HV " +
                "where HOCVIEN_LOPHOC.id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            Console.WriteLine("sau khi cmd pa");
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    HocVienLopHocDTO hvlh = new HocVienLopHocDTO();
                    hvlh.StudentId = rd["id_HV"].ToString();
                    hvlh.StudentName = rd["ten_HV"].ToString();
                    hvlh.Point1 = int.Parse(rd["diem_1"].ToString());
                    hvlh.Point2 = int.Parse(rd["diem_2"].ToString());
                    hvlh.PointFinal = int.Parse(rd["diem_do_an"].ToString());
                    hvlh.Note = rd["ghiChu_HVLH"].ToString();
                    hvlh.Graduating = bool.Parse( rd["xet_tot_nghiep"].ToString());
                    hvlh.Rank =rd["xeploai"].ToString();
                    hvlh.Rate = bool.Parse(rd["danhgia"].ToString());

                    lstChiTietLop.Add(hvlh);
                }
                Console.WriteLine("try thanh cong");

            }
            catch (SqlException ee)
            {
                Console.WriteLine("try loi");
                conn.Close();
                throw ee;
            }
            conn.Close();
            Console.WriteLine("xong readdshv");
            return lstChiTietLop;
        }

        public void insertHV_LH(HocVienLopHocDTO hvlh)
        {
            conn.Open();
            string query = "insert into HOCVIEN_LOPHOC" +
                "(id_LH, id_HV, diem_1, diem_2, danhgia, diem_do_an, xet_tot_nghiep, xeploai, ghichu_HVLH) values" +
                "(@id_LH, @id_HV, @diem1, @diem2, @danhgia, @diemdoan, @xtn, @xl, @ghichu_HVLH)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", hvlh.ClassId);
            cmd.Parameters.AddWithValue("id_HV", hvlh.StudentId);
            cmd.Parameters.AddWithValue("diem1", -1);
            cmd.Parameters.AddWithValue("diem2", -1);
            cmd.Parameters.AddWithValue("danhgia", 0);
            cmd.Parameters.AddWithValue("diemdoan", -1);
            cmd.Parameters.AddWithValue("xtn", 0);
            cmd.Parameters.AddWithValue("xl", "Không xếp loại");
            cmd.Parameters.AddWithValue("ghichu_HVLH", "");

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
