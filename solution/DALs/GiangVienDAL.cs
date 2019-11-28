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
    public class GiangVienDAL
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

        public GiangVienDAL()
        {
            string connString = ConfigurationManager.ConnectionStrings["conString"].ToString();

            conn = new SqlConnection(connString);
        }

        public List<GiangVienDTO> getAll()
        {
            List<GiangVienDTO> gvs = new List<GiangVienDTO>();
            conn.Open();
            string sql = "select * from giangvien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                GiangVienDTO gv = GiangVienMapper.map(dr);
                gvs.Add(gv);
                
            }
            conn.Close();
            return gvs;
        }

        public bool insert(GiangVienDTO gv) {

            try {
                conn.Open();

                string sql = "insert into giangvien values (@id, @name, @dob, @sdt, @addr, @note, @created, @updated)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", gv.Id);
                cmd.Parameters.AddWithValue("name", gv.Name);
                cmd.Parameters.AddWithValue("dob", gv.DayOfBirth);
                cmd.Parameters.AddWithValue("sdt", gv.Phone);
                cmd.Parameters.AddWithValue("addr", gv.Address);
                cmd.Parameters.AddWithValue("note", gv.Note);
                cmd.Parameters.AddWithValue("created", gv.Created);
                cmd.Parameters.AddWithValue("updated", gv.Updated);
                int rowEffect = cmd.ExecuteNonQuery();
                conn.Close();
                if (rowEffect == 0)
                    return false;
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

        public bool update(GiangVienDTO gv)
        {

            try
            {
                conn.Open();

                string sql = "update giangvien set ten_GV = @name, ngaysinh_GV = @dob, sodt_GV = @sdt, diachi_GV = @addr, ghichu_GV = @note, ngaysua = @updated where id_GV = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", gv.Id);
                cmd.Parameters.AddWithValue("name", gv.Name);
                cmd.Parameters.AddWithValue("dob", gv.DayOfBirth);
                cmd.Parameters.AddWithValue("sdt", gv.Phone);
                cmd.Parameters.AddWithValue("addr", gv.Address);
                cmd.Parameters.AddWithValue("note", gv.Note);
                cmd.Parameters.AddWithValue("updated", gv.Updated);
                int rowEffect = cmd.ExecuteNonQuery();
                conn.Close();
                if (rowEffect == 0)
                    return false;
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                conn.Close();
                return false;
            }
        }


        public GiangVienDTO findById(string ma)
        {
            conn.Open();

            string sql = "select * from giangvien where id_GV = @ma";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();

            GiangVienDTO gv = null;
            while (dr.Read())
            {
                 gv = GiangVienMapper.map(dr);
            }
            conn.Close();
            return gv;
        }

        public bool delete(string ma)
        {
            try
            {
                conn.Open();
                string sql = "delete giangvien where id_GV = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ma", ma);

                int rowEffect = cmd.ExecuteNonQuery();
                conn.Close();
                if(rowEffect == 0)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<GiangVienDTO> findByName(string ten)
        {
            conn.Open();
            List<GiangVienDTO> gvs = new List<GiangVienDTO>();
            string sql = "select * from giangvien where ten_GV like concat('%',@ten,'%')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("ten", ten);
            SqlDataReader dr = cmd.ExecuteReader();

            GiangVienDTO gv = null;
            while (dr.Read())
            {
                gv = GiangVienMapper.map(dr);
                gvs.Add(gv);
            }
            conn.Close();
            return gvs;
        }

    }
}
