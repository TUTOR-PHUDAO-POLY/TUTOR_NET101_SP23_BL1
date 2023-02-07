using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_BL1_Buoi2
{
    internal class QLDongVat
    {
        List<DongVat> listDongVat = new List<DongVat>()
        {
            new DongVat("1","A",1,1,1),
            new DongVat("1","W",1,1,2),
            new DongVat("1","G",1,1,5),
            new DongVat("4","B",1,1,1),
            new DongVat("5","C",1,1,3),
            new DongVat("6","D",1,1,7),
        };

        public void HienThi()
        {
            foreach (var dv in listDongVat)
            {
                dv.Display();
            }
        }

        public void SapXepTangDanTheoTen()
        {
            listDongVat = (from dv in listDongVat
                           orderby dv.Ten
                           select dv).ToList();
        }

        public void SapXepGiamDanTheoCanNang()
        {
            listDongVat = (from dv in listDongVat
                           orderby dv.CanNang descending
                           select dv).ToList();
        }

        public void TimKiemTheoTen(string tenCanTim)
        {
            Console.WriteLine("Dong vat can tim");
            foreach (var dv in listDongVat)
            {
                // string.equals
                if (dv.Ten == tenCanTim)
                {
                    dv.Display();
                }
            }
        }

        public void XoaTheoMa(string maCanXoa)
        {
            // for có thể xóa nhiều hơn 1 phần tử
            for (int i = 0; i < listDongVat.Count(); )
            {
                if (listDongVat[i].Ma == maCanXoa)
                {
                    listDongVat.Remove(listDongVat[i]);
                }
                else
                {
                    i++;
                }    
            }

            // foreach khi xóa nhiều nhất 1 phần tử
            //foreach (var dv in listDongVat)
            //{
            //    // string.equals
            //    if (dv.Ma == maCanXoa)
            //    {
            //        listDongVat.Remove(dv);
            //        break; // lưu ý có break
            //    }
            //}
        }
    }
}
