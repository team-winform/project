using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTOs;
using System.Configuration;

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
            string sql = "";
            SqlCommand cmd;
            if (pointType == 0)
            {
                sql = "update hocvien_lophoc set diem_1 = @d1, diem_2 = @d2 where id_HV = @idhv and id_LH = @idlh";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("idhv", hl.StudentId);
                cmd.Parameters.AddWithValue("idlh", hl.ClassId);
                cmd.Parameters.AddWithValue("d1", hl.Point1);
                cmd.Parameters.AddWithValue("d2", hl.Point2);
            }
            else
            {
                sql = "update hocvien_lophoc set diem_do_an = @dda where id_HV = @idhv and id_LH = @idlh";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("dda", hl.PointFinal);
                cmd.Parameters.AddWithValue("idhv", hl.StudentId);
                cmd.Parameters.AddWithValue("idlh", hl.ClassId);
            }

            int rowEffect = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowEffect == 0)
                return false;
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
            Console.WriteLine("rate: " + rowEffect);
            if (rowEffect == 0)
                return false;
            return true;
        }

        public bool setGraduatAndRank(HocVienLopHocDTO hl)
        {
            conn.Open();
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
            return true;
        }
    }
}
