using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using OOP_project.DBC;

namespace OOP_project
{
    public partial class KS_TaotaikhoanKH : Form
    {
        SqlDataAdapter adapter;
        private DBConnection connection;
        DataTable dt;
        DBC.DBCInformation find = new DBCInformation();

        public bool isCloseNA = true;
        public KS_TaotaikhoanKH()
        {
            InitializeComponent();
            connection = new DBConnection();
            dt = new DataTable();
        }

        public event EventHandler Login;

        private void New_account_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isCloseNA)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login(this, new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckRegex cr = new CheckRegex();   
            try
            {
                if (string.IsNullOrEmpty(txt_tentk.Text)
                    && string.IsNullOrEmpty(txt_cccd.Text)
                    && string.IsNullOrEmpty(txt_mk.Text)
                    && string.IsNullOrEmpty(txt_nlmk.Text)) throw new Exception("Bạn chưa nhập bất kì thông tin nào!");
                if (string.IsNullOrEmpty(txt_tentk.Text)
                    || string.IsNullOrEmpty(txt_cccd.Text)
                    || string.IsNullOrEmpty(txt_mk.Text)
                    || string.IsNullOrEmpty(txt_nlmk.Text)) throw new Exception("Hãy nhập đầy đủ thông tin!");
                if (!checkMk(txt_mk.Text, txt_nlmk.Text)) throw new Exception("Hãy nhập đúng mật khẩu đã chọn!");
                if (!cr.checkTenDangNhap(txt_tentk.Text)) throw new Exception("Tên đăng nhập không được chứa tý tự đặt biệt ngoài '_'!");
                if (!cr.checkCCCD(txt_cccd.Text)) throw new Exception("Hãy nhập đúng cccd!");
                if (!cr.checkGmail(txt_gmail.Text)) throw new Exception("Hãy nhập đúng gmail!");
                if (find.checkDBC("TAIKHOAN", "where TENTK = " + txt_tentk.Text)) throw new Exception("Tên tài khoản đã tồn tại!");
                adapter = new SqlDataAdapter("insert into TAIKHOAN values('" + txt_tentk.Text + "','" + txt_mk.Text + "','" + txt_cccd.Text + "','"+ txt_gmail.Text +"')", connection.GetConnection());
                adapter.Fill(dt);
                if (dt == null) throw new Exception("ERROL");
                MessageBox.Show("Đăng ký thành công!");
                Login(this, new EventArgs());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Có chút lỗi!!!");
            }
        }

        public bool checkMk(string fmk1, string fmk2)
        {
            if (fmk1.CompareTo(fmk2) == 0)
                return true;
            return false;
        }
    }
}
