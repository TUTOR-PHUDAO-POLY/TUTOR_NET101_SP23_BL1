using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_THI_THU
{
    internal class XeMay
    {
        /*
         * Tạo 1 đối tượng XeMay (maXeMay-String, hangXe - String ,giaTien-double) và các phương thức contructor, getter, setter và  inThongTin():void - (Đối với class Private các thuộc tính, Getter & Setter, Contructor có tham số và không tham số).-1đ
         */
        // Thuộc tính (Nếu không có private thì mặc định vẫn là private)
        private string maXeMay;
        private string hangXe;
        private double giaTien;

        // Constructor
        public XeMay()
        {

        }

        public XeMay(string maXeMay, string hangXe, double giaTien)
        {
            this.MaXeMay = maXeMay;
            this.HangXe = hangXe;
            this.GiaTien = giaTien;
        }

        // Property
        // Getter, Setter
        public string MaXeMay { get => maXeMay; set => maXeMay = value; }
        public string HangXe { get => hangXe; set => hangXe = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }

        public virtual void InThongtin()
        {
            Console.WriteLine($"Xe máy: {MaXeMay} - {HangXe} - {GiaTien} ");
        }
    }

}
