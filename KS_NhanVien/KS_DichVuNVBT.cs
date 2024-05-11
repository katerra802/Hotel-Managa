using OOP_project.KS_KhachHang;
using OOP_project.NhanVien;
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
    public partial class KS_DichVuNVBT : Form
    {
        private Form _fdangnhap;
        private string idcccd;
        DBC.DBCInformation find = new DBC.DBCInformation();
        public KS_DichVuNVBT(Form _fdangnhap, string idcccd)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this._fdangnhap = _fdangnhap;
            this.idcccd = idcccd;
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            KS_EmptyForm _emp = new KS_EmptyForm("Bạn chưa có lịch làm");
            _emp.MdiParent = this;
            _emp.Show();
        }

        private void KS_DichVuNVBT_FormClosed(object sender, FormClosedEventArgs e)
        {
            _fdangnhap.Show();
        }

        private void btn_nhansu_Click(object sender, EventArgs e)
        {
            BinhThuong bt = null;
            bt = find.layTTNVBT("select * from NHANVIEN where CCCD = @cccd", idcccd);
            KS_ThongTinCaNhanNV _ttcn = new KS_ThongTinCaNhanNV(bt);
            _ttcn.MdiParent = this;
            _ttcn.Show();
        }
    }
}
