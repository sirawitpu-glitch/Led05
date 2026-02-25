using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_C__2026
{
    class Program
    {
        static void Main()
        {
            List<Person> participants = new List<Person>();

            Student s = new Student("Sirawit", "Putonjai", "06506105260", "sirawit,pu@kkumail.com", "CS", "683450063-2");
            Teacher t = new Teacher("phat", "amin", "0822222222", "t@mail.com", "CS", "ผศ.");
            GeneralPerson g = new GeneralPerson("อร", "มาก", "0833333333", "g@mail.com", "บริษัท ABC", "ผู้จัดการ");

            participants.Add(s);
            participants.Add(t);
            participants.Add(g);

            Console.WriteLine("===== รายชื่อผู้เข้าอบรม =====");
            foreach (var p in participants)
            {
                p.ShowInfo();
                p.Register();
            }

            Console.WriteLine("\n===== การอบรม =====");

            ISpeaker speaker1 = t;
            speaker1.Train();
            speaker1.Approve(s);
        }
    }
}