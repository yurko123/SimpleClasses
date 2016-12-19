using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleClasses._Student
{
    class GradeBook : Student
    {
        protected string gradeBookNum;
        protected double averageGrade;
        public GradeBook()
            : base()
        {
            gradeBookNum = "unknown";
            averageGrade = 0;
        }
        public GradeBook(string surname, string name, string fathername, string birthday, string adrress, string phonenumber, string department, int course, string grBookNum, double avrgGrade)
            : base(surname, name, fathername, birthday, adrress, phonenumber, department, course)
        {
            gradeBookNum = grBookNum;
            averageGrade = avrgGrade;
        }
        public string GradeNumBook
        {
            get { return gradeBookNum; }
        }
        public void SetAverageGrade(double[] mas)
        {
            double sum = 0;
            for (int i = 0; i < mas.Length; i++)
                sum += mas[i];
            sum /= mas.Length;
            averageGrade = sum;

        }
        public void SetGradeBookNum(string oldgradebooknum, string newgradebooknum)
        {
            if (oldgradebooknum == gradeBookNum) gradeBookNum = newgradebooknum;
        }

    }
}
