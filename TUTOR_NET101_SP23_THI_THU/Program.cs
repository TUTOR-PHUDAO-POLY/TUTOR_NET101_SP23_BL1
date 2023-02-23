
using TUTOR_NET101_SP23_THI_THU;

namespace TUTOR_NET101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo QLXM
            QLXM qLXM = new QLXM();

            // Chạy menu->lựa chọn->thực hiện chức năng
            while (true)
            {
                // Menu
                Console.WriteLine("===MENU===");
                Console.WriteLine("===1. Nhập===");
                Console.WriteLine("===2. Xuất===");
                Console.WriteLine("===3. Tìm kiếm theo khoảng giá===");
                Console.WriteLine("===4. Sắp xếp giảm dần theo giá===");
                Console.WriteLine("===5. Xóa===");
                Console.WriteLine("===6. Kế thừa===");
                Console.WriteLine("===0. Thoát===");
                Console.Write("Chọn chức năng: ");

                // Nhập lựa chọn
                string luaChon = Console.ReadLine();

                // Thực hiện chức năng tương ứng
                switch (luaChon)
                {
                    case "1":
                        qLXM.Nhap();
                        break;
                    case "2":
                        qLXM.Xuat();
                        break;
                    case "3":
                        qLXM.TimKiemTheoKhoangGia();
                        break;
                    case "4":
                        qLXM.SapXepGiamDanTheoGia();
                        break;
                    case "5":
                        qLXM.Xoa();
                        break;
                    case "6":
                        XeSo xeSo = new XeSo();
                        xeSo.InThongtin();
                        break;
                    case "0":
                        Console.WriteLine("<!> BẠN ĐÃ THOÁT !");
                        return;
                    default:
                        Console.WriteLine("<!> Nhập lại. Chọn từ 0-5 !");
                        break;
                }
            }
        }
    }

}