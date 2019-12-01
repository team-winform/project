using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;

namespace BLLs
{
    public class HocVienLopHocBLL
    {
        private static HocVienLopHocBLL instance;
        public static HocVienLopHocBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HocVienLopHocBLL();
                return instance;
            }
        }

        public List<HocVienLopHocDTO> getsByClassName(string className)
        {
            return HocVienLopHocDAL.Instance.getsByClassName(className);
        }

        public bool setPoint(HocVienLopHocDTO hl, int typePoint)
        {
            return HocVienLopHocDAL.Instance.setPoint(hl, typePoint);
        }

        public bool setRate(HocVienLopHocDTO hl)
        {
            return HocVienLopHocDAL.Instance.setRate(hl);
        }
        public bool setGraduatAndRank(HocVienLopHocDTO hl)
        {
            return HocVienLopHocDAL.Instance.setGraduatAndRank(hl);
        }
    }
}
