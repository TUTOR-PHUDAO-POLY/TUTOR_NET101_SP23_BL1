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
            Console.WriteLine("Nhập tháng: ");
            int th = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập năm: ");
            int nam = Convert.ToInt32(Console.ReadLine());

            if (th > 0 && th <= 12)
            {
                switch (th)
                {
                    case 1:
                        Console.WriteLine($"Tháng {th}/{nam} có 31 ngày");
                        break;
                    case 2:
                        if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                        {
                            Console.WriteLine($"Tháng {th}/{nam} có 29 ngày");
                        }
                        else
                        {
                            Console.WriteLine($"Tháng {th}/{nam} có 28 ngày");
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine($"Tháng {th}/{nam} có 31 ngày");
                        break;
                    case 4:
                        Console.WriteLine($"Tháng {th}/{nam} có 30 ngày");
                        break;
                    case 5:
                        Console.WriteLine($"Tháng {th}/{nam} có 31 ngày");
                        break;
                    case 6:
                        Console.WriteLine($"Tháng {th}/{nam} có 30 ngày");
                        break;
                    case 7:
                        Console.WriteLine($"Tháng {th}/{nam} có 31 ngày");
                        break;
                    case 8:
                        Console.WriteLine($"Tháng {th}/{nam} có 31 ngày");
                        break;
                    case 9:
                        Console.WriteLine($"Tháng {th}/{nam} có 30 ngày");
                        break;
                    case 10:
                        Console.WriteLine($"Tháng {th}/{nam} có 31 ngày");
                        break;
                    case 11:
                        Console.WriteLine($"Tháng {th}/{nam} có 30 ngày");
                        break;
                    case 12:
                        Console.WriteLine($"Tháng {th}/{nam} có 31 ngày");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
