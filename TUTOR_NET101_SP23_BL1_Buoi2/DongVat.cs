using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_BL1_Buoi2
{
    internal class DongVat
    {
        //các thuộc tinh ma - String , ten - String ,loai - int ,gioiTinh - int ( 1- đực, 0- cái) ,canNang- int 
        string ma;
        string ten;
        int loai;
        int gioiTinh;
        int canNang;

        public DongVat()
        {

        }

        public DongVat(string ma, string ten, int loai, int gioiTinh, int canNang)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.Loai = loai;
            this.GioiTinh = gioiTinh;
            this.CanNang = canNang;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Loai { get => loai; set => loai = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int CanNang { get => canNang; set => canNang = value; }

        public void Display()
        {
            Console.WriteLine($"{Ma} - {Ten} - {Loai} - {GioiTinh} - {CanNang}");
        }
    }
}
