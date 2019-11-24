using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;

namespace BLLs
{
    public class PhongHocBLL
    {
        private static PhongHocBLL instance;
        public static PhongHocBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongHocBLL();
                return instance;
            }
        }

        public List<PhongHocDTO> getAll()
        {
            return PhongHocDAL.Instance.getAll();
        }

        public bool insert(PhongHocDTO ph)
        {
            return PhongHocDAL.Instance.insert(ph);
        }
        public bool update(PhongHocDTO ph)
        {
            return PhongHocDAL.Instance.update(ph);
        }

        public PhongHocDTO findById(string id)
        {
            return PhongHocDAL.Instance.findById(id);
        }

        public List<PhongHocDTO> findByName(string name)
        {
            return PhongHocDAL.Instance.findByName(name);
        }

        public bool delete(string id)
        {
            return PhongHocDAL.Instance.delete(id);
        }
    }
}
