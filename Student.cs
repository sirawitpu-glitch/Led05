using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_C__2026
{
    public class Student : Person
    {
        public string Major;
        public string StudentID;

        public Student(string firstName, string lastName, string phone, string email,
                       string major, string studentID)
            : base(firstName, lastName, phone, email)
        {
            Major = major;
            StudentID = studentID;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"สาขา: {Major}");
            Console.WriteLine($"รหัสนักศึกษา: {StudentID}");
            Console.WriteLine("---------------------");
        }
    }
}