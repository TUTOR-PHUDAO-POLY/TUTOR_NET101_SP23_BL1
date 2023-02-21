using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_BL1_Buoi5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khái niệm.
            //Kế thừ trong c# là gì? Câu trúc Con : Cha
            //Kế thừa trong C# là một tính năng cho phép bạn tạo ra một lớp mới bằng cách sử dụng các thành phần của lớp hiện có. Lớp mới được gọi là lớp con, và lớp ban đầu được gọi là lớp cha.

            //Khi bạn kế thừa từ một lớp cha, lớp con sẽ tự động có các thành phần của lớp cha, bao gồm các thuộc tính, phương thức và trường. Lớp con có thể sử dụng các thành phần này hoặc thay đổi chúng để phù hợp với nhu cầu của nó.

            //Ví dụ, giả sử bạn có một lớp cha là "Động vật", và bạn muốn tạo một lớp con gọi là "Chó".Bằng cách kế thừa từ lớp cha, lớp con "Chó" sẽ có các thuộc tính chung của lớp cha như "Tên", "Tuổi" và "Cân nặng".Bạn có thể thêm các thuộc tính mới như "Loài", "Màu sắc" và các phương thức mới như "Sủa" và "Chạy".

            //Điều này giúp tiết kiệm thời gian và công sức, vì bạn không cần phải tạo lại các thuộc tính và phương thức đã được xác định trong lớp cha.Thay vào đó, bạn chỉ cần tập trung vào việc thêm các thành phần mới cho lớp con.
            //Con : Cha(ten, tuoi,...)
            //Bài 1: Tạo class Nguoi gồm các thông tin: ten - String , tuoi - int, gioiTinh - int (1-Nam, 0- Nữ),  queQuan - String , sdt - String , email - String và các phương thức constructor, getter, setter và hàm display() : void

            //Tạo class SinhVien kế thừa từ class Nguoi nhưng thêm thuộc tính diem-double và các phương thức constructor, getter, setter và display(): void. Nhập thông tin của 1 sinh viên và in ra màn hình(Sử dụng constructor không tham số)
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //SinhVien sinhVien = new SinhVien();
            //Console.WriteLine("Tên: ");
            //sinhVien.Ten = Console.ReadLine();
            //Console.WriteLine("Tuổi: ");
            //sinhVien.Tuoi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Giới tính: ");
            //sinhVien.GioiTinh = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Quê quán: ");
            //sinhVien.QueQuan = Console.ReadLine();
            //Console.WriteLine("Sđt: ");
            //sinhVien.Sdt = Console.ReadLine();
            //Console.WriteLine("Email: ");
            //sinhVien.Email = Console.ReadLine();
            //Console.WriteLine("Điểm: ");
            //sinhVien.Diem = Convert.ToDouble(Console.ReadLine());

            //sinhVien.InRaCha();
            //Console.WriteLine("------------------------------------------");
            //sinhVien.InRaCon();






            // Bài 2: Tạo class DongVat gồm các thuộc tính : ma- String , ten-String , gioiTinh-int (1-Đức, 2- Cái), canNang- int và các phương thức constructor, getter, setter và inThongTin(): void
            //Tạo class QLDongVat sử dụng ArrayList<DongVat>.Các chức năng viết trong class này
            //Tạo Class Main: trong hàm main() tạo menu lặp đi lặp lại tới khi chọn 0  và làm các chức năng:
            //  1.Thêm động vật(Sau khi thêm hỏi có muốn thêm tiếp hay ko? Y/N)
            //	2.Hiển thị dsach động vật
            //	4.Tìm động vật có tên bắt đầu là chữ “t"
            //	5.Tạo class Meo kế thừa từ DongVat và thêm thuộc tính tiengKeu - String và các phương thức constructor, getter, setter và hàm inThongTin() : void. Nhập thông tin của mèo và hiển thị ra.Sử dụng constructor có tham số.
            //	0.Thoát

            //Console.WriteLine("Menu");
            //Console.WriteLine("1.Thêm động vật");
            //Console.WriteLine("2.Hiển thị dsach động vật");
            //Console.WriteLine("3.Tìm động vật có tên bắt đầu là chữ 't'");
            //Console.WriteLine("5");
            //int cn = 0;
            //QLDongVat qLDongVat = new QLDongVat();
            //do
            //{
            //    Console.WriteLine("Chọn chức năng: ");
            //    cn = Convert.ToInt32(Console.ReadLine());
            //    switch (cn)
            //    {
            //        case 1:
            //            qLDongVat.AddDV();
            //            break;
            //        case 2:
            //            qLDongVat.HienThi();
            //            break;
            //        case 3:
            //            qLDongVat.TimKiem();
            //            break;
            //        case 4:
            //            qLDongVat.InRaKT();
            //            break;
            //        default:
            //            break;

            //    }
            //} while (true);

            // Bài 3:
            // Tạo Class ThucVat gồm các thuộc tính: ma - String , ten - String , loaiCay - String, khuVucSong - String và các phương thức constructor, getter, setter và hàm inThongTin(): void
            //  Tạo class QLThucVat sử dụng ArrayList<ThucVat>.Các chức năng viết trong class này
            //  Tạo Class Main: trong hàm main() tạo menu lặp đi lặp lại tới khi chọn 0  và làm các chức năng:
            //	1.Thêm thực vật(Sau khi thêm hỏi có muốn thêm tiếp hay ko)
            //	2.Hiển thị dsach thực vật
            //	3.Tìm kiếm tên thực vật bắt đầu bằng "t"
            //	4.Hiển thị dsach các thực vật ở vị trí chẵn.
            //	5. Tạo class Class CayAnQua kế thừa class ThucVat thêm thuộc tính: soNamTuoi - int và các phương thức constructor, getter, setter và inThongTin(): void. Nhập thông tin 1 cây ăn quả sử dụng constructor có tham số và in ra màn hình cây ăn quả vừa nhập.
        }
    }
}
