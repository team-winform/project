﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DALs
{
    public class DiemDanhDAL
    {
        private String connectString;

        public DiemDanhDAL()
        {
            this.connectString = ConfigurationManager.ConnectionStrings["conString"].ToString();
        }

        public DataTable getDiemDanh(String maLop)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select hv.id_HV,hv.ten_HV,hv.sodt_HV,count(dd.id) as 'nghi' from HOCVIEN as hv inner join HOCVIEN_LOPHOC as hl on hl.id_HV = hv.id_HV left join DiemDanh as dd on dd.id_HV = hv.id_HV and dd.id_LH=@maLop where hl.id_LH = @maLop group by hv.id_HV,hv.ten_HV,hv.sodt_HV";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("maLop", maLop);
            SqlDataReader rd = command.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            conn.Close();
            return tb;
        }


        public DataTable getAllLopHoc()
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select * from LOPHOC";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader rd = command.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            conn.Close();
            return tb;
        }


        public int diemDanh(String maHV, String maLH, DateTime date)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "insert into DiemDanh(id_HV,id_LH,ngayDiemDanh) values(@maHV,@maLH,@date)";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("maHV", maHV);
            command.Parameters.AddWithValue("maLH", maLH);
            command.Parameters.AddWithValue("date", date);
            int result = command.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public Boolean checkLopHocDaDiemDanh(DateTime date, String maLop)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select LOPHOC.ten_LH,DiemDanh.ngayDiemDanh from LOPHOC inner join DiemDanh on LOPHOC.id_LH=DiemDanh.id_LH where convert(varchar(10),DiemDanh.ngayDiemDanh,120) = convert(varchar(10),@now,120) and LOPHOC.id_LH=@ma";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("now", date);
            command.Parameters.AddWithValue("ma", maLop);
            SqlDataReader rd = command.ExecuteReader();
            Boolean result = rd.HasRows;
            conn.Close();
            return result;
        }

        public DataTable getDayOF(String maHV,String maLH)
        {
            SqlConnection conn = new SqlConnection(connectString);
            conn.Open();

            String sql = "select hv.ten_HV,hv.id_HV,lh.ten_LH,dd.ngayDiemDanh from HOCVIEN hv inner join DiemDanh dd on dd.id_HV = hv.id_HV and dd.id_LH = @maLop inner join LOPHOC lh on lh.id_LH = dd.id_LH where hv.id_HV = @maHV";
            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.AddWithValue("maLop", maLH);
            command.Parameters.AddWithValue("maHV", maHV);
            SqlDataReader rd = command.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(rd);
            return tb;
        }
    }
}
