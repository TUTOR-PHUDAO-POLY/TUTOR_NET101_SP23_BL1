using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_BL1_Buoi5
{
    internal class Nguoi
    {
        //Tạo class Nguoi gồm các thông tin: ten - String , tuoi - int, gioiTinh - int (1-Nam, 0- Nữ),  queQuan - String , sdt - String , email - String và các phương thức constructor, getter, setter và hàm display() : void
        string ten;
        int tuoi;
        int gioiTinh;
        string queQuan;
        string sdt;
        string email;
        public Nguoi()
        {

        }

        public Nguoi(string ten, int tuoi, int gioiTinh, string queQuan, string sdt, string email)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.GioiTinh = gioiTinh;
            this.QueQuan = queQuan;
            this.Sdt = sdt;
            this.Email = email;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }

        public void InRaCha()
        {
            Console.WriteLine("Tên {0}", Ten);
            Console.WriteLine("Tuổi {0}", Tuoi);
            Console.WriteLine("Giới tính {0}", GioiTinh == 1 ? "Nam" : "Nữ");
            Console.WriteLine("Quê quán {0}", QueQuan);
            Console.WriteLine("Sđt {0}", Sdt);
            Console.WriteLine("Email {0}", Email);
        }
    }
}
