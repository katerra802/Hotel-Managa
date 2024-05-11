using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project.NhanVien
{
    public class BinhThuong: NhanVien
    {
        double phuCapDiChuyen;

        public double PhuCapDiChuyen { get => phuCapDiChuyen; set => phuCapDiChuyen = value; }

        public BinhThuong():base() { }

        public override double phuCap()
        {
            return phuCapDiChuyen + phuCapThamNien();
        }

        public override void nhapTT(string manv, string tennv, string gt, string cccd, string ns, string namvl, string lcv, string lcb)
        {
            base.nhapTT(manv, tennv, gt, cccd, ns, namvl, lcv, lcb);
        }

        public override void nhapbangDatagriew(DataGridViewRow selectedRow, string mnv)
        {
            base.nhapbangDatagriew(selectedRow, mnv);
        }

        public override double thuNhap()
        {
            return LuongCoBan + phuCap();
        }
    }
}
