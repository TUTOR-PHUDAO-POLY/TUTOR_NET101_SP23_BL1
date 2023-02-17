using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_BL1_Buoi4
{
    internal class DongHo
    {
        /*
         * Tạo đối tượng DongHo gồm các thông tin:maDongHo - String, theLoai - String, mauSac- String, kichThuoc - int, chatLieu -String, gia-int  và các phương thức constructor, getter, setter và inThongTin(): void
         */

        string maDongHo;
        string theLoai;
        string mauSac;
        int kichThuoc;
        string chatLieu;
        int gia;

        public DongHo()
        {

        }

        public DongHo(string maDongHo, string theLoai, string mauSac, int kichThuoc, string chatLieu, int gia)
        {
            this.MaDongHo = maDongHo;
            this.TheLoai = theLoai;
            this.MauSac = mauSac;
            this.KichThuoc = kichThuoc;
            this.ChatLieu = chatLieu;
            this.Gia = gia;
        }

        public string MaDongHo { get => maDongHo; set => maDongHo = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }
        public int KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        public string ChatLieu { get => chatLieu; set => chatLieu = value; }
        public int Gia { get => gia; set => gia = value; }

        public void InThongTin()
        {
            Console.WriteLine($"Mã đồng hồ: {MaDongHo}");
            Console.WriteLine($"Thể loại: {TheLoai}");
            Console.WriteLine($"Màu sắc: {MauSac}");
            Console.WriteLine($"Kích thước: {KichThuoc}");
            Console.WriteLine($"Chất liệu: {ChatLieu}");
            Console.WriteLine($"Giá: {Gia}");
        }
    }
}
