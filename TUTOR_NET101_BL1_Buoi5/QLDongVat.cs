using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_BL1_Buoi5
{
    internal class QLDongVat
    {       //1.Thêm động vật(Sau khi thêm hỏi có muốn thêm tiếp hay ko? Y/N)
            //	2.Hiển thị dsach động vật
            //	4.Tìm động vật có tên bắt đầu là chữ “t".
            //	5.Tạo class Meo kế thừa từ DongVat và thêm thuộc tính tiengKeu - String và các phương thức constructor, getter, setter và hàm inThongTin() : void. Nhập thông tin của mèo và hiển thị ra.Sử dụng constructor có tham số.
        List<DongVat> dongVats = new List<DongVat>();

        public void AddDV()
        {
            string check;
            do
            {
                DongVat dongVat = new DongVat();

                Console.WriteLine("Mã: ");
                dongVat.Ma = Console.ReadLine();
                Console.WriteLine("Tên: ");
                dongVat.Ten = Console.ReadLine();
                Console.WriteLine("Giới tính: ");
                dongVat.GioTinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cân nặng: ");
                dongVat.CanNang = Convert.ToInt32(Console.ReadLine());
                dongVats.Add(dongVat);

                Console.WriteLine("Bạn muốn nhập tiếp không (Y để tiếp tục)");
                check = Console.ReadLine();

            } while (check == "Y");
        }

        public void HienThi()
        {
            Console.WriteLine("Danh sách động vật");
            foreach (var dv in dongVats)
            {
                dv.InRaDV();
            }
        }

        public void TimKiem()
        {
            //for (int i = 0; i < dongVats.Count; i++)
            //{
            //    //Cắt từ vị trí số 0 lấy 1 phần tử.
            //    if (dongVats[i].Ten.Substring(0, 1) == "t")
            //    {
            //        dongVats[i].InRaDV();
            //    }
            //}
            //foreach (var dv in dongVats)
            //{
            //    //Với tìm kí tự 't' ở cuối
            //    if (dv.Ten[dv.Ten.Length - 1] == 't')
            //    {
            //        dv.InRaDV();
            //    }
            //}


            //Dùng linq
            //var result = (from dv in dongVats
            //             where dv.Ten.StartsWith("t")
            //             select dv).ToList();
            //foreach (var item in result)
            //{
            //    item.InRaDV();
            //}

            //Dùng linq tìm chuỗi kí tự
            var result = (from dv in dongVats
                          where dv.Ten.EndsWith("uong")
                          select dv).ToList();
            foreach (var item in result)
            {
                item.InRaDV();
            }
        }

        public void InRaKT()
        {
            Console.WriteLine("Mã: ");
            string ma = Console.ReadLine();
            Console.WriteLine("Tên: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Giới tính: ");
            int gioTinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cân nặng: ");
            int canNang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tiếng kêu: ");
            string tiengKeu = Console.ReadLine();
            Meo meo = new Meo(ma, ten, gioTinh, canNang, tiengKeu);

            meo.InRaDV();

            Console.WriteLine("-----------------------------------");
            meo.InRaMeo();
        }
    }
}
