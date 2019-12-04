using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class TimingDTO
    {
        public static string getTimeString(string d, string M, string y, string H, string m, string s)
        {
            DateTime dt = DateTime.Now;

            return dt.ToString(d) + dt.ToString(M) + dt.ToString(y) + "_"
                + dt.ToString(H) + dt.ToString(m) + dt.ToString(s);
        }
    }
}
