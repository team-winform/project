using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class LichHocDTO
    {
        public LichHocDTO()
        {
            ghiChu_LIH = "";
        }

        public string id_LIH { get; set; }
        public string id_LH { get; set; }
        public int tuan { get; set; }
        public int thu { get; set; }
        public string noiDung { get; set; }
        public string ghiChu_LIH { get; set; }
    }
}
