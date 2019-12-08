using System;
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

        public LopHocDTO getLopHocExtraInfo(string maLop)
        {
            return lopHocDAL.getLopHocExtraInfo(maLop);
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
            if (lopHocDTO != null)
                lopHocDAL.updateLopHoc(lopHocDTO);
        }

        public void updateThoiGianHoc(string maLop, int thoiGian)
        {
            lopHocDAL.updateThoiGianHoc(maLop, thoiGian);
        }

        private string getNewID_LH()
        {
            string lastID = lopHocDAL.getLastID();
            int id = 0;
            if (lastID != null)
                id = int.Parse(lastID.Substring(2));
            int new_id = id + 1;
            return "LH" + (new_id).ToString().PadLeft(3, '0');
            
        }

        public void deleteLopHoc(string maLop)
        {
            if (lopHocDAL.getSiSo(maLop) == 0)
                lopHocDAL.deleteLopHoc(maLop);
            else
                MessageBox.Show("Lớp này không trống. Không được xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public LopHocDTO findLopHocInList(string maString, List<LopHocDTO> lstLopHocs)
        {
            foreach (LopHocDTO dto in lstLopHocs)
            {
                if (dto.id_LH == maString)
                    return dto;
            }
            return null;
        }

        ////////////////////
        /// function created by Giangboy. use for HocVienLopHoc Module
        /// /////
        public List<LopHocDTO> getsIdAndNameByUsername(string username)
        {
            return lopHocDAL.getsIdAndNameByUsername(username);
        }

        public List<LopHocDTO> getsIdAndName()
        {
            return lopHocDAL.getsIdAndName();
        }
    }
}
