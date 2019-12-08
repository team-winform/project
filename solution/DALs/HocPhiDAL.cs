using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using System.Data.SqlClient;
using System.Configuration;

namespace DALs
{
    public class HocPhiDAL
    {
        private static HocPhiDAL instance;
        public static HocPhiDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HocPhiDAL();
                return instance;
            }
        }

        private SqlConnection conn;
         public HocPhiDAL()
        {
            string connString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            conn = new SqlConnection(connString);
        }

        public List<HocPhiDTO> getsByClassId(string classId)
        {
            conn.Open();
            List<HocPhiDTO> hps = new List<HocPhiDTO>();
            string sql = "select hp.id_HV, hp.id_LH, lophoc.hocphi, hp.nop_lan_1, hp.ngay_nop_lan_1, hp.nop_lan_2, hp.ngay_nop_lan_2, hp.hoanthanh, hocvien.ten_HV, lophoc.ten_LH from hocphi hp inner join hocvien on hp.id_HV = hocvien.id_HV inner join lophoc on hp.id_LH = lophoc.id_LH where hp.id_LH = @idlh";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idlh", classId);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hps.Add(HocPhiMapper.map(dr));
            }
            conn.Close();
            return hps;
        }

        public bool insertHocVien(HocPhiDTO hp)
        {
            conn.Open();
            string sql = "insert into hocphi (id_HV, id_LH) values (@idhv, @idlh)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idhv", hp.StudentId);
            cmd.Parameters.AddWithValue("idlh", hp.ClassId);

            int rowEffect = cmd.ExecuteNonQuery();
            conn.Close();
            if (rowEffect == 0)
                return false;
            return true;
        }

        public bool payTuition(HocPhiDTO hp, int payTime)
        {
            conn.Open();
            string sql = "";
            SqlCommand cmd = null;
            if(payTime == 1)
            {
                sql = "update hocphi set nop_lan_1 = @nop1, ngay_nop_lan_1 = @date1, hoanthanh = @ht where id_HV = @idhv and id_LH = @idlh";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nop1", hp.Pay1);
                if (hp.Date1 != null)
                    cmd.Parameters.AddWithValue("date1", hp.Date1);
                else
                    cmd.Parameters.AddWithValue("date1", DBNull.Value);
            } else if(payTime == 2)
            {
                sql = "update hocphi set nop_lan_2 = @nop2, ngay_nop_lan_2 = @date2, hoanthanh = @ht where id_HV = @idhv and id_LH = @idlh";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nop2", hp.Pay2);
                
                if(hp.Date2 != null)
                    cmd.Parameters.AddWithValue("date2", hp.Date2);
                else
                    cmd.Parameters.AddWithValue("date2", DBNull.Value);
            }
            if(sql != "")
            {
                cmd.Parameters.AddWithValue("ht", hp.Complete);
                cmd.Parameters.AddWithValue("idhv", hp.StudentId);
                cmd.Parameters.AddWithValue("idlh", hp.ClassId);
                int rowEffect = cmd.ExecuteNonQuery();
                conn.Close();
                if (rowEffect > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
}
