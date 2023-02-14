using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_BL1_Buoi2
{
    internal class SinhVien
    {
        string maSv;
        string hoTen;
        int namSinh;
        string chuyenNganh;
        double diemTB;

        // ctor
        public SinhVien()
        {
            //maSv = "PH000";
        }

        public SinhVien(string maSv, string hoTen, int namSinh, string chuyenNganh, double diemTB)
        {
            this.maSv = maSv;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.chuyenNganh = chuyenNganh;
            this.diemTB = diemTB;
        }

        public string MaSV { get { return maSv; } set { maSv = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public int NamSinh { get { return namSinh; } set { namSinh = value; } }
        public string ChuyenNganh { get { return chuyenNganh; } set { chuyenNganh = value; } }
        public double DiemTB { get { return diemTB; } set { diemTB = value; } }

        public void Display()
        {
            Console.WriteLine($"{MaSV} - {HoTen} - {NamSinh} - {ChuyenNganh} - {DiemTB}");
        }
    }
}
