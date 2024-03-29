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
    public class ChiTietLopHocBLL
    {
        HocVienLopHocDAL hocVienLopHocDAL = new HocVienLopHocDAL();
        
        public List<HocVienLopHocDTO> readDSHV(string maLop)
        {
            return hocVienLopHocDAL.readDSHV(maLop);
        }

        public LopHocDTO getLopHocBasicInfo(string maLop)
        {
            LopHocDAL dal = new LopHocDAL();
            return dal.getLopHoc(maLop);
        }

        public void addHV_LH(List<HocVienLopHocDTO> lstHVLH, LopHocDTO currentLopHoc, string maHV)
        {
            string maLop = currentLopHoc.id_LH;
            if (maLop != null && maHV != null && maLop.Trim() != "" && maHV.Trim() != "")
            {
                if (findHocVienInDSHV(lstHVLH, maHV) == null && lstHVLH.Count < currentLopHoc.sucChua)
                {
                    HocVienLopHocDTO hvlh = new HocVienLopHocDTO();
                    HocPhiDTO hp = new HocPhiDTO();
                    hp.ClassId = maLop;
                    hp.StudentId = maHV;
                    hvlh.StudentId = maHV;
                    hvlh.ClassId = maLop;

                    hocVienLopHocDAL.insertHV_LH(hvlh);
                    HocPhiBLL.Instance.insertHocVien(hp);
                }
                else if (lstHVLH.Count >= currentLopHoc.sucChua)
                {
                    hienThongBao("Lớp học đã đầy!");

                }
                else
                {
                    hienThongBao("Học viên này đã có trong lớp!");
                }
            }
            else
            {
                hienThongBao("Bạn chưa chọn học viên nào!");
            }
        }

        public void removeHocVienLopHoc(List<HocVienLopHocDTO> lstHVLH, string maLop, string maHV)
        {
            if (maLop != null && maHV != null && maLop.Trim() != "" && maHV.Trim() != "")
            {
                if (findHocVienInDSHV(lstHVLH, maHV) != null)
                {
                    hocVienLopHocDAL.deleteHVLH(maLop, maHV);
                }
                else
                {
                    hienThongBao("Học viên này không có trong lớp!");
                }
            }
            else
            {
                hienThongBao("Bạn chưa chọn học viên nào!");
            }
        }

        public HocVienLopHocDTO findHocVienInDSHV(List<HocVienLopHocDTO> lstHVLH, string maHV)
        {
            foreach (HocVienLopHocDTO hvlh in lstHVLH)
            {
                if (hvlh.StudentId.Equals(maHV))
                {
                    return hvlh;
                }
            }
            return null;
        }

        public void hienThongBao(String message)
        {
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
