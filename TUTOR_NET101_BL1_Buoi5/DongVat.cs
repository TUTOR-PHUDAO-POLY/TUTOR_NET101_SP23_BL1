using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_BL1_Buoi5
{
    internal class DongVat
    {
        //Bài 2: Tạo class DongVat gồm các thuộc tính : ma- String , ten-String , gioiTinh-int (1-Đức, 2- Cái), canNang- int và các phương thức constructor, getter, setter và inThongTin(): void
        string ma, ten;
        int gioTinh;
        int canNang;

        public DongVat()
        {

        }

        public DongVat(string ma, string ten, int gioTinh, int canNang)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.GioTinh = gioTinh;
            this.CanNang = canNang;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int GioTinh { get => gioTinh; set => gioTinh = value; }
        public int CanNang { get => canNang; set => canNang = value; }

        public void InRaDV()
        {
            Console.WriteLine("Mã: {0}", Ma);
            Console.WriteLine("Tên: {0}", Ten);
            Console.WriteLine("Giới tính: {0}", GioTinh);
            Console.WriteLine("Cân nặng: {0}", CanNang);
        }
    }
}
