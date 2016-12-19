using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleClasses._Student;

namespace SimpleClasses
{
    class StudentTicket : Student
    {
        protected string ticketNum;
        protected DateTime ticketExpDate;
        public StudentTicket()
            : base()
        {
            ticketNum = "unknown";
            ticketExpDate = Birthday;
        }
        public StudentTicket(string surname, string name, string fathername, string birthday, string adrress, string phonenumber, string department, int course, string ticketNum, DateTime ticketExpDate)
            : base(surname, name, fathername, birthday, adrress, phonenumber, department, course)
        {
            this.ticketNum = ticketNum;
            this.ticketExpDate = ticketExpDate;
        }
        public string NumTicket
        {
            get { return ticketNum; }
            set { ticketNum = value; }
        }
        public string GetTicketNum()
        { return ticketNum; }
        public void SetTicketExpDate(DateTime date)
        {
            ticketExpDate = date;
        }
    }
}
