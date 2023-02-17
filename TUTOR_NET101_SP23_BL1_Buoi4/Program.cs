using TUTOR_NET101_SP23_BL1_Buoi4;
using System.Text;

namespace Buoi04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            #region Bài 1
            //QLLHopHoc qLLHopHoc = new QLLHopHoc();

            //do
            //{
            //    // Menu
            //    Console.WriteLine("MENU");
            //    Console.WriteLine("1. Nhập TT");
            //    Console.WriteLine("2. Xuất TT");
            //    Console.WriteLine("0. Thoát");
            //    Console.Write("Chọn chức năng: ");

            //    string luaChon = Console.ReadLine();

            //    switch (luaChon)
            //    {
            //        case "1":
            //            qLLHopHoc.NhapThongTin();
            //            break;
            //        case "2":
            //            qLLHopHoc.InThongTin();
            //            break;
            //        case "0":
            //            Console.WriteLine("BẠN ĐÃ THOÁT !");
            //            return;
            //        default:
            //            break;
            //    }
            //} while (true);
            #endregion

            #region Bài 2
            QLDongHo qLDongHo = new QLDongHo();

            do
            {
                // Menu
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhập TT");
                Console.WriteLine("2. Xuất TT");
                Console.WriteLine("2. Tìm kiếm theo khoảng giá");
                Console.WriteLine("2. Xóa theo tên");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        qLDongHo.NhapThongTin();
                        break;
                    case "2":
                        qLDongHo.InThongTin();
                        break;
                    case "3":
                        qLDongHo.TimKiemTheoKhoangGia();
                        break;
                    case "4":
                        qLDongHo.XoaTheoMa();
                        break;
                    case "0":
                        Console.WriteLine("BẠN ĐÃ THOÁT !");
                        return;
                    default:
                        break;
                }
            } while (true);
            #endregion
        }
    }
}