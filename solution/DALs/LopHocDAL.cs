using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTOs;

namespace DALs
{
    public class LopHocDAL
    {
        SqlConnection conn;

        public LopHocDAL()
        {
            string constring = ConfigurationManager.ConnectionStrings["conString"].ToString();
            conn = new SqlConnection(constring);
        }

        public string getLastID()
        {
            conn.Open();
            string lastID = null;
            string query = "select top 1 id_LH from LopHoc order by id_LH DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    lastID = rd["id_LH"].ToString();
                }
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
            return lastID;
        }

        public int getSiSo(string maLop)
        {
            conn.Open();
            int siSo = 0;
            string query = "select  siso_LH from LopHoc where id_LH = @id_LH ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    siSo = int.Parse(rd["siSo_LH"].ToString());
                }
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
            return siSo;
        }

        public List<LopHocDTO> readLopHoc(int row_start, int row_end)
        {
            Console.WriteLine("da vao readlop hoc");
            conn.Open();
            List<LopHocDTO> lstLopHocs = new List<LopHocDTO>();
            string query = "select * from ( " +
                    "select LOPHOC.*, KHOAHOC.ten_KH, PHONGHOC.ten_PH, PHONGHOC.succhua_PH, GIANGVIEN.ten_GV, " +
                            "ROW_NUMBER() over(order by LOPHOC.ngaybatdau DESC) as rownum " +
                            "from LOPHOC left join KHOAHOC on LOPHOC.id_KH = KHOAHOC.id_KH " +
                            "left join GIANGVIEN on LOPHOC.id_GV = GIANGVIEN.id_GV " +
                            "left join PHONGHOC on PHONGHOC.id_PH = LOPHOC.id_PH " +
                    ") as lh where lh.rownum BETWEEN @row_start and @row_end";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("row_start", row_start);
            cmd.Parameters.AddWithValue("row_end", row_end);
            Console.WriteLine("sau khi cmd.parameters");
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                lstLopHocs = getLopHocFullInfo(rd);
            }
            catch (SqlException e)
            {
                Console.WriteLine("da vaoex");
                conn.Close();
                throw e;
            }
            conn.Close();
            Console.WriteLine("da close o read lophoc");
            return lstLopHocs;
        }

        public LopHocDTO getLopHoc(string maLop)
        {
            conn.Open();
            LopHocDTO dto = null;
            string query = "select LOPHOC.*, PHONGHOC.succhua_PH from LOPHOC inner join PHONGHOC on LOPHOC.id_PH = PHONGHOC.id_PH where id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dto = new LopHocDTO();
                    dto.id_LH = rd["id_LH"].ToString();
                    dto.id_KH = rd["id_KH"].ToString();
                    dto.ngayBatDau = DateTime.Parse(rd["ngaybatdau"].ToString());
                    dto.ngayKetThuc = DateTime.Parse(rd["ngayketthuc"].ToString());
                    dto.id_GV = rd["id_GV"].ToString();
                    dto.ten_LH = rd["ten_LH"].ToString();
                    dto.id_PH = rd["id_LH"].ToString();
                    dto.ghiChu_LH = rd["ghichu_LH"].ToString();
                    dto.siSo = int.Parse(rd["siso_LH"].ToString());
                    dto.sucChua = int.Parse(rd["succhua_PH"].ToString());
                }
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
            return dto;
        }

        public LopHocDTO getLopHocExtraInfo(string maLop)
        {
            conn.Open();
            LopHocDTO dto = null;
            string query = "select LOPHOC.*, GIANGVIEN.ten_GV, PHONGHOC.ten_PH, PHONGHOC.succhua_PH, KHOAHOC.ten_KH  from " +
                "LOPHOC inner join GIANGVIEN on LOPHOC.id_GV = GIANGVIEN.id_GV " +
                "inner join PHONGHOC on LOPHOC.id_PH = PHONGHOC.id_PH " +
                "inner join KHOAHOC on LOPHOC.id_KH = KHOAHOC.id_KH " +
                "where id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLop);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                List<LopHocDTO> lst = getLopHocFullInfo(rd);
                if (lst.Count != 0)
                {
                    dto = lst.ElementAt(0);
                }
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
            return dto;
        }

        public void insertLopHoc(LopHocDTO lopHocDTO)
        {
            conn.Open();
            string query = "insert into LOPHOC " +
                "(hocphi, id_LH, id_KH, ngaybatdau, ngayketthuc, thoigian, id_GV, ten_LH, id_PH, ghichu_LH, siso_LH) values " +
                "(@hp, @id_LH, @id_KH, @ngaybatdau, @ngayketthuc, @thoigian, @id_GV, @ten_LH, @id_PH, @ghichu_LH, @siso_LH) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", lopHocDTO.id_LH);
            cmd.Parameters.AddWithValue("id_KH", lopHocDTO.id_KH);
            cmd.Parameters.AddWithValue("ngaybatdau", lopHocDTO.ngayBatDau);
            cmd.Parameters.AddWithValue("ngayketthuc", lopHocDTO.ngayKetThuc);
            cmd.Parameters.AddWithValue("thoigian", lopHocDTO.thoiGian);
            cmd.Parameters.AddWithValue("id_GV", lopHocDTO.id_GV);
            cmd.Parameters.AddWithValue("ten_LH", lopHocDTO.ten_LH);
            cmd.Parameters.AddWithValue("id_PH", lopHocDTO.id_PH);
            cmd.Parameters.AddWithValue("ghichu_LH", lopHocDTO.ghiChu_LH);
            cmd.Parameters.AddWithValue("siso_LH", 0);
            cmd.Parameters.AddWithValue("hp", lopHocDTO.hocPhi);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
        }

        public void updateLopHoc(LopHocDTO lopHocDTO)
        {
            conn.Open();
            string query = "update LOPHOC set " +
                "id_KH = @id_KH," +
                "ngaybatdau = @ngaybatdau, " +
                "ngayketthuc = @ngayketthuc, " +
                "id_GV = @id_GV, " +
                "ten_LH = @ten_LH, " +
                "id_PH = @id_PH, " +
                "ghichu_LH = @ghichu_LH " +
                "where id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", lopHocDTO.id_LH);
            cmd.Parameters.AddWithValue("id_KH", lopHocDTO.id_KH);
            cmd.Parameters.AddWithValue("ngaybatdau", lopHocDTO.ngayBatDau);
            cmd.Parameters.AddWithValue("ngayketthuc", lopHocDTO.ngayKetThuc);
            cmd.Parameters.AddWithValue("id_GV", lopHocDTO.id_GV);
            cmd.Parameters.AddWithValue("ten_LH", lopHocDTO.ten_LH);
            cmd.Parameters.AddWithValue("id_PH", lopHocDTO.id_PH);
            cmd.Parameters.AddWithValue("ghichu_LH", lopHocDTO.ghiChu_LH);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
        }

        public void updateThoiGianHoc(string id_LH, int thoiGian)
        {
            conn.Open();
            string query = "update LOPHOC set " +
                "thoigian = @thoigian " +
                "where id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", id_LH);
            cmd.Parameters.AddWithValue("thoigian", thoiGian);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
        }

        public void deleteLopHoc(string maLopHoc)
        {
            conn.Open();
            string query = "delete LOPHOC where id_LH = @id_LH";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLopHoc);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
        }

        public List<LopHocDTO> searchLopHocByID_LH(string maLopHoc)
        {
            conn.Open();
            List<LopHocDTO> lstLopHocs = new List<LopHocDTO>();

            //string query = "select * from LOPHOC where id_LH like concat('%',@id_LH, '%') order by ngaybatdau DESC";
            string query2 = "select * from ( " +
                    "select LOPHOC.*, KHOAHOC.ten_KH, PHONGHOC.ten_PH, GIANGVIEN.ten_GV, " +
                            "ROW_NUMBER() over(order by LOPHOC.ngaybatdau DESC) as rownum " +
                            "from LOPHOC left join KHOAHOC on LOPHOC.id_KH = KHOAHOC.id_KH " +
                            "left join GIANGVIEN on LOPHOC.id_GV = GIANGVIEN.id_GV " +
                            "left join PHONGHOC on PHONGHOC.id_PH = LOPHOC.id_PH " +
                    ") as lh where id_LH like concat('%',@id_LH, '%')";
            SqlCommand cmd = new SqlCommand(query2, conn);
            cmd.Parameters.AddWithValue("id_LH", maLopHoc);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                lstLopHocs = getLopHocFullInfo(rd);
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
            return lstLopHocs;
        }

        public List<LopHocDTO> searchLopHocByTen_LH(string tenLopHoc)
        {
            conn.Open();
            List<LopHocDTO> lstLopHocs = new List<LopHocDTO>();

            //string query = "select * from LOPHOC where ten_LH like concat('%',@ten_LH, '%') order by ngaybatdau DESC";
            string query2 = "select * from ( " +
                    "select LOPHOC.*, KHOAHOC.ten_KH, PHONGHOC.ten_PH, GIANGVIEN.ten_GV, " +
                            "ROW_NUMBER() over(order by LOPHOC.ngaybatdau DESC) as rownum " +
                            "from LOPHOC left join KHOAHOC on LOPHOC.id_KH = KHOAHOC.id_KH " +
                            "left join GIANGVIEN on LOPHOC.id_GV = GIANGVIEN.id_GV " +
                            "left join PHONGHOC on PHONGHOC.id_PH = LOPHOC.id_PH " +
                    ") as lh where ten_LH like concat('%',@ten_LH, '%')";
            SqlCommand cmd = new SqlCommand(query2, conn);
            cmd.Parameters.AddWithValue("ten_LH", tenLopHoc);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                lstLopHocs = getLopHocFullInfo(rd);
            }
            catch (SqlException ee)
            {
                conn.Close();
                throw ee;
            }
            conn.Close();
            return lstLopHocs;
        }

        private List<LopHocDTO> getLopHocDTO(SqlDataReader rd)
        {
            List<LopHocDTO> lstLopHocDTOs = new List<LopHocDTO>();
            while (rd.Read())
            {
                LopHocDTO dto = new LopHocDTO();
                dto.id_LH = rd["id_LH"].ToString();
                dto.id_KH = rd["id_KH"].ToString();
                dto.ngayBatDau = DateTime.Parse(rd["ngaybatdau"].ToString());
                dto.ngayKetThuc = DateTime.Parse(rd["ngayketthuc"].ToString());
                dto.id_GV = rd["id_GV"].ToString();
                dto.ten_LH = rd["ten_LH"].ToString();
                dto.id_PH = rd["id_LH"].ToString();
                dto.ghiChu_LH = rd["ghichu_LH"].ToString();
                dto.siSo = int.Parse(rd["siso_LH"].ToString());
                dto.sucChua = int.Parse(rd["succhua_PH"].ToString());
                lstLopHocDTOs.Add(dto);
            }
            return lstLopHocDTOs;
        }

        private List<LopHocDTO> getLopHocFullInfo(SqlDataReader rd)
        {
            Console.WriteLine("da vao getlophocFullInfo");
            List<LopHocDTO> lstLopHocDTOs = new List<LopHocDTO>();
            while (rd.Read())
            {
                LopHocDTO dto = new LopHocDTO();
                dto.id_LH = rd["id_LH"].ToString();
                dto.id_KH = rd["id_KH"].ToString();
                dto.ngayBatDau = DateTime.Parse(rd["ngaybatdau"].ToString());
                dto.ngayKetThuc = DateTime.Parse(rd["ngayketthuc"].ToString());
                dto.thoiGian = int.Parse(rd["thoigian"].ToString());
                dto.id_GV = rd["id_GV"].ToString();
                dto.ten_LH = rd["ten_LH"].ToString();
                dto.id_PH = rd["id_PH"].ToString();
                dto.ghiChu_LH = rd["ghichu_LH"].ToString();
                dto.siSo = int.Parse(rd["siso_LH"].ToString());
                dto.ten_GV = rd["ten_GV"].ToString();
                dto.ten_PH = rd["ten_PH"].ToString();
                dto.ten_KH = rd["ten_KH"].ToString();
                dto.sucChua = int.Parse(rd["succhua_PH"].ToString());
                dto.hocPhi = double.Parse(rd["hocphi"].ToString());
                lstLopHocDTOs.Add(dto);
            }
            return lstLopHocDTOs;
        }

        ////////////////////
        /// function created by Giangboy. use for HocVienLopHoc Module
        /// /////
        /// 
        public List<LopHocDTO> getsIdAndNameByUsername(string username)
        {
            conn.Open();

            List<LopHocDTO> lhs = new List<LopHocDTO>();
            string sql = "select lophoc.id_LH, lophoc.ten_LH, lophoc.hocphi from lophoc inner join giangvien on lophoc.id_GV = giangvien.id_GV where giangvien.username = @un";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("un", username);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LopHocDTO lh = new LopHocDTO();
                lh.id_LH = dr["id_LH"].ToString();
                lh.ten_LH = dr["ten_LH"].ToString();
                try
                {
                    lh.hocPhi = double.Parse(dr["hocphi"].ToString());
                }
                catch
                {
                    lh.hocPhi = -1;
                }
                lhs.Add(lh);
            }

            conn.Close();

            return lhs;
        }

        public List<LopHocDTO> getsIdAndName()
        {
            conn.Open();
            List<LopHocDTO> lhs = new List<LopHocDTO>();
            string sql = "select id_LH, ten_LH, hocphi from lophoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LopHocDTO lh = new LopHocDTO();
                lh.id_LH = dr["id_LH"].ToString();
                lh.ten_LH = dr["ten_LH"].ToString();
                try
                {
                    lh.hocPhi = double.Parse(dr["hocphi"].ToString());
                }
                catch
                {
                    lh.hocPhi = -1;
                }
                lhs.Add(lh);
            }
            conn.Close();
            return lhs;
        }
    }
}
