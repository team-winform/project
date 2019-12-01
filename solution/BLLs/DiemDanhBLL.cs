using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALs;

namespace BLLs
{
    public class DiemDanhBLL
    {
        private DiemDanhDAL diemDanhDAL;

        public DiemDanhBLL()
        {
            this.diemDanhDAL = new DiemDanhDAL();
        }

        public DataTable getDiemDanh(String maLop)
        {
            return this.diemDanhDAL.getDiemDanh(maLop);
        }

        public DataTable getAllLopHoc()
        {
            return this.diemDanhDAL.getAllLopHoc();
        }

        public int diemDanh(String maHV, String maLH)
        {
            return this.diemDanhDAL.diemDanh(maHV, maLH, DateTime.Now);
        }

        public bool checkLopHocDaDiemDanh(String maLop)
        {
            return this.diemDanhDAL.checkLopHocDaDiemDanh(DateTime.Now, maLop);
        }

        public DataTable getDayOF(String maHV,String maLop)
        {
            return this.diemDanhDAL.getDayOF(maHV, maLop);
        }

        public DataTable thongKeDiemDanh(String maLop)
        {
            return this.diemDanhDAL.thongKeDiemDanh(maLop);
        }
    }
}
