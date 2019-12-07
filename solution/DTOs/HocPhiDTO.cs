using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class HocPhiDTO
    {
        private string studentId;
        private string studentName;
        private string className;
        private string classId;
        private double tuition;
        private double pay1;
        private DateTime? date1;
        private double pay2;
        private DateTime? date2;
        private double complete;

        public HocPhiDTO()
        {

            complete = 0;
            pay1 = 0;
            pay2 = 0;
        }

        public HocPhiDTO(string studentId, string studentName, string className, string classId, double tuition, double pay1, DateTime date1, double pay2, DateTime date2, double complete)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.className = className;
            this.classId = classId;
            this.tuition = tuition;
            this.pay1 = pay1;
            this.date1 = date1;
            this.pay2 = pay2;
            this.date2 = date2;
            this.complete = complete;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string ClassName { get => className; set => className = value; }
        public string ClassId { get => classId; set => classId = value; }
        public double Tuition { get => tuition; set => tuition = value; }
        public double Pay1 { get => pay1; set => pay1 = value; }
        public DateTime? Date1 { get => date1; set => date1 = value; }
        public double Pay2 { get => pay2; set => pay2 = value; }
        public DateTime? Date2 { get => date2; set => date2 = value; }
        public double Complete { get => complete; set => complete = value; }

        public double getOwed()
        {
            return (double) tuition - complete;
        }
    }
}
