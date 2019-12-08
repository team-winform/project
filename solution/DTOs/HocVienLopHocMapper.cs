using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTOs
{
    public class HocVienLopHocMapper
    {
        public static HocVienLopHocDTO map(SqlDataReader dr)
        {
            HocVienLopHocDTO hvlh = new HocVienLopHocDTO();
            hvlh.StudentId = dr["id_HV"].ToString();
            hvlh.ClassId = dr["id_LH"].ToString();
            hvlh.Point1 = double.Parse(dr["diem_1"].ToString());
            hvlh.Point2 = double.Parse(dr["diem_2"].ToString());
            hvlh.PointFinal = double.Parse(dr["diem_do_an"].ToString());
            hvlh.Rate = bool.Parse(dr["danhgia"].ToString());
            hvlh.Graduating = bool.Parse(dr["xet_tot_nghiep"].ToString());
            hvlh.Rank = dr["xeploai"].ToString();
            hvlh.Note = dr["ghichu_HVLH"].ToString();
            hvlh.StudentName = dr["ten_HV"].ToString();
            hvlh.ClassName = dr["ten_LH"].ToString();
            return hvlh;
        }
    }
}
