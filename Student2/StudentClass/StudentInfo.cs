using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class StudentInfo
    {
        #region Attributes
        int MaSV;
        string HoTen, NamSinh;
        float DiemKy1, DiemKy2,DiemTB;
        #endregion

        #region Method
        public void GetValueStudent()
        {
            Console.WriteLine("Ho va ten: " + HoTen);
            Console.WriteLine("Nam Sinh: " + NamSinh);
            Console.WriteLine("Ma sinh vien: " + MaSV);
            Console.WriteLine("Diem ky 1: " + DiemKy1);
            Console.WriteLine("Diem ky 2: " + DiemKy2);
            Console.WriteLine("Diem ky trung binh: " + TinhDiemTB()+"\n");


        }

        public void SetValueStudent(string HoTen,string NamSinh, int MaSV, float DiemKy1,float DiemKy2)
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.MaSV = MaSV;
            this.DiemKy1 = DiemKy1;
            this.DiemKy2 = DiemKy2;
        }
        public float TinhDiemTB()
        {
            DiemTB = (DiemKy1 + DiemKy2) / 2;
            return DiemTB;
        }
        #endregion

        #region Constructor
        public StudentInfo(string HoTen,int MaSV,string NamSinh)
        {
            this.HoTen = HoTen;
            this.MaSV = MaSV;
            this.NamSinh = NamSinh;
        }
        #endregion
    }
}
