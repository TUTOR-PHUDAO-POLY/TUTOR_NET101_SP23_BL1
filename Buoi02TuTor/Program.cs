using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02TuTor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bài 1:
            Tạo menu gồm các chức năng (menu lặp lại cho đến khi chọn " 0 - Thoát"):
	        1.Nhập thông tin tên, tuổi, giới tính, quê quán, ngành học của bản thân và in ra màn hình
	        0.Thoát
            */
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Bai1();
            //Bai2();
            Bai3();
            Console.ReadKey();
        }
        private static void Bai1()
        {
            Console.WriteLine("Các chức năng");
            Console.WriteLine("1. Nhập thông tin và in ra");
            Console.WriteLine("2. Nhập số nguyên a, kiểm tra xem đó là số nguyên hay số dương");
            Console.WriteLine("0. Thoát");
            int cn = 0;
            do
            {
                Console.Write("Chọn CN:");
                cn = Convert.ToInt32(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        Console.Write("Tên ");
                        string ten = Console.ReadLine();
                        Console.Write("Tuổi ");
                        string tuoi = Console.ReadLine();
                        Console.Write("Giới tính ");
                        string gioiTinih = Console.ReadLine();
                        Console.Write("Quê quán ");
                        string queQuan = Console.ReadLine();
                        Console.Write("Ngành học ");
                        string nganhHoc = Console.ReadLine();

                        Console.WriteLine("Tên: {0}", ten);
                        Console.WriteLine("Tuổi: {0}", ten);
                        Console.WriteLine("Giới tính: {0}", gioiTinih);
                        Console.WriteLine("Quê quán: {0}", queQuan);
                        Console.WriteLine("Ngành học: {0}", nganhHoc);

                        break;
                    //2. Nhập số a, kiểm tra xem đó là số nguyên hay số dương.
                    case 2:
                        Console.WriteLine("Nhập a = ");
                        float a = Convert.ToSingle(Console.ReadLine());
                        if (a > 0)
                        {
                            Console.WriteLine("{0} là số dương", a);
                        }

                        //Nhập 5.5 ->  Cv Int 5 - 5.5 = -0.5 
                        //5.0 cv int -> 5 5 - 5 = 0 
                        if ((int)a - a == 0)
                        {
                            Console.WriteLine("{0} là số nguyên", a);
                        }
                        break;

                    case 0:
                        return;
                    default:
                        Console.WriteLine("Có 3 chức năng thôi má❤️❤️❤️❤️");
                        break;
                }
            } while (true);
        }

        static void Bai2()
        {
            /*Bài 2: Tạo class Nguoi gồm các thuộc tính: ten - String , tuoi - int, gioiTinh - int ( 0-Nữ, 1- Nam), queQuan - String , ngheNghiep - String   và các phương thức constructor, getter, setter và inThongTin(): void
            Tạo class QLNguoi sử dụng ArrayList<Nguoi> . Các chức năng viết trong class này
            Tạo Class Main: trong hàm main() tạo menu lặp đi lặp lại tới khi chọn 0  và làm các chức năng:
	            1.Nhập thông tin Nguoi (sau khi nhập xong thông tin 1 Nguoi, hỏi có nhập tiếp hay không)
	            2.In thông tin ra màn hình
	            0.Thoát
            */
            QLNguoi qLNguoi = new QLNguoi();
            Console.WriteLine("Các chức năng");
            Console.WriteLine("1. Nhập thông tin");
            Console.WriteLine("2. In ra");
            Console.WriteLine("0. Thoát");
            int cn = 0;
            do
            {
                Console.WriteLine("Nhập cn  ");
                cn = Convert.ToInt32(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        qLNguoi.NhapThongTinNguoi();
                        break;
                    case 2:
                        qLNguoi.InRaManHinh();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Cn 0-2");
                        break;
                }
            } while (true);
        }

        /*Bài 3:
         Tạo class DienThoai gồm các thông tin: tên, hãng - String , mau - String , boNho - int , gia - int và các phương thức constructor, getter, setter và inThongTin(): void
        Tạo class QLDienThoai sử dụng ArrayList<DienThoai> . Các chức năng viết trong class này
        Tạo Class Main: trong hàm main() tạo menu lặp đi lặp lại tới khi chọn 0  và làm các chức năng:
	        1.Nhập thông tin điện thoại
	        2.In các thông tin ra màn hình
	        3.Tìm kiếm chiếc điện thoại đắt nhất
	        0.Thoát
          */
        static void Bai3()
        {
            QLDienThoai qLDienThoai = new QLDienThoai();
            Console.WriteLine("Các chức năng");
            Console.WriteLine("1. Nhập thông tin");
            Console.WriteLine("2. In ra");
            Console.WriteLine("3. Tìm kiếm dt có giá đắt nhất");
            Console.WriteLine("0. Thoát");
            int cn = 0;
            do
            {
                Console.WriteLine("Chọn cn: ");
                cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        qLDienThoai.NhapThongTin();
                        break;
                    case 2:
                        qLDienThoai.InRaManHinh();
                        break;
                    case 3:
                        qLDienThoai.TimKiemDTDT();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            } while (true);


        }
    }
}
