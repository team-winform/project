using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class LopHocDTO
    {
        public LopHocDTO()
        {
        }

        public LopHocDTO(string id_LH, string id_KH, string id_GV, string ten_LH, string tenLopHoc, string id_PH, int siSo, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.id_LH = id_LH;
            this.id_KH = id_KH;
            this.id_GV = id_GV;
            this.ten_LH = ten_LH;
            this.tenLopHoc = tenLopHoc;
            this.id_PH = id_PH;
            this.siSo = siSo;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
        }

        public string id_LH { get; set; }
        public string id_KH { get; set; }

        public string id_GV { get; set; }
        public string ten_LH { get; set; }
        public string tenLopHoc { get; set; }
        public string id_PH { get; set; }
        public int siSo { get; set; }

        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }

    }
}
