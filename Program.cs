using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_C__2026
{
    public class GeneralPerson : Person, ISpeaker
    {
        public string Workplace;
        public string Position;

        public GeneralPerson(string firstName, string lastName, string phone, string email,
                             string workplace, string position)
            : base(firstName, lastName, phone, email)
        {
            Workplace = workplace;
            Position = position;
        }

        public void Train()
        {
            Console.WriteLine($"{FirstName} กำลังอบรม");
        }

        public void Approve(Person p)
        {
            Console.WriteLine($"{FirstName} อนุมัติผลให้ {p.FirstName}");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"สถานที่ทำงาน: {Workplace}");
            Console.WriteLine($"ตำแหน่ง: {Position}");
            Console.WriteLine("---------------------");
        }
    }
}