using Microsoft.VisualBasic.Logging;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using OOP_project.DBC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OOP_project.TaiKhoang;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ConsoleApplication1;

namespace OOP_project
{
    public partial class KS_DangNhapKH : Form
    {
        private DBC.DBCInformation find;
        public bool isClose = true;
        private Form f;
        public KS_DangNhapKH(Form f)
        {
            InitializeComponent();
            this.f = f; 
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
            find = new DBC.DBCInformation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opTionLogin(this, e);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text)) throw new Exception("Bạn chưa nhập tài khoản và mật khẩu!");
                if (string.IsNullOrEmpty(textBox1.Text)) throw new Exception("Tên đăng nhập không được để trống!");
                if (string.IsNullOrEmpty(textBox2.Text)) throw new Exception("Mật khẩu không được để trống!");

                if (!CheckLogin(textBox1.Text, textBox2.Text)) throw new Exception("Thông tin đăng nhập sai");

                string query = "select CCCD from TAIKHOAN where TENTAIKHOAN = @username";
                string id_cccd = find.lay1TT(query, textBox1.Text, "@username");

                query = "select MAPHONG from PHONG where CCCD = @cccd";
                KS_DichVuKH dv = new KS_DichVuKH(this, id_cccd, find.checkStateRoom(query, id_cccd, "@cccd"));
                dv.Show();
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
                dv.Logout += Dv_Logout;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Dv_Logout(object? sender, EventArgs e)
        {
            (sender as KS_DichVuKH).isClose = false;
            (sender as KS_DichVuKH).Close();
            this.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

        public bool CheckLogin(string username, string password)
        {
            DBC.DBCInformation find = new DBCInformation();
            string query = "select * from TAIKHOAN where TENTAIKHOAN = @username and MATKHAU = @password";
            Taikhoan tk = find.TaikhoanLogin(query, username, password, "@username", "@password");
            if(tk != null) 
            {
                return true;
            }
            return false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KS_TaotaikhoanKH na = new KS_TaotaikhoanKH();
            na.Show();
            this.Hide();
            na.Login += Na_Login;
        }

        private void Na_Login(object? sender, EventArgs e)
        {
            (sender as KS_TaotaikhoanKH).isCloseNA = false;
            (sender as KS_TaotaikhoanKH).Close();
            this.Show();
        }

        public event EventHandler opTionLogin;
    }
}
