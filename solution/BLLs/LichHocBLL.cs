using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALs;
using DTOs;

namespace BLLs
{
    public class LichHocBLL
    {
        LichHocDAL lichHocDAL = new LichHocDAL();
        QuanLyLopHocBLL quanLyLopHocBLL = new QuanLyLopHocBLL();

        public List<LichHocDTO> getLichHoc(string maLop)
        {
            return lichHocDAL.readLichHocs(maLop);
        }

        public void deleteLichHoc(string id_LichHoc)
        {
            if (id_LichHoc != null && id_LichHoc.Trim() != "" )
                lichHocDAL.deleteLichHoc(id_LichHoc);
        }
        public void deleteLichHocUsingMaLop(string maLop)
        {
            lichHocDAL.deleteLichHocUsingMaLop(maLop);
        }

        public List<LichHocDTO> readLichHocs(string maLop)
        {
            return lichHocDAL.readLichHocs(maLop);
        }

        public void addLichHocs(string maLop, List<LichHocDTO> lstLichHocs)
        {
            // cap nhat moi hoan toan
            deleteLichHocUsingMaLop(maLop);
            foreach (LichHocDTO dto in lstLichHocs)
            {
                lichHocDAL.insertLichHoc(dto);
            }

            if(lstLichHocs.Count == 0)
            {
                quanLyLopHocBLL.updateThoiGianHoc(maLop, -1);
            }
        }

        public List<int> getThuUsingMaLop(string maLop)
        {
            return lichHocDAL.getThuUsingMaLop(maLop);
        }

        public List<int> getThuForbidden(string maPhongHoc, string maLop, int thoiGian, DateTime from, DateTime to)
        {
            return lichHocDAL.getThuForbidden(maPhongHoc, maLop, thoiGian, from, to);
        }
    }
}
