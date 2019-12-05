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

            int rowEffect = 0;
            try
            {
                rowEffect = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ee)
            {
                conn.Close();
                Console.WriteLine(ee.Message);
            }
            
            if (rowEffect == 0)
            {
                return false;
            }
            
            return true;
        }

        public List<LopHocDTO> getsClassUse(string id_ph)
        {
            List<LopHocDTO> lhs = new List<LopHocDTO>();

            conn.Open();
            string sql = "select lophoc.id_LH, lophoc.ten_LH, lophoc.siso_LH, giangvien.ten_GV, lophoc.ngaybatdau, lophoc.ngayketthuc, khoahoc.ten_KH from lophoc inner join giangvien on lophoc.id_GV = giangvien.id_GV inner join phonghoc on lophoc.id_PH = phonghoc.id_PH inner join khoahoc on lophoc.id_KH = khoahoc.id_KH where lophoc.id_PH = @idph";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idph", id_ph);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LopHocDTO lh = new LopHocDTO();
                lh.id_LH = dr["id_LH"].ToString();
                lh.ten_LH = dr["ten_LH"].ToString();
                lh.ten_KH = dr["ten_KH"].ToString();
                lh.ten_GV = dr["ten_GV"].ToString();
                lh.ngayBatDau = DateTime.Parse(dr["ngaybatdau"].ToString());
                lh.ngayKetThuc = DateTime.Parse(dr["ngayketthuc"].ToString());
                lh.siSo = int.Parse(dr["siso_LH"].ToString());

                lhs.Add(lh);
            }

            conn.Close();
            return lhs;
        }

    }
}
