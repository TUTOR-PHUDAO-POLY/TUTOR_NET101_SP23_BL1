using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02TuTor
{
    internal class DienThoai
    {
        string ten;
        string hang;
        string mau;

        int boNho;
        int gia;


        public DienThoai()
        {

        }

        public DienThoai(string ten, string hang, string mau, int boNho, int gia)
        {
            this.Ten = ten;
            this.Hang = hang;
            this.Mau = mau;
            this.BoNho = boNho;
            this.Gia = gia;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Hang { get => hang; set => hang = value; }
        public string Mau { get => mau; set => mau = value; }
        public int BoNho { get => boNho; set => boNho = value; }
        public int Gia { get => gia; set => gia = value; }

        public void InRa()
        {
            Console.WriteLine("Tên {0}", Ten);
            Console.WriteLine("Hãng {0}", Hang);
            Console.WriteLine("Màu {0}", BoNho);
            Console.WriteLine("Giá {0}", Gia);
        }
    }
}
