using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_BL1_Buoi5
{
    internal class Meo : DongVat
    {
        //	5.Tạo class Meo kế thừa từ DongVat và thêm thuộc tính tiengKeu - String và các phương thức constructor, getter, setter và hàm inThongTin() : void. Nhập thông tin của mèo và hiển thị ra.Sử dụng constructor có tham số.
        string tiengKeu;


        // Constructor ko có tham số.
        public Meo()
        {

        }

        // Constructor ko có tham số.
        public Meo(string ma, string ten, int gioTinh, int canNang, string tiengKeu) : base(ma, ten, gioTinh, canNang)
        {
            this.TiengKeu = tiengKeu;
        }

        public string TiengKeu { get => tiengKeu; set => tiengKeu = value; }

        public void InRaMeo()
        {
            InRaDV();
            Console.WriteLine("Tiếng kêu {0}", TiengKeu);
        }
    }
}
