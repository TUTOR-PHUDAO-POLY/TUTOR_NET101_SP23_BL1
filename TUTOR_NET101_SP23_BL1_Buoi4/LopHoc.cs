using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_BL1_Buoi4
{
    internal class LopHoc
    {
        /*
         * Tạo đối tượng LopHoc gồm các thuộc tính: maLop - String , tenLop - String , dienTich - int, diaDiemLopHoc - String   và các phương thức constructor, getter, setter và inThongTin(): void
         */

        // Thuộc tính
        string maLop;
        string tenLop;
        int dienTich;
        string diaDiemLopHoc;

        // Constructor không tham số
        public LopHoc()
        {

        }

        // Constructor có tham số
        public LopHoc(string maLop, string tenLop, int dienTich, string diaDiemLopHoc)
        {
            this.MaLop = maLop;
            this.TenLop = tenLop;
            this.DienTich = dienTich;
            this.DiaDiemLopHoc = diaDiemLopHoc;
        }

        // Getter và Setter
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public int DienTich { get => dienTich; set => dienTich = value; }
        public string DiaDiemLopHoc { get => diaDiemLopHoc; set => diaDiemLopHoc = value; }

        // Pương thức
        public void InThongTin()
        {
            Console.WriteLine($"Mã lớp: {MaLop}");
            Console.WriteLine($"Tên lớp: {TenLop}");
            Console.WriteLine($"Diện tích: {DienTich}");
            Console.WriteLine($"Địa điểm: {DiaDiemLopHoc}");
        }
    }
}
