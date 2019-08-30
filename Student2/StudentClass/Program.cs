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
            StudentInfo student = new StudentInfo("Do Ngoc Anh", 123, "18/06/1996");
            student.GetValueStudent();
            student.SetValueStudent("Do Ngoc Anh", "18/06/1996", 123, 8.5f, 8.6f);
            student.GetValueStudent();
            Console.ReadKey();


        }
    }
}
