using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class StudentInfo
    {
        #region Attributes
        public string HoTen { get; set; }
        public string NamSinh { get; set; }
        public int MaSV { get; set; }
        public float DiemTB { get; set; }
        #endregion

        #region Method
        public void GetValueStudent()
        {
            Console.WriteLine("Ho va ten: " + HoTen);
            Console.WriteLine("Nam sinh: " + NamSinh);
            Console.WriteLine("Ma sinh vien: " + MaSV);
            Console.WriteLine("Diem trung binh: " + DiemTB);

        }
        public void SetValueStudent(string HoTen,string NamSinh, int MaSV, float DiemTB)
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.MaSV = MaSV;
            this.DiemTB = DiemTB;
        }
        #endregion

        #region Constructor
        public StudentInfo(string HoTen, string NamSinh, int MaSV, float DiemTB)
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.MaSV = MaSV;
            this.DiemTB = DiemTB;
        }
        #endregion
    }
}
