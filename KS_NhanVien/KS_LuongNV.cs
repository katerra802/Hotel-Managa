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
    public partial class KS_LuongNV : Form
    {
        public bool isClose = true;
        private string s;
        private QuanLy ql = null;
        private BinhThuong bt = null;

        public KS_LuongNV(QuanLy ql, BinhThuong bt)
        {
            InitializeComponent();
            this.ql = ql;
            this.bt = bt;
            if (ql != null)
            {
                xuatTT(ql);
            }
            else if (bt != null)
            {
                xuatTT(bt);
            }

        }

        public void xuatTT(QuanLy ql)
        {
            lab_mnv.Text = ql.MaNV;
            lab_tennv.Text = ql.TenNV;
            lab_cccd.Text = ql.Cccd;
            lab_nsinh.Text = Convert.ToString(ql.NamSinh);
            lab_nvl.Text = Convert.ToString(ql.NamVaoLam);
            lab_lcv.Text = ql.LoaiCV + "; chức vụ: " + ql.TenChucVu;
            lab_thamnien.Text = Convert.ToString(ql.thamNien);
            lab_pcap.Text = Convert.ToString(ql.phuCap());
            lab_lcb.Text = Convert.ToString(ql.LuongCoBan);
            lab_thunhap.Text = Convert.ToString(ql.thuNhap());
        }

        public void xuatTT(BinhThuong bt)
        {
            lab_mnv.Text = bt.MaNV;
            lab_tennv.Text = bt.TenNV;
            lab_cccd.Text = bt.Cccd;
            lab_nsinh.Text = Convert.ToString(bt.NamSinh);
            lab_nvl.Text = Convert.ToString(bt.NamVaoLam);
            lab_lcv.Text = bt.LoaiCV;
            lab_thamnien.Text = Convert.ToString(bt.thamNien);
            lab_pcap.Text = Convert.ToString(bt.phuCap());
            lab_lcb.Text = Convert.ToString(bt.LuongCoBan);
            lab_thunhap.Text = Convert.ToString(bt.thuNhap());
        }

        public event EventHandler ok;

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KS_LuongNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isClose) Application.Exit();
        }
    }
}
