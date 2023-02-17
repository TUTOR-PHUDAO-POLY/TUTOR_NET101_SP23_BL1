using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_BL1_Buoi4
{
    internal class QLLHopHoc
    {
        /*
         * sử dụng ArrayList<LopHoc>
         * Các chức năng:
         * 	1.Nhập thông tin đối tượng.
	        2.In thông tin ra màn hình.
         */

        List<LopHoc> listLH = new List<LopHoc>();

        public QLLHopHoc()
        {

        }

        public void NhapThongTin()
        {
            bool nhapTiep = true; // bool gồm 2 giá trị: true, false

            while(nhapTiep)
            {
                // Khởi tạo đối tượng
                // Cách 1: CTR không tham số
                LopHoc lopHoc = new LopHoc();
                Console.Write("Nhập mã lớp: ");
                lopHoc.MaLop = Console.ReadLine(); // gán giá trị
                Console.Write("Nhập tên lớp: ");
                lopHoc.TenLop = Console.ReadLine(); // gán giá trị
                Console.Write("Nhập diện tích: ");
                lopHoc.DienTich = Convert.ToInt32(Console.ReadLine()); // gán giá trị
                Console.Write("Nhập địa điểm: ");
                lopHoc.DiaDiemLopHoc = Console.ReadLine(); // gán giá trị

                // Cách 2: CTR có tham số
                // Tạo biến lưu giá trị nhập
                //Console.Write("Nhập mã lớp: ");
                //string maLop = Console.ReadLine(); // gán giá trị
                //Console.Write("Nhập tên lớp: ");
                //string tenLop = Console.ReadLine(); // gán giá trị
                //Console.Write("Nhập diện tích: ");
                //int dienTich = Convert.ToInt32(Console.ReadLine()); // gán giá trị
                //Console.Write("Nhập địa điểm: ");
                //string diaDiemLopHoc = Console.ReadLine(); // gán giá trị

                //LopHoc lopHoc2 = new LopHoc(maLop, tenLop, dienTich, diaDiemLopHoc);

                listLH.Add(lopHoc);
                // list: add đối tượng vào list -> đối tượng mới sẽ có index sau
                // 0,1,2,3,4,.....
                // đối tượng 1: 0
                // đối tượng 2: 1

                // Nhập tiếp ?
                Console.WriteLine("<!> Bạn có muốn nhập tiếp không? Nhấn y để tiếp tục.");

                string luaChon = Console.ReadLine();

                switch(luaChon)
                {
                    case "y":
                        Console.WriteLine("Bạn chọn 'y'");
                        //nhapTiep = true;
                        break;
                    default:
                        nhapTiep = false;
                        break;
                }
            }

            Console.WriteLine("Đã nhập xong");

        }

        public void InThongTin()
        {
            foreach (var lopHoc in listLH)
            {
                lopHoc.InThongTin();
            }
        }
    }
}
