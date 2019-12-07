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

        public List<GiangVienDTO> getAll(string sortBy = null, string sortType = null)
        {
            if(sortBy == "ghichu_GV")
            {
                sortBy = "CAST(" + sortBy + " AS NVARCHAR(100))";
            }
            List<GiangVienDTO> gvs = new List<GiangVienDTO>();
            conn.Open();
            string sql = "";
            SqlCommand cmd;
            if (sortBy != null && sortType != null)
            {
                sql = "select * from giangvien order by " +sortBy + " " + sortType;
                cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("sort", sortBy);
                //cmd.Parameters.AddWithValue("type", sortType);
            }
            else
            {
                sql = "select * from giangvien";
                cmd = new SqlCommand(sql, conn);
            }
            

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

                string sql = "insert into giangvien values (@id, @name, @un, @dob, @sdt, @addr, @note, @created, @updated)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", gv.Id);
                cmd.Parameters.AddWithValue("name", gv.Name);
                cmd.Parameters.AddWithValue("un", gv.Username);
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

                string sql = "update giangvien set ten_GV = @name, username = @un, ngaysinh_GV = @dob, sodt_GV = @sdt, diachi_GV = @addr, ghichu_GV = @note, ngaysua = @updated where id_GV = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", gv.Id);
                cmd.Parameters.AddWithValue("name", gv.Name);
                cmd.Parameters.AddWithValue("un", gv.Username);
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
                conn.Close();
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

        public List<LopHocDTO> getClassList(GiangVienDTO gv)
        {
            List<LopHocDTO> lhs = new List<LopHocDTO>();

            conn.Open();
            string sql = "select lophoc.id_LH, lophoc.ten_LH, lophoc.siso_LH, phonghoc.ten_PH, lophoc.ngaybatdau, lophoc.ngayketthuc, khoahoc.ten_KH from lophoc inner join giangvien on lophoc.id_GV = giangvien.id_GV inner join phonghoc on lophoc.id_PH = phonghoc.id_PH inner join khoahoc on lophoc.id_KH = khoahoc.id_KH where lophoc.id_GV = @idgv";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idgv", gv.Id);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LopHocDTO lh = new LopHocDTO();
                lh.id_LH = dr["id_LH"].ToString();
                lh.ten_LH = dr["ten_LH"].ToString();
                lh.ten_KH = dr["ten_KH"].ToString();
                lh.ten_PH = dr["ten_PH"].ToString();
                lh.ngayBatDau = DateTime.Parse(dr["ngaybatdau"].ToString());
                lh.ngayKetThuc = DateTime.Parse(dr["ngayketthuc"].ToString());
                lh.siSo = int.Parse(dr["siso_LH"].ToString());

                lhs.Add(lh);
            }

            conn.Close();
            return lhs;
        }


        public List<string> getFreeUsername()
        {
            List<string> freeUNs = new List<string>();

            conn.Open();
            string sql = "select username from ACCOUNT where username not in (select giangvien.username from giangvien inner join ACCOUNT on giangvien.username = ACCOUNT.username ) and level = 2";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string un = dr["username"].ToString();
                freeUNs.Add(un);
            }

            conn.Close();
            return freeUNs;
        }
    }
}
