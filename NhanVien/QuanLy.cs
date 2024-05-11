using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project.NhanVien
{
    public class QuanLy: NhanVien
    {
        string tenChucVu;
        double heSoChucVu;

        public string TenChucVu { get => tenChucVu; set => tenChucVu = value; }
        public double HeSoChucVu { get => heSoChucVu; set => heSoChucVu = value; }

        public QuanLy():base() { }

        

        public override void nhapbangDatagriew(DataGridViewRow selectedRow, string mnv)
        {
            base.nhapbangDatagriew(selectedRow, mnv);
            TenChucVu = selectedRow.Cells["TENCHUCVU"].Value.ToString();
            HeSoChucVu = double.Parse(selectedRow.Cells["HESOCHUCVU"].Value.ToString());
        }

        public override double phuCap()
        {
            return phuCapThamNien();
        }

        public override void nhapTT(string manv, string tennv, string gt, string cccd, string ns, string namvl
            , string lcv, string lcb)
        {
            base.nhapTT(manv, tennv, gt, cccd, ns, namvl, lcv, lcb);
            
        }

        public void nhapTT(string manv, string tennv,  string gt, string cccd, string ns, string namvl
            , string lcv, string lcb, string tencv, string hscv)
        {
            base.nhapTT(manv, tennv, gt, cccd, ns, namvl, lcv, lcb);
            TenChucVu = tencv;
            HeSoChucVu = double.Parse(hscv);
        }

        public override double thuNhap()
        {
            return LuongCoBan * heSoChucVu + phuCap();
        }
    }
}
