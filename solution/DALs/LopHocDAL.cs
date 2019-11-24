﻿using System;
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

        public List<LopHocDTO> readLopHoc(int row_start, int row_end)
        {
            conn.Open();
            List<LopHocDTO> lstLopHocs = new List<LopHocDTO>();
            string query = "select * from ( select *, ROW_NUMBER() over (order by ngaybatdau DESC) as "
                + "rownum from LOPHOC) as lh where lh.rownum BETWEEN @row_start and @row_end";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("row_start", row_start);
            cmd.Parameters.AddWithValue("row_end", row_end);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                lstLopHocs = getLopHocDTO(rd);
            }
            catch (SqlException e)
            {
                conn.Close();
                throw e;
            }
            conn.Close();
            return lstLopHocs;
        }

        public void insertLopHoc(LopHocDTO lopHocDTO)
        {
            conn.Open();
            string query = "insert into LOPHOC " +
                "(id_LH, id_KH, ngaybatdau, ngayketthuc, id_GV, ten_LH, id_PH, ghichu_LH, siso_LH) values " +
                "(@id_LH, @id_KH, @ngaybatdau, @ngayketthuc, @id_GV, @ten_LH, @id_PH, @ghichu_LH, @siso_LH) ";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", lopHocDTO.id_LH);
            cmd.Parameters.AddWithValue("id_KH", lopHocDTO.id_KH);
            cmd.Parameters.AddWithValue("ngaybatdau", lopHocDTO.ngayBatDau);
            cmd.Parameters.AddWithValue("ngayketthuc", lopHocDTO.ngayKetThuc);
            cmd.Parameters.AddWithValue("id_GV", lopHocDTO.id_GV);
            cmd.Parameters.AddWithValue("ten_LH", lopHocDTO.ten_LH);
            cmd.Parameters.AddWithValue("id_PH", lopHocDTO.id_PH);
            cmd.Parameters.AddWithValue("ghichu_LH", lopHocDTO.ghiChu_LH);
            cmd.Parameters.AddWithValue("siso_LH", 0);
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
            cmd.Parameters.AddWithValue("tenLH", lopHocDTO.ten_LH);
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

            string query = "select * from LOPHOC where id_LH like concat('%',@id_LH, '%') order by ngaybatdau DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id_LH", maLopHoc);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                lstLopHocs = getLopHocDTO(rd);
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

            string query = "select * from LOPHOC where ten_LH like concat('%',@ten_LH, '%') order by ngaybatdau DESC";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("ten_LH", tenLopHoc);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                lstLopHocs = getLopHocDTO(rd);
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
                dto.tenLopHoc = rd["id_LH"].ToString();
                dto.id_PH = rd["id_LH"].ToString();
                dto.ghiChu_LH = rd["ghichu_LH"].ToString();
                dto.siSo = int.Parse(rd["sisho_LH"].ToString());

                lstLopHocDTOs.Add(dto);
            }
            return lstLopHocDTOs;
        }
    }
}
