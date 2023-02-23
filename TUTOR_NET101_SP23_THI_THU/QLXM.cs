using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_THI_THU
{
    internal class QLXM
    {
        // List
        List<XeMay> listXM = new List<XeMay>();

        public QLXM()
        {
        }

        // Các chức năng
        public void Nhap()
        {
            // * Các bước thêm đối tượng vào list:
            // Tạo đối tượng -> Nhập thông tin -> Thêm đối tượng vào list
            // *Hỏi có nhập tiếp: Thực hiện việc thêm đối tượng vào list nhiều lần

            string luaChon;

            do
            {
                // Tạo đối tượng
                XeMay xeMay = new XeMay();

                // Nhập thông tin
                Console.Write("Nhập mã: ");
                xeMay.MaXeMay = Console.ReadLine();
                Console.Write("Nhập hãng: ");
                xeMay.HangXe = Console.ReadLine();
                Console.Write("Nhập giá tiền: ");
                xeMay.GiaTien = Convert.ToDouble(Console.ReadLine());

                // Thêm vào list
                listXM.Add(xeMay);

                // Hỏi người dùng nhập tiếp ?
                Console.WriteLine("Nhập tiếp hay không? Nhấn 'y' để tiếp tục.");
                luaChon = Console.ReadLine(); // Nhập

                // Cách if
                //if (luaChon.Equals("y"))
                //{
                //}
                //else
                //{
                //    return;
                //}    

                // Cách switch
                switch(luaChon)
                {
                    case "y":
                        break;
                    default:
                        return;
                }

            } while (true /*luaChon.Equals("y")*/);
        }

        public void Xuat()
        {
            foreach (var xeMay in listXM)
            {
                xeMay.InThongtin();
            }
        }

        public void TimKiemTheoKhoangGia()
        {
            Console.WriteLine("Nhập khoảng giá");
            Console.Write("Từ: ");
            double start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Đến: ");
            double end = Convert.ToDouble(Console.ReadLine());

            // Cách 1
            foreach (var xeMay in listXM)
            {
                if (xeMay.GiaTien > start &&
                    xeMay.GiaTien < end)
                {
                    xeMay.InThongtin();
                }
            }

            // Cách 2
            var listTimKiem = (from xeMay in listXM
                               where xeMay.GiaTien > start &&
                                xeMay.GiaTien < end
                               select xeMay).ToList();

            foreach (var xeMay in listTimKiem)
            {
                xeMay.InThongtin();
            }
        }

        public void SapXepGiamDanTheoGia()
        {
            // Sắp xếp và in ra danh sách...: Sắp xếp -> In ra
            // Sắp xếp: Sắp xếp

            // Sắp xếp
            // Cách 1: For : Chỉ dễ khi sắp xếp theo int, float, double,...
            //for (int i = 0; i < listXM.Count(); i++)
            //{

            //}

            // Cách 2: Linq
            // ascending/null: tăng, descending: giảm
            listXM = (from xeMay in listXM // duyệt các phần tử xeMay trong listXM
                      orderby xeMay.GiaTien descending // sắp xếp theo xeMay.GiaTien
                      select xeMay).ToList(); // Tổng hợp lại vào 1 list
        }

        public void Xoa()
        {
            // string maXeMay, string hangXe, double giaTien
            // index -> vị trí của phần tử
            // Xóa: Tìm Kiếm -> Xóa

            // Tìm kiếm
            Console.Write("Nhập mã xe máy cần tìm: ");
            string maCanTim = Console.ReadLine();

            // Dùng foreach
            foreach (var xeMay in listXM)
            {
                if (xeMay.MaXeMay.Equals(maCanTim))
                {
                    listXM.Remove(xeMay);
                    break; // thoát sau khi xóa
                }
            }

            // Dùng for
            for (int i = 0; i < listXM.Count(); i++)
            {
                // Không phân biệt hoa thường
                if (listXM[i].MaXeMay.ToUpper().Equals(maCanTim.ToUpper()))
                {
                    listXM.RemoveAt(i);
                    break; // thoát sau khi xóa
                }
            }
        }
    }
}
