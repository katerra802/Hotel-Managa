using OOP_project.KS_NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class KS_cheDoDangNhap : Form
    {
        public KS_cheDoDangNhap()
        {
            InitializeComponent();
        }

        private void btn_KH_Click(object sender, EventArgs e)
        {
            KS_DangNhapKH kh = new KS_DangNhapKH(this);
            kh.Show();
            this.Hide();
            kh.opTionLogin += Kh_opTionLogin;
        }

        private void Kh_opTionLogin(object? sender, EventArgs e)
        {
            (sender as KS_DangNhapKH).isClose = false;
            (sender as KS_DangNhapKH).Close();
            this.Show();
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            KS_DangNhapNV nv = new KS_DangNhapNV();
            nv.Show();
            this.Hide();
            nv.opTionLogin += Nv_opTionLogin;
        }

        private void Nv_opTionLogin(object? sender, EventArgs e)
        {
            (sender as KS_DangNhapNV).isClose = false;
            (sender as KS_DangNhapNV).Close();
            this.Show();
        }
    }
}
