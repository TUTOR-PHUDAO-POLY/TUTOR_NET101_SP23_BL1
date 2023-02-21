using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_BL1_Buoi5
{
    internal class SinhVien : Nguoi
    {
        double diem;

        //Constructor không tham số
        public SinhVien()
        {

        }

        //Constructor tham số
        public SinhVien(string ten, int tuoi, int gioiTinh, string queQuan, string sdt, string email) : base(ten, tuoi, gioiTinh, queQuan, sdt, email)
        {

        }


        public double Diem { get => diem; set => diem = value; }

        //display() : void. Nhập thông tin của 1 sinh viên và in ra màn hình(Sử dụng constructor không tham số)
        public void InRaCon()
        {
            InRaCha();//Kế thừa phương thức in ra bên lớp cha

            Console.WriteLine("Điểm {0}", Diem);
        }

    }
}
