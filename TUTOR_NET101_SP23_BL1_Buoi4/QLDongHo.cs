using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_BL1_Buoi4
{
    internal class QLDongHo
    {
        List<DongHo> listDH = new List<DongHo>();

        public QLDongHo()
        {

        }

        public void NhapThongTin()
        {
            bool nhapTiep = true;

            do
            {
                DongHo dongHo = new DongHo();
                Console.Write("Nhập mã: ");
                dongHo.MaDongHo = Console.ReadLine();
                Console.Write("Nhập thể loại: ");
                dongHo.TheLoai = Console.ReadLine();
                Console.Write("Nhập màu sắc: ");
                dongHo.MauSac = Console.ReadLine();
                Console.Write("Nhập kích thước: ");
                dongHo.KichThuoc = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập chất liệu: ");
                dongHo.ChatLieu = Console.ReadLine();
                Console.Write("Nhập giá: ");
                dongHo.Gia = Convert.ToInt32(Console.ReadLine());

                listDH.Add(dongHo);

                Console.WriteLine("Nhập tiếp ? 1-có, 2-dừng");
                string luaChon = Console.ReadLine();
                switch (luaChon)
                {
                    case "1":
                        //nhapTiep = true;
                        break;
                    case "2":
                        nhapTiep = false;
                        break;
                    default:
                        nhapTiep = false;
                        break;
                }

            } while (nhapTiep);
        }

        public void InThongTin() 
        {
            foreach (var dongHo in listDH)
            {
                dongHo.InThongTin();
            }
        }

        public void TimKiemTheoKhoangGia()
        {
            // Nhập khoảng giá
            Console.WriteLine("Nhập khoảng giá:");
            Console.Write("Từ: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Đến: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Danh sách đồng hồ có khoảng giá từ {start} đến {end}");

            // Cách 1: Không dùng Linq
            // Duyệt list -> in ra đối tượng thỏa mãn điều kiện
            foreach (var dongHo in listDH)
            {
                // dongho.gia >= start && dongho.gia <= end
                if (dongHo.Gia > start && dongHo.Gia < end ||
                    dongHo.Gia == start ||
                    dongHo.Gia == end)
                {
                    dongHo.InThongTin();
                }
            }

            // Cách 2: Dùng Linq
            // Duyệt list -> return listTimKiem đã thỏa mãn điều kiện -> in toàn bộ listTimKiem
            List<DongHo> listTimKiem = (from dongHo in listDH
                                        where dongHo.Gia > start && dongHo.Gia < end ||
                                                dongHo.Gia == start ||
                                                dongHo.Gia == end
                                        select dongHo).ToList();

            foreach (var dongHo in listTimKiem)
            {
                dongHo.InThongTin();
            }
        }

        public void XoaTheoMa()
        {
            // Tìm kiếm đối tượng cần xóa
            // Nhập mã
            Console.WriteLine("Nhập mã cần xóa:");
            string maCanTim = Console.ReadLine();

            // Cách 1: Không dùng Linq
            // Duyệt list -> in ra đối tượng thỏa mãn điều kiện
            Console.WriteLine("Danh sách đồng hồ sẽ bị xóa");
            foreach (var dongHo in listDH)
            {
                if (dongHo.MaDongHo == maCanTim)
                {
                    dongHo.InThongTin();
                }
            }

            // Xóa đối tượng

            // Xóa 1 đối tượng
            // Cách 1: dùng forreach
            // không có break => Lỗi: modified list
            foreach (var dongHo in listDH) 
            {
                if (dongHo.MaDongHo == maCanTim)
                {
                    listDH.Remove(dongHo);
                    break; // xóa 1 đối tượng -> thoát khỏi vòng lặp
                }
            }
            // Cách 1: dùng for
            for (int i = 0; i < listDH.Count; i++)
            {
                if (listDH[i].MaDongHo == maCanTim)
                {
                    listDH.RemoveAt(i); // Xóa đối tượng dựa vào vị trí tìm được
                    break; // xóa 1 đối tượng -> thoát khỏi vòng lặp
                }
            }

            // Xóa nhiều hơn 1 đối tượng
            // 0,1,2,3,4 -> Xóa A
            // A0,A1,A2,A3,A4
            // 1.Chạy i=0
            // Xóa A0 -> A1,A2,A3,A4
            // 2.Chạy i=1
            // Xóa A2 -> A1,A3,A4
            // 3.Chạy i=2
            // Xóa A4 -> A1,A3
            // 4.Chạy i=3
            // THOÁT RỒI -> A1,A3
            for (int i = 0; i < listDH.Count; i++)
            {
                if (listDH[i].MaDongHo == maCanTim)
                {
                    listDH.RemoveAt(i); // Xóa đối tượng dựa vào vị trí tìm được
                }
            }

            // SAU KHI SỬA
            // A0,A1,B2,A3,A4
            // 1.Chạy i=0
            // Xóa A0 -> A1,B2,A3,A4
            // 2.Chạy i=0
            // Xóa A1 -> B2,A3,A4
            // 3.Chạy i=0
            // Xóa KHÔNG XÓA -> B2,A3,A4
            // 4.Chạy i=1
            // Xóa A3 -> B2,A4
            // 5.Chạy i=1
            // Xóa a4 -> B2
            // 6.Chạy i=1
            // THOÁT RỒIIII

            // TEST TIẾP
            // A0,A1,B2,A3,A4,B5,A6
            // 1.Chạy i=0
            // Xóa A0 -> A1,B2,A3,A4,B5,A6
            // 2.Chạy i=0
            // Xóa A1 -> B2,A3,A4,B5,A6
            // 3.Chạy i=0
            // Xóa KHÔNG XÓA -> B2,A3,A4,B5,A6
            // 4.Chạy i=1
            // Xóa A3 -> B2,A4,B5,A6
            // 5.Chạy i=1
            // Xóa A4 -> B2,B5,A6
            // 6.Chạy i=1
            // Xóa KHÔNG XÓA -> B2,B5,A6
            // 7. Chạy 1=2
            // Xóa A6 -> B2,B5
            // 8. Chạy 1=2
            // THOÁT RỒI !

            // Tìm được -> i = i
            // Không tìm được -> i = i + 1
            for (int i = 0; i < listDH.Count; )
            {
                if (listDH[i].MaDongHo == maCanTim)
                {
                    listDH.RemoveAt(i); // Xóa đối tượng dựa vào vị trí tìm được
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
