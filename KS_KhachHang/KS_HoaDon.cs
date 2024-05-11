using ConsoleApplication1;
using OOP_project.HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project.KS_KhachHang
{
    public partial class KS_HoaDon : Form
    {
        private Form f = null;
        private Danhsachphong dsp = null;
        private dsHoaDon dshd = null;
        public KS_HoaDon(KS_DichVuKH f, Danhsachphong dsp, dsHoaDon dshd)
        {
            InitializeComponent();
            this.f = f;
            this.dsp = dsp;
            this.dshd = dshd;
            xuatTTKH();
        }

        private void xuatTTKH()
        {
            Phong.Phong pn = dsp.ttPhong(0);
            
            lab_ten.Text = pn.ten;
            lab_cccd.Text = pn.maKhach;
            lab_idroom.Text = dsp.xuatTatCaCacMaPhong();
            lab_type.Text = dsp.xuatTatCaCacLoaiP();
            lab_thoiGianThue.Text = Convert.ToString(dsp.tongNgayThue());
            lab_soluongPhong.Text = Convert.ToString(dsp.tongSoluong());
            lab_sumbill.Text = Convert.ToString(dshd.tongTienHoaDon());
        }
    }
}
