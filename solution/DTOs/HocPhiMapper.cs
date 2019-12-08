using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTOs
{
    public class HocPhiMapper
    {
        public static HocPhiDTO map(SqlDataReader dr)
        {
            HocPhiDTO hp = new HocPhiDTO();
            hp.ClassId = dr["id_LH"].ToString();
            hp.StudentId = dr["id_HV"].ToString();
            hp.StudentName = dr["ten_HV"].ToString();

            //Pay1
            try
            {
                hp.Pay1 = double.Parse(dr["nop_lan_1"].ToString());
            }
            catch
            {
                hp.Pay1 = 0;
            }

            //Pay2
            try
            {
                hp.Pay2 = double.Parse(dr["nop_lan_2"].ToString());
            }
            catch
            {
                hp.Pay2 = 0;
            }

            //Date1
            try
            {
                hp.Date1 = DateTime.Parse(dr["ngay_nop_lan_1"].ToString());
            }
            catch
            {
                hp.Date1 = null;
            }

            //Date2
            try
            {
                hp.Date2 = DateTime.Parse(dr["ngay_nop_lan_2"].ToString());
            }
            catch
            {
                hp.Date2 = null;
            }

            //hoanthnah
            try
            {
                hp.Complete = double.Parse(dr["hoanthanh"].ToString());
            }
            catch
            {
                hp.Complete = 0;
            }

            //hoc phi
            try
            {
                hp.Tuition = double.Parse(dr["hocphi"].ToString());
            }
            catch
            {
                hp.Tuition = 0;
            }

            return hp;
        }
    }
}
