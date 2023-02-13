using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02TuTor
{
    internal class Nguoi
    {
        /* Tạo class Nguoi gồm các thuộc tính: ten - String , tuoi - int, gioiTinh - int ( 0-Nữ, 1- Nam), queQuan - String , ngheNghiep - String   và các phương thức constructor, getter, setter và inThongTin(): void*/
        string ten = "";

        int tuoi = 0;
        int gioiTinh = 0;//Có thể để bool
        string queQuan = "";
        string ngheNghiep = "";

        public Nguoi()
        {
            //Có thể khởi tạo giá trị mặc định
        }

        public Nguoi(string ten, int tuoi, int gioiTinh, string queQuan, string ngheNghiep)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
            this.NgheNghiep = ngheNghiep;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string NgheNghiep { get => ngheNghiep; set => ngheNghiep = value; }

        public void InRa()
        {
            string gioiTinh;
            if (GioiTinh == 0)
            {
                gioiTinh = "Nữ";
            }
            else
            {
                gioiTinh = "Nam";
            }
            Console.WriteLine("Tên: {0}", Ten);
            Console.WriteLine("Tuổi : {0}", Tuoi);
            Console.WriteLine("Giới tính: {0}", gioiTinh /*(GioiTinh == 0) ? "Nữ" : "Nam"*/);
            Console.WriteLine("Quê quán: {0}", QueQuan);
            Console.WriteLine("Nghề nghiệp: {0}", NgheNghiep);

        }
    }
}
