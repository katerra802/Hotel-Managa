using OOP_project.DBC;
using OOP_project.TaiKhoang;
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
    public partial class KS_DangNhapNV : Form
    {
        public bool isClose = true;
        DBC.DBCInformation find = new DBCInformation();
        public KS_DangNhapNV()
        {
            InitializeComponent();
        }

        public event EventHandler opTionLogin;


        private void button2_Click(object sender, EventArgs e)
        {
            opTionLogin(this, e);
        }

        
        private void button1_Click(object sender, EventArgs e)//nut dang nhap
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text)) throw new Exception("Bạn chưa nhập tài khoản và mật khẩu!");
                if (string.IsNullOrEmpty(textBox1.Text)) throw new Exception("Tên đăng nhập không được để trống!");
                if (string.IsNullOrEmpty(textBox2.Text)) throw new Exception("Mật khẩu không được để trống!");
                if (!CheckLogin(textBox1.Text, textBox2.Text)) throw new Exception("Thông tin đăng nhập sai");

                string query = "select CCCD from TAIKHOAN where TENTAIKHOAN = @username";
                string id_cccd = find.lay1TT(query, textBox1.Text, "@username");
                string lnv = textBox1.Text.Substring(0, 2);
                switch(lnv)
                {
                    case "BT":
                        KS_DichVuNVBT bt = new KS_DichVuNVBT(this, id_cccd);
                        bt.Show();
                        break;
                    case "QL":
                        KS_QuanLyALL _qlall = new KS_QuanLyALL(this, id_cccd);
                        _qlall.Show();
                        break;

                    default:
                        throw new Exception("Đăng nhập thất bại");
                        
                }

                
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void KS_DangNhapNV_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KS_TaoTaiKhoanNV tknv = new KS_TaoTaiKhoanNV(this);
            tknv.Show();
            this.Hide();
            tknv.Login += Tknv_Login;
        }

        private void Tknv_Login(object? sender, EventArgs e)
        {
            (sender as KS_TaoTaiKhoanNV).isClose = false;
            (sender as KS_TaoTaiKhoanNV).Close();
            this.Show();
        }

        public bool CheckLogin(string username, string password)
        {
            string query = "select * from TAIKHOAN where TENTAIKHOAN = @username and MATKHAU = @password";
            Taikhoan tk = find.TaikhoanLogin(query, username, password, "@username", "@password");
            if (tk != null)
            {
                return true;
            }
            return false;
        }
    }
}
