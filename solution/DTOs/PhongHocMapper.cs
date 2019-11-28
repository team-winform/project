using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DTOs
{
    public class PhongHocMapper
    {
        public static PhongHocDTO map(SqlDataReader dr)
        {
            PhongHocDTO ph = new PhongHocDTO();
            ph.Id = dr["id_PH"].ToString();
            ph.Name = dr["ten_PH"].ToString();
            ph.Created = DateTime.Parse(dr["ngaytao"].ToString());
            ph.Updated = DateTime.Parse(dr["ngaysua"].ToString());
            ph.Note = dr["ghichu_PH"].ToString();

            ph.MaxSeat = int.Parse(dr["succhua_PH"].ToString());
            return ph;
        }
    }
}
