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
        }

        public LichHocDTO(string id_LIH, string id_LH, int thu, string tiet, string ghiChu_LIH)
        {
            this.id_LIH = id_LIH;
            this.id_LH = id_LH;
            this.thu = thu;
            this.tiet = tiet;
            this.ghiChu_LIH = ghiChu_LIH;
        }

        public string id_LIH { get; set; }
        public string id_LH { get; set; }
        public int thu { get; set; }
        public string tiet { get; set; }
        public string ghiChu_LIH { get; set; }
    }
}
