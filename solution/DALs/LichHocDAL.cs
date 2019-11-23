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
    public class LichHocDAL
    {
        SqlConnection conn;

        public LichHocDAL()
        {
            string conString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            conn = new SqlConnection(conString);
        }

        public String insertLichHoc(LichH)
        {

        }
    }
}
