using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class LopHoc
    {
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
