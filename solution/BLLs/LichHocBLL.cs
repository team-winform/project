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
        public List<LichHocDTO> getLichHoc(string maLop)
        {
            return lichHocDAL.readLichHocs(maLop);
        }

        public void deleteLichHoc(string id_LichHoc)
        {
            if (id_LichHoc != null && id_LichHoc.Trim() != "" )
                lichHocDAL.deleteLichHoc(id_LichHoc);
        }
    }
}
