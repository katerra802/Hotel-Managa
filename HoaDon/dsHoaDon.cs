using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project.HoaDon
{
    public class dsHoaDon
    {
        List<HoaDon> dshd = new List<HoaDon>();

        public List<HoaDon> Dshd { get => dshd; set => dshd = value; }

        public double tongTienHoaDon()
        {
            return dshd.Sum(t => t.TongTienHD);
        }
    }
}
