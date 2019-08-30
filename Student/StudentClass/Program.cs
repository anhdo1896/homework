using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo student = new StudentInfo("Do Ngoc Anh", 123, "Hung Yen");
            student.GetValueStudent();
            student.SetValueStudent("Do Ngoc Anh", "18/06/1996", "Hung Yen", 123, 9.5f);
            student.GetValueStudent();
            Console.ReadKey();
        }
    }
}
