using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALs;
using DTOs;


namespace BLLs
{
    public class GiangVienBLL
    {
        private static GiangVienBLL instance;
        public static GiangVienBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new GiangVienBLL();
                return instance;
            }
        }

        public List<GiangVienDTO> getAll()
        {
            return GiangVienDAL.Instance.getAll();
        }

        public bool insert(GiangVienDTO gv)
        {
            string ma = "GV" + DateTime.Now.Ticks;
            gv.Id = ma;
            gv.Created = DateTime.Now;
            gv.Updated = gv.Created;
            return GiangVienDAL.Instance.insert(gv);
        }

        public bool update(GiangVienDTO gv)
        {

            gv.Updated = DateTime.Now;
            return GiangVienDAL.Instance.update(gv);
        }

        public GiangVienDTO findById(string ma)
        {
            return GiangVienDAL.Instance.findById(ma);
        }

        public bool delete(string ma)
        {
            return GiangVienDAL.Instance.delete(ma);
        }

        public List<GiangVienDTO> findByName(string ten)
        {
            return GiangVienDAL.Instance.findByName(ten);
        }

        public List<LopHocDTO> getClassList(GiangVienDTO gv)
        {
            return GiangVienDAL.Instance.getClassList(gv);
        }
    }
}
