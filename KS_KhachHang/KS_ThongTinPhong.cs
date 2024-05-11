using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;
using OOP_project.DBC;
using OOP_project.Phong;

namespace OOP_project.KS_KhachHang
{
    public partial class KS_ThongTinPhong : Form
    {
        public bool isClosettt = true;

        Danhsachphong ds = null;
        int n = 0;
        int i = 0;
        public KS_ThongTinPhong(Danhsachphong ds)
        {
            InitializeComponent();
            this.ds = ds;
            n = ds.tongSoluong();
            xuatThongTinphong();
        }


        public void xuatThongTinphong()
        {
            txt_soLuong.Text = Convert.ToString(n);

            Phong.Phong pn = ds.ttPhong(i);
            txt_ten.Text = pn.ten;
            txt_cccd.Text = pn.maKhach;
            txt_thoigianthue.Text = ds.tinhThoiGianThue(pn.NgayThue, pn.NgayTra);
            txt_ngaythue.Text = Convert.ToString(pn.NgayThue);
            txt_ngaytra.Text = Convert.ToString(pn.NgayTra);
            txt_type.Text = pn.loai;
            txt_idroom.Text = pn.maPhong;
            txt_price.Text = Convert.ToString(pn.gia);
            i++;
            if (i == n)
            {
                i = 0;
            }
        }

        private void btn_doithongtin_Click(object sender, EventArgs e)
        {
            xuatThongTinphong();
        }
    }
}
