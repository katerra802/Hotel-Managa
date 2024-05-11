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
    public partial class KS_QuanLyALL : Form
    {
        private Form _fdangnhap;
        private string idcccd = null;
        public KS_QuanLyALL(Form _fdangnhap, string idcccd)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this._fdangnhap = _fdangnhap;
            this.idcccd = idcccd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KS_QuanLyNhanVien _qlnv = new KS_QuanLyNhanVien(idcccd);
            _qlnv.MdiParent = this;
            _qlnv.Show();
        }

        private void btn_danhthu_Click(object sender, EventArgs e)
        {
            KS_QuanLyDanhThu _qldt = new KS_QuanLyDanhThu();
            _qldt.MdiParent = this;
            _qldt.Show();
        }

        private void KS_QuanLyALL_FormClosed(object sender, FormClosedEventArgs e)
        {
            _fdangnhap.Show();
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            KS_QuanLyPhong _qlphong = new KS_QuanLyPhong();
            _qlphong.MdiParent = this;
            _qlphong.Show();
        }
    }
}
