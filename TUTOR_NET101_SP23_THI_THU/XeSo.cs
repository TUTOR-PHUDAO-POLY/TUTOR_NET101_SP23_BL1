using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTOR_NET101_SP23_THI_THU
{
    internal class XeSo : XeMay
    {
        /*
         * Tạo lớp XeSo kế thừa từ lớp XeMay nhưng thêm thuộc tính nhienLieu – String, dongCo – String và inThongTin(): void kế thừa từ lớp cha (Đối với class con Private các thuộc tính, Getter & Setter, Contructor có tham số và không tham số)
         */
        private string nhienLieu;
        private string dongCo;

        public XeSo()
        {

        }

        public XeSo(string maXeMay, string hangXe, double giaTien,string nhienLieu, string dongCo):base(maXeMay, hangXe, giaTien)
        {
            this.NhienLieu = nhienLieu;
            this.DongCo = dongCo;
        }

        public string NhienLieu { get => nhienLieu; set => nhienLieu = value; }
        public string DongCo { get => dongCo; set => dongCo = value; }

        public override void InThongtin()
        {
            base.InThongtin();
            Console.WriteLine($"{nhienLieu} - {dongCo}");
        }

    }
}
