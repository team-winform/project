﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LAM_DAL;

namespace LAM_BLL
{
    public class BLL
    {
        DAL dal;

        public BLL()
        {
            this.dal = new DAL();
        }
        public DataTable getAllKhoaHoc()
        {
            return dal.getAllKhoaHoc();
        }

        public int addKhoaHoc(String ten,String gia,String ghiChu)
        {
            String ma = "KH"+DateTime.Now.Ticks;
            int gia_old = int.Parse(gia);
            DateTime ngayTao = DateTime.Now;
            return dal.addKhoaHoc(ma, ten, gia_old, ngayTao, ngayTao, ghiChu);
        }

        public int updateKhoaHoc(String ma,String ten,String gia,String ghiChu)
        {
            int gia_old = int.Parse(gia);
            return dal.updateKhoaHoc(ma, ten, gia_old, DateTime.Now, DateTime.Now, ghiChu);
        }

        public int deleteKhoaHoc(String ma)
        {
            return dal.deleteKhoaHoc(ma);
        }
    }
}
