using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOs;
using DALs;

namespace BLLs
{
    public class HocPhiBLL
    {
        private static HocPhiBLL instance;
        public static HocPhiBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HocPhiBLL();
                return instance;
            }
        }

        public List<HocPhiDTO> getsByClassId(string classId)
        {
            return HocPhiDAL.Instance.getsByClassId(classId);
        }
    }
}
