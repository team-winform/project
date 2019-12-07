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

        public bool insertHocVien(HocPhiDTO hp)
        {
            return HocPhiDAL.Instance.insertHocVien(hp);
        }

        public bool payTuition(HocPhiDTO hp, int payTime)
        {
            if (payTime == 1 && hp.Pay1 != 0)
                hp.Date1 = DateTime.Now;
            else if (payTime == 1 && hp.Pay1 == 0)
                hp.Date1 = null;
            else if (payTime == 2 && hp.Pay2 != 0)
                hp.Date2 = DateTime.Now;
            else if (payTime == 2 && hp.Pay2 == 0)
                hp.Date2 = null;
            hp.Complete = hp.Pay1 + hp.Pay2;
            
            if (hp.Complete > hp.Tuition)
            {
                Console.WriteLine("com > hp");
                return false;
            }
            Console.WriteLine("com <= hp");
            return HocPhiDAL.Instance.payTuition(hp, payTime);
        }
    }
}
