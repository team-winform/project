using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DTOs
{
    public class GiangVienMapper
    {
        public static GiangVienDTO map(SqlDataReader dr)
        {
            GiangVienDTO dto = new GiangVienDTO();
            
            dto.Id = dr["id_GV"].ToString();
            dto.Name = dr["ten_GV"].ToString();
            dto.Username = dr["username"].ToString();
            dto.DayOfBirth = DateTime.Parse(dr["ngaysinh_GV"].ToString());
            dto.Phone = dr["sodt_GV"].ToString();
            dto.Address = dr["diachi_GV"].ToString();
            dto.Note = dr["ghichu_GV"].ToString();
            dto.Created = DateTime.Parse(dr["ngaytao"].ToString());
            dto.Updated = dr["ngaysua"].ToString()==String.Empty ? dto.Created : DateTime.Parse(dr["ngaysua"].ToString());
            return dto;
         
        }
    }
}
