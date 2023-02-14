using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02TuTor
{
    internal class QLDienThoai
    {
        List<DienThoai> dienThoais = new List<DienThoai>();

        public void NhapThongTin()
        {
            DienThoai dienThoai = new DienThoai();
            Console.WriteLine("Tên ");
            dienThoai.Ten = Console.ReadLine();

            Console.WriteLine("Hãng ");
            dienThoai.Hang = Console.ReadLine();
            Console.WriteLine("Màu ");
            dienThoai.Mau = Console.ReadLine();

            Console.WriteLine("Bộ nhớ ");
            dienThoai.BoNho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Giá ");
            dienThoai.Gia = int.Parse(Console.ReadLine());

            dienThoais.Add(dienThoai);
        }

        public void InRaManHinh()
        {
            for (int i = 0; i < dienThoais.Count; i++)
            {
                dienThoais[i].InRa();
            }
        }

        //Tìm kiếm đt có giá cao nhất
        public void TimKiemDTDT()
        {
            //1000 => checkGia = 1000.
            //500 
            //1500 => checkGia = 1500.
            //int checkGia = int.MinValue;
            ////int checkGia = 0;
            //for (int i = 0; i < dienThoais.Count; i++)
            //{
            //    if (checkGia < dienThoais[i].Gia)
            //    {
            //        checkGia = dienThoais[i].Gia;
            //    }
            //}

            //for (int i = 0; i < dienThoais.Count; i++)
            //{
            //    if (checkGia == dienThoais[i].Gia)
            //    {
            //        Console.WriteLine("Đt giá trị cao nhất");
            //        dienThoais[i].InRa();
            //    }
            //}


            var result = (from dt in dienThoais
                          orderby dt.Ten
                          select dt).ToList();
            foreach (var item in result)
            {
                item.InRa();
            }


            var result1 = dienThoais.OrderBy(c => c.Ten).ToList();

        }
    }
}
