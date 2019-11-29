using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class HocVienLopHocDTO
    {
        public HocVienLopHocDTO()
        {
            this.ghiChu_HVLH = "";
            diem1 = -1;
            diem2 = -1;
            diem3 = -1;
            diem4 = -1;
        }

        public string id_HV { get; set; }
        public string ten_HV { get; set; }
        public string id_LH { get; set; }
        public int diem1 { get; set; }
        public int diem2 { get; set; }

        public int diem3 { get; set; }
        public int diem4 { get; set; }

        public string ghiChu_HVLH { get; set; }
    }
}
