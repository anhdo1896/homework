using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentInfo> StudentList = new List<StudentInfo>();
            string choose = "y";
            while (choose == "y") {
                Console.WriteLine("1. Nhap so sinh vien");
                Console.WriteLine("2. Tim sinh vien co diem TB cao nhat");
                Console.WriteLine("3. Tim kiem sinh vien theo ma sinh vien");
                Console.WriteLine("4. Hien thi sinh vien duoc hoc bong");
                Console.WriteLine("5. Hien thi tat ca sinh vien");
                Console.Write("Hay chon mot so:");

                string  k = Console.ReadLine();
                switch (k) 
                {
                    #region Nhap sinh vien
                    case "1":
                        Console.Write("Nhap ten sinh vien: ");
                        string TenSV = Console.ReadLine();
                        Console.Write("Nhap ngay sinh: ");
                        string NgaySinh = Console.ReadLine();
                        Console.Write("Nhap ma sinh vien: ");
                        int MaSV = Int32.Parse(Console.ReadLine());
                        Console.Write("Nhap diem trung binh: ");
                        float DiemTB = float.Parse(Console.ReadLine());
                        StudentList.Add(new StudentInfo(TenSV, NgaySinh, MaSV, DiemTB));
                        break;
                    #endregion

                    #region Diem cao nhat
                    case "2":
                        float max = 0;
                        foreach (StudentInfo student in StudentList)
                        {
                            if (student.DiemTB > max)
                            {
                                max = student.DiemTB;
                            }
                        }
                        StudentInfo resultMax = StudentList.Find
                            (delegate (StudentInfo st)
                            {
                                return st.DiemTB == max;
                            });
                        if (resultMax != null)
                        {
                            resultMax.GetValueStudent();
                        }
                        else
                        {
                            Console.Write("Khong co sinh vien nao\n");
                        }
                        break;
                    #endregion

                    #region tim MaSV
                    case "3":
                        Console.Write("Nhap ma sinh vien: ");
                        int MaSVFind = Int32.Parse(Console.ReadLine());
                        StudentInfo result = StudentList.Find
                            (delegate (StudentInfo st)
                            {
                                return st.MaSV == MaSVFind;
                            });
                        if (result != null)
                        {
                            result.GetValueStudent();
                        }
                        else
                        {
                            Console.Write("Khong co sinh vien nao\n");
                        }
                        break;
                    #endregion

                    #region Hoc Bong
                    case "4":
                        
                        StudentInfo results = StudentList.Find
                            (delegate (StudentInfo st)
                            {
                                return st.DiemTB > 8;
                            });
                        if (results != null)
                        {
                            Console.Write("Sinh vien dat hoc bong:\n");
                            results.GetValueStudent();
                        }
                        else
                        {
                            Console.Write("Khong co sinh vien nao\n");
                        }
                        break;
                    #endregion

                    #region Tat ca SV
                    case "5":
                        foreach(StudentInfo student in StudentList)
                        {
                            student.GetValueStudent();
                        }
                    break;
                    #endregion

                    #region Nhap  sai
                    default:
                        Console.Write("Nhap sai ");
                        break;
                    #endregion

                }
                Console.Write("\nBan co muon con nua khong(y/n): ");
                choose = Console.ReadLine();
            }
            Console.ReadKey();

        }
    }
}
