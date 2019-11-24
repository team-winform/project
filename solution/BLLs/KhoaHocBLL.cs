using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALs;
using System.Data;

namespace BLLs
{
    public class KhoaHocBLL
    {

        private KhoaHocDAL khoaHocDAL;

        public KhoaHocBLL()
        {
            this.khoaHocDAL = new KhoaHocDAL();
        }

        public DataTable getAllKhoaHoc()
        {
            return this.khoaHocDAL.getAllKhoaHoc();
        }

        public int addKhoaHoc(String ten, String gia, String ghiChu)
        {
            String ma = "KH" + DateTime.Now.Ticks;
            int gia_old = int.Parse(gia);
            DateTime ngayTao = DateTime.Now;
            return this.khoaHocDAL.addKhoaHoc(ma, ten, gia_old, ngayTao, ngayTao, ghiChu);
        }

        public int updateKhoaHoc(String ma, String ten, String gia, String ghiChu)
        {
            int gia_old = int.Parse(gia);
            return this.khoaHocDAL.updateKhoaHoc(ma, ten, gia_old, DateTime.Now, DateTime.Now, ghiChu);
        }

        public int deleteKhoaHoc(String ma)
        {
            return this.khoaHocDAL.deleteKhoaHoc(ma);
        }

        public Dictionary<String, String> findKhoaHoc(String ma)
        {
            return this.khoaHocDAL.findKhoaHocByMa(ma);
        }

        public DataTable getLopHocOfKhoaHoc(String ma)
        {
            return this.khoaHocDAL.getLopHocOfKhoaHoc(ma);
        }
    }
}
