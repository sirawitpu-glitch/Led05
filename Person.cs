using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_C__2026
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string Phone;
        public string Email;

        public Person(string firstName, string lastName, string phone, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
        }

        public virtual void Register()
        {
            Console.WriteLine($"{FirstName} ลงทะเบียนเข้าร่วมอบรม");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"ชื่อ: {FirstName} {LastName}");
            Console.WriteLine($"เบอร์: {Phone}");
            Console.WriteLine($"อีเมล: {Email}");
        }
    }
}