using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleClasses._Student
{
    class Student
    {
        protected string Surname;
        protected string Name;
        protected string FatherName;
        protected DateTime Birthday;
        protected string Adrress;
        protected string PhoneNumber;
        protected string Department;
        protected int Course;
        public Student()
        {
            Surname = "невідомо";
            Name = "невідомо";
            FatherName = "невідомо";
            Birthday = DateTime.Parse("01.01.1977");
            Adrress = "невідомо";
            PhoneNumber = "невідомо";
            Department = "невідомо";
            Course = 0;
        }
        public Student(string surname, string name, string fathername, string birthday, string adrress, string phonenumber, string department, int course)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            Birthday = DateTime.Parse("01.01.1977");
            Adrress = adrress;
            PhoneNumber = phonenumber;
            Department = department;
            Course = course;
        }
        public Student(string surname, string name, string fathername, string department, int course)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
            Birthday = DateTime.Parse("01.01.1977");
            Adrress = "невідомо";
            PhoneNumber = "невідомо";
            Department = department;
            Course = course;
        }
        public string GetSurname()
        { return Surname; }
        public string GetName()
        { return Name; }
        public string GetFatherName()
        { return FatherName; }
        public DateTime GetBirthday()
        { return Birthday; }
        public string GetAdrress()
        {
            return Adrress;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public string GetDepartament()
        {
            return Department;
        }
        public int GetCourse()
        {
            return Course;
        }
        public void SetSNF(string surname, string name, string fathername)
        {
            Surname = surname;
            Name = name;
            FatherName = fathername;
        }
        public void SetCourse(int course)
        {
            Course = course;
        }
    }
}
