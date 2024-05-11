using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project.HoaDon
{
    public class HoaDonPhongDoi: HoaDon
    {

        public HoaDonPhongDoi() { }

        public override double TongTien()
        {
            return (tienPhong() + tinhTienThue()) - TiengiamGia();
        }

        public double TiengiamGia()
        {
            return tienPhong() * 0.02;
        }
    }
}
