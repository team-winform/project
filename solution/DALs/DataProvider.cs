using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace DALs
{
    public class DataProvider
    {
        private static GiangVienDAL instance;
        public static GiangVienDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiangVienDAL();
                return instance;
            }
        }

        static SqlConnection conn;
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        
        public DataProvider()
        {
            conn = new SqlConnection(connString);
        }

        public static SqlDataReader excuteSelect(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            conn.Close();

            return dr;
        }

        public static bool excuteNonQuery(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rowEffect = cmd.ExecuteNonQuery();
            conn.Close();
            if(rowEffect == 0)
            {
                
                return false;
            }
            
            return true;
        }
    }
}
