using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class PhongHocDTO
    {
        private string id;
        private string name;
        private DateTime created;
        private DateTime updated;
        private string note;
        private int maxSeat;

        public PhongHocDTO() { }
        public PhongHocDTO(string id, string name, DateTime created, DateTime updated, string note, int maxSeat)
        {
            this.id = id;
            this.name = name;
            this.created = created;
            this.updated = updated;
            this.note = note;
            this.maxSeat = maxSeat;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Created { get => created; set => created = value; }
        public DateTime Updated { get => updated; set => updated = value; }
        public string Note { get => note; set => note = value; }
        public int MaxSeat { get => maxSeat; set => maxSeat = value; }
    }
}
