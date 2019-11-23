using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class AccountDTO
    {
        public AccountDTO()
        {
        }

        public AccountDTO(string username, string password, int level)
        {
            this.username = username;
            this.password = password;
            this.level = level;
        }

        public string username { get; set; }
        public string password { get; set; }
        public int level { get; set; }
        public string fullname { get; set; }
        public string phone { get; set; }
    }
}
