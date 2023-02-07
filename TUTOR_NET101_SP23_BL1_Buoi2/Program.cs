
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace TUTOR_NET101_SP23_BL1_Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            #region Bai 1
            /*
             * Bài 1: Nhập một mảng số nguyên từ bàn phím:
	            1.in ra số phần tử của mảng
	            2.in mảng vừa nhập ra bàn phím
	            3.in ra vị trí của giá trị min trong mảng
	            4.in ra màn hình tổng số số nguyên tố có trong mảng
	            5.sắp xếp mảng tăng dần.
             */

            // Khai báo mảng số nguyên
            //int[] arrSoNguyen = new int[5] { 2, 4, 5, 1, 7 };

            //Console.WriteLine("==========================================");
            //// Số phần tử của mảng
            //int soPhanTu = arrSoNguyen.Length;
            //Console.WriteLine($"So phan tu cua mang arrSoNguyen: {soPhanTu}");

            //Console.WriteLine("==========================================");
            //// In ra số phần tử
            //// For
            //// 0;1;2;3;4;...
            //for (int i = 0; i < arrSoNguyen.Length; i++)
            //{
            //    Console.WriteLine($"Phan tu thu {i} co gia tri {arrSoNguyen[i]}");
            //}

            //// Foreach
            //int thuTu = 0;
            //foreach (var soNguyen in arrSoNguyen)
            //{
            //    Console.WriteLine($"Phan tu thu {thuTu} co gia tri {soNguyen}");
            //    thuTu++;
            //}

            //Console.WriteLine("==========================================");
            //// Tìm ra vị trí giá trị min (nhỏ nhất)
            //// int [-2tr; +2tr]
            //// +2tr; 1tr; +2tr; +2tr; 900k
            //int giaTriMin = int.MaxValue;
            //int viTriMin = 0;
            //for (int i = 0; i < arrSoNguyen.Length; i++)
            //{
            //    if (giaTriMin > arrSoNguyen[i])
            //    {
            //        giaTriMin = arrSoNguyen[i];
            //        viTriMin = i;
            //    }
            //}
            //Console.WriteLine($"Phan tu co gia tri nho nhat la {giaTriMin} tai {viTriMin}");

            //int giaTriMin2 = arrSoNguyen[0];
            //int viTriMin2 = 0;
            //for (int i = 0; i < arrSoNguyen.Length; i++)
            //{
            //    if (giaTriMin2 > arrSoNguyen[i])
            //    {
            //        giaTriMin2 = arrSoNguyen[i];

            //        viTriMin2 = i;
            //    }
            //}
            //Console.WriteLine($"Phan tu co gia tri nho nhat la {giaTriMin2} tai {viTriMin2}");

            // In ra tổng số nguyên tố
            //int tongSoNguyenTo = 0;
            //foreach (var soNguyen in arrSoNguyen)
            //{
            //    bool isSoNguyenTo = true;
            //    // Kiem tra soNguyen co phai so nguyen to khong
            //    for (int i = 2; i < soNguyen; i++)
            //    {
            //        if (soNguyen % i == 0)
            //        {
            //            isSoNguyenTo = false;
            //        }
            //    }

            //    // Tinh tongSoNguyenTo
            //    if (isSoNguyenTo)
            //    {
            //        tongSoNguyenTo += soNguyen;
            //    }
            //}

            //Console.WriteLine($"Tong cac so nguyen to trong mang: {tongSoNguyenTo}");

            // Sap xep mang tang dan
            // Truoc khi SX
            //for (int i = 0; i < arrSoNguyen.Length; i++)
            //{
            //    Console.WriteLine($"Phan tu thu {i} co gia tri {arrSoNguyen[i]}");
            //}

            //for (int i = 0; i < arrSoNguyen.Length; i++)
            //{
            //    for (int j = i+1; j < arrSoNguyen.Length; j++)
            //    {
            //        if (arrSoNguyen[i] > arrSoNguyen[j])
            //        {
            //            int temp = arrSoNguyen[i];
            //            arrSoNguyen[i] = arrSoNguyen[j];
            //            arrSoNguyen[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("================================");
            //// Sau khi SX
            //for (int i = 0; i < arrSoNguyen.Length; i++)
            //{
            //    Console.WriteLine($"Phan tu thu {i} co gia tri {arrSoNguyen[i]}");
            //}
            #endregion

            #region Bai 2
            /*Tạo class SinhVien gồm 
             * các thuộc tính: maSV-String , hoTen - String , namSinh - int , chuyenNganh - String , diemTB- double  
             * và các phương thức contructor, getter, setter và phương thức display(): void. 
            Tạo class Main: Fix cứng 2 phần tử SinhVien và hiển thị ra màn hình
            */

            //SinhVien sv1 = new SinhVien();
            //sv1.MaSV = "PH00001";
            //sv1.HoTen = "Nguyen Van A";
            //sv1.NamSinh = 2002;
            //sv1.ChuyenNganh = "C#";
            //sv1.DiemTB = 10;

            //SinhVien sv2 = new SinhVien("PH00002", "Nguyen Van B", 2003, "Java", 9);

            //sv1.Display();
            //sv2.Display();
            #endregion

            #region Bai 3
            /*Bài 3: 
            * Tạo class DongVat gồm 
            * các thuộc tinh ma - String , ten - String ,loai - int ,gioiTinh - int ( 1- đực, 0- cái) ,canNang- int 
            * và các phương thức constructor, getter, setter và display():void
            Tạo class QLDongVat dụng ArrayList<DongVat> . Các chức năng viết trong class này
            Tạo Class Main: trong hàm main() và làm các chức năng sau:
                Fix cứng 5 phần tử động vật  vào list và hiển thị tất cả động vật ra màn hình
                Sắp xếp tăng dần theo tên động vât
                Sắp xếp giảm dần theo cân nặng
             */

            // Menu
            QLDongVat qLDongVat = new QLDongVat();
            
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Hiển Thị");
                Console.WriteLine("2. Sắp xếp tăng dần theo tên động vât");
                Console.WriteLine("3. Sắp xếp giảm dần theo cân nặng");
                Console.WriteLine("0. Thoát");

                string luaChon = Console.ReadLine();

                switch (luaChon)
                {
                    case "1":
                        qLDongVat.HienThi();
                        break;
                    case "2":
                        qLDongVat.SapXepTangDanTheoTen();
                        break;
                    case "3":
                        qLDongVat.SapXepGiamDanTheoCanNang();
                        break;
                    case "4":
                        qLDongVat.TimKiemTheoTen("A");
                        break;
                    case "5":
                        qLDongVat.XoaTheoMa("1");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Nhap khong hop le! Nhap tu 0-3 !");
                        break;
                }
            } while (true);
            #endregion

        }
    }
}
