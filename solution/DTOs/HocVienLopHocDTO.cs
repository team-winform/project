using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class HocVienLopHocDTO
    {
        private string studentId;
        private string classId;
        private double point1;
        private double point2;
        private bool rate;
        private double pointFinal;
        private bool graduating;
        private string rank;
        private string note;

        public HocVienLopHocDTO() {
            this.Note = "";
            Point1 = -1;
            point2 = -1;
            PointFinal = -1;
            Rank = "Không xếp loại";
            Graduating = false;
            Rate = false;
        }

        public HocVienLopHocDTO(string idStudent, string idClass, double point1, double point2, double pointFinal, string note)
        {
            this.StudentId = idStudent;
            this.classId = idClass;
            this.point1 = point1;
            this.point2 = point2;
            this.pointFinal = pointFinal;
            this.note = note;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string ClassId { get => classId; set => classId = value; }
        public double Point1 { get => point1; set => point1 = value; }
        public double Point2 { get => point2; set => point2 = value; }
        public bool Rate { get => rate; set => rate = value; }
        public double PointFinal { get => pointFinal; set => pointFinal = value; }
        public bool Graduating { get => graduating; set => graduating = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Note { get => note; set => note = value; }
        public string StudentName { get; set; }
        public string ClassName { get; set; }
        

        public double getDTBTX()
        {
            if (Point1 == -1 || Point2 == -1)
                return -1;
            return (double)(Point1 + Point2) / 2;
        }

        public string getDTB()
        {
            if (getDTBTX() == -1 || PointFinal == -1)
                return "-1";
            double d = ((getDTBTX() + pointFinal * 2) / 3);
            Console.WriteLine(d + " => " + String.Format("{0:0.##}", d));
            return String.Format("{0:0.##}", d);
        }
    }
}
