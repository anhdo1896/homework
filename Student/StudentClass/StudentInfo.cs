using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public partial class StudentInfo
    {
        #region Attribute
        public string HoTen, NamSinh, DiaChi;
        public int MaSV;
        public float DiemTB;
        #endregion

        #region Method
        public void GetValueStudent()
        {
            Console.WriteLine("Ho va ten: " + HoTen);
            Console.WriteLine("Nam sinh: " + NamSinh);
            Console.WriteLine("Ma sinh vien: " + MaSV);
            Console.WriteLine("Dia chi: " + DiaChi);
            Console.WriteLine("Diem trung binh: " + DiemTB +"\n");



        }

        public void SetValueStudent(string HoTen, string NamSinh, string DiaChi, int MaSV, float DiemTB)
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiaChi = DiaChi;
            this.MaSV = MaSV;
            this.DiemTB = DiemTB;
        }
        #endregion
        #region Constructor
        public StudentInfo(string HoTen, int MaSV, string DiaChi)
        {
            this.HoTen = HoTen;
            this.MaSV = MaSV;
            this.DiaChi = DiaChi;
        }
        #endregion
    }    
}
