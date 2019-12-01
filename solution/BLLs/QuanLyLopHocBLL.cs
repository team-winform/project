using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            lopHocDTO.id_LH = getNewID_LH();
            lopHocDAL.insertLopHoc(lopHocDTO);
        }

        private string getNewID_LH()
        {
            int soLuongLop = lopHocDAL.getSoLuongLop();
            return "LH" + soLuongLop.ToString().PadLeft(4, '0');
        }

        public void deleteLopHoc(string maLop)
        {
            lopHocDAL.deleteLopHoc(maLop);
        }

        ////////////////////
        /// function created by Giangboy. use for HocVienLopHoc Module
        /// /////
        public List<LopHocDTO> getsIdAndName()
        {
            return lopHocDAL.getsIdAndName();
        }
    }
}
