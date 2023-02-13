using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02TuTor
{
    internal class QLNguoi
    {
        List<Nguoi> nguois = new List<Nguoi>();
        public void NhapThongTinNguoi()
        {
            //1.Nhập thông tin Nguoi (sau khi nhập xong thông tin 1 Nguoi, hỏi có nhập tiếp hay không).
            string check = "";
            do
            {
                Nguoi nguoi = new Nguoi();
                Console.WriteLine("Tên: ");
                nguoi.Ten = Console.ReadLine();
                Console.WriteLine("Tuổi : ");
                nguoi.Tuoi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Giới tính: ");
                nguoi.GioiTinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quê quán: ");
                nguoi.QueQuan = Console.ReadLine();
                Console.WriteLine("Nghề nghiệp: ");
                nguoi.NgheNghiep = Console.ReadLine();
                nguois.Add(nguoi);
                Console.WriteLine("Bạn muốn nhập tiếp hay không");
                check = Console.ReadLine();
                //Nếu khác 1 kết thúc vòng lặp
            } while (check == "1");
        }
        public void InRaManHinh()
        {
            foreach (var item in nguois)
            {
                item.InRa();
            }
        }
    }
}
