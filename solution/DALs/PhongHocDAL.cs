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
    public class PhongHocDAL
    {
        private static PhongHocDAL instance;
        public static PhongHocDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongHocDAL();
                return instance;
            }
        }

        static SqlConnection conn;

        public PhongHocDAL()
        {
            string connString = ConfigurationManager.ConnectionStrings["conString"].ToString();

            conn = new SqlConnection(connString);
        }

        public List<PhongHocDTO> getAll()
        {
            List<PhongHocDTO> phs = new List<PhongHocDTO>();
            conn.Open();
            string sql = "select * from phonghoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                PhongHocDTO ph = PhongHocMapper.map(dr);
                phs.Add(ph);

            }
            conn.Close();
            return phs;
        }

        public bool insert(PhongHocDTO ph)
        {
            try
            {
                conn.Open();
                string sql = "insert into phonghoc values (@id, @name, @created, @updated, @note, @max)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ph.Id);
                cmd.Parameters.AddWithValue("name", ph.Name);
                cmd.Parameters.AddWithValue("created", ph.Created);
                cmd.Parameters.AddWithValue("updated", ph.Updated);
                cmd.Parameters.AddWithValue("note", ph.Note);
                cmd.Parameters.AddWithValue("max", ph.MaxSeat);
                int rowEffect = cmd.ExecuteNonQuery();
                conn.Close();
                if (rowEffect == 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool update(PhongHocDTO ph)
        {
            try
            {
                conn.Open();
                string sql = "update phonghoc set ten_PH = @name, ngaysua = @updated, ghichu_PH = @note, succhua_PH = @max where id_PH = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ph.Id);
                cmd.Parameters.AddWithValue("name", ph.Name);
                cmd.Parameters.AddWithValue("updated", ph.Updated);
                cmd.Parameters.AddWithValue("note", ph.Note);
                cmd.Parameters.AddWithValue("max", ph.MaxSeat);
                int rowEffect = cmd.ExecuteNonQuery();
                conn.Close();
                if (rowEffect == 0)
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public PhongHocDTO findById(string id)
        {
            conn.Open();
            string sql = "select * from phonghoc where id_PH = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);

            SqlDataReader dr = cmd.ExecuteReader();
            PhongHocDTO ph = null;
            while (dr.Read())
            {
                ph = PhongHocMapper.map(dr);
            }
            conn.Close();
            return ph;
        }

        public List<PhongHocDTO> findByName(string name)
        {
            conn.Open();
            List<PhongHocDTO> phs = new List<PhongHocDTO>();
            string sql = "select * from phonghoc where ten_PH like concat('%',@ten,'%')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ten", name);
            SqlDataReader dr = cmd.ExecuteReader();

            PhongHocDTO ph = null;
            while (dr.Read())
            {
                ph = PhongHocMapper.map(dr);
                phs.Add(ph);
            }
            conn.Close();
            return phs;
        }

        public bool delete(string id)
        {
            conn.Open();
            string sql = "delete phonghoc where id_PH = @id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);

            int rowEffect = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowEffect == 0)
            {
                return false;
            }
            
            return true;
        }

    }
}
