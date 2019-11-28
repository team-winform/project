﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALs;

namespace BLLs
{
    public class HocVienBLL
    {
        private HocVienDAL hocVienDal;

        public HocVienBLL()
        {
            this.hocVienDal = new HocVienDAL();
        }

        public DataTable getListHocVien(String maLop)
        {
            return this.hocVienDal.getListHocVien(maLop);
        }

        public int add(String ten, String sdt, DateTime ngaySinh, String diaChi,String maLop)
        {
            String ma = "HV" + DateTime.Now.Ticks;
            DateTime ngayTao = DateTime.Now;
            try
            {
                this.hocVienDal.add(ma, ten, sdt, ngaySinh, diaChi, ngayTao);
                this.hocVienDal.join(ma, maLop);
                return 1;
            }catch(Exception ex)
            {
                this.hocVienDal.delete(ma);
                Console.WriteLine(ex.StackTrace);
                return 0;
            }
        }


        public int update(String ma, String ten, String sdt, DateTime ngaySinh, String diaChi)
        {
            DateTime ngaySua = DateTime.Now;
            return this.hocVienDal.update(ma, ten, sdt, ngaySinh, diaChi, ngaySua);
        }

        public int delete(String ma)
        {
            return this.hocVienDal.delete(ma);
        }

        public Dictionary<String,String> getHocVien(String ma)
        {
            return this.hocVienDal.getHocVien(ma);
        }
    }
}
