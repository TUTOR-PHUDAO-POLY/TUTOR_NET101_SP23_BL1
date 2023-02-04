using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_BL1_Buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;//Đầu ra đầu vào nhận được Tiếng Việt
            Console.OutputEncoding = Encoding.Unicode;
            //Bài1: Nhập thông tin gồm tên , tuổi, địa chỉ, điểm, trường học của bản thân và in ra .
            //Console.Write("Nhập  tên của bạn: ");
            //string ten = Console.ReadLine();
            //Console.Write("Nhập tuổi của bạn: ");
            //int tuoi = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Nhập địa chỉ của bạn: ");
            //string diaChi = Console.ReadLine();
            //Console.Write("Nhập điẻm của bạn: ");
            //string diem = Console.ReadLine();
            //Console.Write("Nhập trường học của bạn: ");
            //string truongHoc = Console.ReadLine();

            ////Nhân đôi dòng code Ctrl + D
            //Console.WriteLine($"Tên của bạn là {ten}");
            //Console.WriteLine($"Tuổi của bạn là {tuoi}");
            //Console.WriteLine($"Địa chỉ của bạn là {diaChi}");
            //Console.WriteLine($"Điểm của bạn là {diem}");
            //Console.WriteLine($"Trường học của bạn là {truongHoc}");

            //Bài 2: Nhập 2 số dương a,b tính tổng, hiệu tích thương và in các kết quả ra màn hình.
            //Console.Write("Nhận a: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhận b: ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //int tong = 0;
            //int hieu = 0;
            //int tich = 0;
            //double thuong = 0;
            //bool e;
            //tong = a + b;
            //hieu = a - b;
            //tich = a * b;           
            //thuong = (double)a / (double)b;
            //thuong = Convert.ToSingle(a) / Convert.ToSingle(b);

            //Console.WriteLine($"Tổng: {tong}");
            //Console.WriteLine($"Hiêuj: {hieu}");
            //Console.WriteLine($"Tích: {tich}");
            //Console.WriteLine($"Thương: {thuong}");

            //Console.WriteLine($"Tổng là {tong}  Hiệu là :{hieu} Tích {tich} Thương là {thuong}");

            //Console.WriteLine("Nhập số thập phân:");
            //double check = Convert.ToDouble(Console.ReadLine());

            //if ((int)check - check == 0)
            //{
            //    Console.WriteLine("số này là số nguyên");
            //}

            //Bài 3: Nhập số nguyên dương n(0 < n < 20) tính tổng các số chẵn từ 1 - n.
            //Console.WriteLine("Nhập n: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n > 0 && n < 20)
            //{
            //    int tong = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            tong = tong + i;
            //        }
            //    }
            //    Console.WriteLine($"Tổng số từ 1 - {n} là {tong}");
            //}

            //Bài 4: Nhập số nguyên dương n  tính tích các số lẻ từ 1-n.
            //Console.Write("Nhận N = ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        tich = tich * i;
            //    }
            //}
            //Dùng while
            //int i = 0;
            //int tich = 0;
            //while (i < N && N < 10)
            //{
            //    tich = 1;
            //    if (i % 2 != 0)
            //    {
            //        tich = tich * i;
            //    }
            //    i++;
            //}
            //int tich2 = 0;
            //int j = 0;
            //do
            //{
            //    tich2 = 1;
            //    if (j % 2 != 0)
            //    {
            //        tich2 = tich2 * j;
            //    }
            //    j++;
            //} while (j < N && N < 10);

            //Console.WriteLine($"tích: {tich}");
            //Console.WriteLine($"tích: {tich2}");

            //Bài 5: Viết chương trình nhập vào tháng và in ra số ngày của tháng đó trong năm.
            //Console.Write("Nhap thang : ");
            //string Sthang = Console.ReadLine();
            //Console.Write("Nhap nam : ");
            //string Snam = Console.ReadLine();

            //int th = int.Parse(Sthang);
            //int nm = int.Parse(Snam);
            //int songay = 0;

            //if (th >= 1 && th <= 12)
            //{
            //    switch (th)
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12: songay = 31; break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11: songay = 30; break;

            //        case 2:
            //            if (nm % 400 == 0 || (nm % 4 == 0 && nm % 100 != 0))    // nam nhuan
            //                songay = 29;
            //            else
            //                songay = 28;
            //            break;
            //    }

            //    Console.Write("=> Thang " + th + "/" + nm + " co " + songay + " ngay\n");
            //}
            //else
            //    Console.Write("=> Thang khong hop le!\n");
            //Console.ReadLine();

            //Toán tử 3 ngôi
            //Console.WriteLine("Nhập n: ");
            //int baNgoi = Convert.ToInt32(Console.ReadLine());

            //string inRa = "";


            //inRa = (baNgoi > 10) ? "N lớn hơn 10" : "N Nhỏ hơn 10";

            //if (baNgoi > 10)
            //{
            //    inRa = "N lớn hơn 10";
            //}
            //else
            //{
            //    inRa = "N Nhỏ hơn 10";
            //}

            Console.ReadKey();
        }
    }
}
