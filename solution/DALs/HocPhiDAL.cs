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
            string sql = "select hp.id_HV, lophoc.hocphi, hp.nop_lan_1, hp.ngay_nop_lan_1, hp.nop_lan_2, hp.ngay_nop_lan_2, hp.hoanthanh, hocvien.ten_HV, lophoc.ten_LH from hocphi hp inner join hocvien on hp.id_HV = hocvien.id_HV inner join lophoc on hp.id_LH = lophoc.id_LH where hp.id_LH = @idlh";
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
    }
}
