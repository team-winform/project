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
            ghiChu_LH = "";
            thoiGian = -1;
            sucChua = 0;
        }

        public string id_LH { get; set; }
        public string id_KH { get; set; }

        public string id_GV { get; set; }
        public string ten_LH { get; set; }
        public string id_PH { get; set; }
        public int siSo { get; set; }

        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }

        public string ghiChu_LH { get; set; }

        public string ten_PH { get; set; }

        public string ten_GV { get; set; }
        public string ten_KH { get; set; }

        public int thoiGian { get; set; }
        public int sucChua { get; set; }
    }
}
