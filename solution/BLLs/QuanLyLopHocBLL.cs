﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALs;
using DTOs;

namespace BLLs
{
    public class QuanLyLopHocBLL
    {
        private const int row_per_page = 30;

        LopHocDAL lopHocDAL = new LopHocDAL();

        public List<LopHocDTO> getLopHoc(int page)
        {
            int start_row = row_per_page * (page - 1);
            int end_row = row_per_page * page;
            return lopHocDAL.readLopHoc(start_row, end_row);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tuKhoa"></param>
        /// <param name="tieuChi">0: Tìm theo mã; 1: Tìm theo tên</param>
        /// <returns></returns>
        public List<LopHocDTO> searchLopHoc(string tuKhoa, int tieuChi)
        {
            List<LopHocDTO> lstLopHocs = new List<LopHocDTO>();
            switch (tieuChi)
            {
                case 0:
                    lstLopHocs = lopHocDAL.searchLopHocByID_LH(tuKhoa);
                    break;
                case 1:
                    lstLopHocs = lopHocDAL.searchLopHocByTen_LH(tuKhoa);
                    break;
            }
            return lstLopHocs;
        }

        public void insertLopHoc(LopHocDTO lopHocDTO)
        {
            if (lopHocDTO != null)
            {
                lopHocDTO.id_LH = getNewID_LH();
                lopHocDAL.insertLopHoc(lopHocDTO);
            }
        }

        public void updateLopHoc(LopHocDTO lopHocDTO)
        {
            lopHocDAL.updateLopHoc(lopHocDTO);
        }

        private string getNewID_LH()
        {
            int soLuongLop = lopHocDAL.getSoLuongLop();
            return "LH" + (soLuongLop + 1).ToString().PadLeft(4, '0');
        }

        public void deleteLopHoc(string maLop)
        {
            if (lopHocDAL.getSiSo(maLop) == 0)
                lopHocDAL.deleteLopHoc(maLop);
            else
                MessageBox.Show("Lớp này không trống. Không được xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}