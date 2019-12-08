using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class GiangVienDTO
    {
        private string id;
        private string name;
        private string username;
        private DateTime dayOfBirth;
        private string phone;
        private string address;
        private string note;
        private DateTime created;
        private DateTime updated;
        

        public GiangVienDTO() { }
        public GiangVienDTO(string id, string name, string un,  DateTime dayOfBirth, string phone, string address, string note, DateTime created, DateTime updated)
        {
            this.id = id;
            this.name = name;
            this.username = un;
            this.dayOfBirth = dayOfBirth;
            this.phone = phone;
            this.address = address;
            this.note = note;
            this.created = created;
            this.updated = updated;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Note { get => note; set => note = value; }
        public DateTime Created { get => created; set => created = value; }
        public DateTime Updated { get => updated; set => updated = value; }
    }
}
