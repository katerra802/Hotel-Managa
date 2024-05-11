using OOP_project.KS_KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project.KS_NhanVien
{
    public partial class KS_ThongTinCaNhanNV : Form
    {
        private NhanVien.NhanVien nv = null;
        public KS_ThongTinCaNhanNV(NhanVien.NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
            if(nv != null )
            {
                xuatTT();
            }
            else
            {
                KS_EmptyForm emp = new KS_EmptyForm("Bạn chưa đăng ký thông tin"); 
            }    
        }

        private void xuatTT()
        {
            lab_mnv.Text = nv.MaNV;
            lab_tennv.Text = nv.TenNV;
            lab_gt.Text = nv.GioiTinh;
            lab_cccd.Text = nv.Cccd;
            lab_ns.Text = Convert.ToString(nv.NamSinh);
            lab_nvl.Text = Convert.ToString(nv.NamVaoLam);
            lab_thamnien.Text = Convert.ToString(DateTime.Now.Year - nv.NamVaoLam);
            lab_lcv.Text = nv.LoaiCV;
            lab_lcb.Text = Convert.ToString(nv.LuongCoBan);
        }
    }
}
