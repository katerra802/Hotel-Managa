using ConsoleApplication1;
using OOP_project.HoaDon;
using OOP_project.KS_KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class KS_DichVuKH : Form
    {
        public bool isClose = true;
        private KS_DangNhapKH f1;
        private string id_cccd;
        private bool stateRoom;
        private Form f = null;
        DBC.DBCInformation find;
        Danhsachphong ds = null;
        dsHoaDon dshd = null;
        public KS_DichVuKH(KS_DangNhapKH f1, string id_cccd, bool stateRoom)
        {
            InitializeComponent();
            this.f1 = f1;
            this.id_cccd = id_cccd;
            this.stateRoom = stateRoom;
            find = new DBC.DBCInformation();
            ds = dsPhong(id_cccd, "CCCD");
            dshd = layDSHoaDon(id_cccd, "CCCD");
            if (!stateRoom)
            {
                currentChildForm = new KS_EmptyForm("Bạn chưa đặt phòng!");
                OpenChildForm(currentChildForm);
            }
            else
            {
                f = new KS_ThongTinPhong(ds);
                OpenChildForm(f);
            }
        }

        public event EventHandler Logout;

        private void button1_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void Device_customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isClose)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private Form currentChildForm;
        public void OpenChildForm(Form childForm)
        {

            if (currentChildForm != null && currentChildForm.GetType() == childForm.GetType()) 
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelContent.Controls.Add(childForm);
                panelContent.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                return;
            }

            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            return;
        }

        public void changeBGColorEnter(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            clickedButton.BackColor = Color.White;

            foreach (Control control in Controls)
            {
                if (control is Button && control != clickedButton)
                {
                    control.BackColor = Color.Transparent;
                    control.ForeColor = Color.White;
                }
            }
        }

        public void changeEnable(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            clickedButton.Enabled = false;

            foreach (Control control in Controls)
            {
                if (control is Button && control != clickedButton)
                {
                    control.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds = dsPhong(id_cccd, "CCCD");
            f = new KS_DatPhong(id_cccd, ds);
            changeEnable(sender, e);
            changeBGColorEnter(sender, e);
            OpenChildForm(f); 
        }

        public Phong.Phong layTTPhong()
        {
            string query = "select * from PHONG where CCCD = @cccd";
            return find.layPhong(query, id_cccd);
        }

        public Danhsachphong dsPhong(string id_cccd, string tenDKtim)
        {
            string query = "select * from PHONG where " + tenDKtim + " = '" + id_cccd + "'";
            return find.DSPhong(query);
        }

        public dsHoaDon layDSHoaDon(string id_cccd, string tenDKtim)
        {
            string query = "select * from HOADON where " + tenDKtim + " = '" + id_cccd + "'";
            return find.LayDSHoaDon(query);
        }
        private void thongTinPhong_Click(object sender, EventArgs e)
        {
            ds = dsPhong(id_cccd, "CCCD");
            if(ds == null)
            {
                currentChildForm = new KS_EmptyForm("Bạn chưa đặt phòng!");
                OpenChildForm(currentChildForm);
            }
            else
            {
                ds = dsPhong(id_cccd, "CCCD");
                f = new KS_ThongTinPhong(ds);
                OpenChildForm(f);
            }
            changeEnable(sender, e);
            changeBGColorEnter(sender, e);
        }

        private void traPhong_Click(object sender, EventArgs e)
        {
            ds = dsPhong(id_cccd, "CCCD");
            if (ds == null)
            {
                currentChildForm = new KS_EmptyForm("Bạn chưa đặt phòng!");
                OpenChildForm(currentChildForm);
            }
            else
            {

                f = new KS_TraPhong(this);
                OpenChildForm(f);
            }
            changeBGColorEnter(sender, e);
            changeEnable(sender, e);
        }

        public void xacNhanTraPhong()
        {
            ds = dsPhong(id_cccd, "CCCD");
            dshd = nhapHoaDonvaoDB();
            currentChildForm = new KS_HoaDon(this, ds, dshd);
            OpenChildForm(currentChildForm);
            xoaTTPhong();
        }

        public dsHoaDon nhapHoaDonvaoDB()
        {
            string x = "0";
            dsHoaDon danhsachhd = null;
            if (ds.Dsp == null) return danhsachhd;
            try
            {
                danhsachhd = new dsHoaDon();
                foreach (Phong.Phong png in ds.Dsp)
                {
                    HoaDon.HoaDon hoaDon = null;
                    int i = find.LaysoLuong("HOADON","");
                    string mahoadon = png.maPhong.Substring(3, 4) + "-" + i + png.maKhach.Substring(8, 4);
                    if (!find.checkDBC("HOADON", "where MAHOADON = '" + mahoadon + "'"))
                    {
                        switch (png.maPhong.Substring(6, 1))
                        {
                            case "1":
                            case "4":
                                hoaDon = new HoaDonPhongDon();
                                hoaDon.nhap(mahoadon, png.maKhach, png.maPhong, png.gia, png.soNgayThue(), DateTime.Now);
                                x = "0";
                                break;

                            case "3":
                            case "2":
                                hoaDon = new HoaDonPhongDoi();
                                hoaDon.nhap(mahoadon, png.maKhach, png.maPhong, png.gia, png.soNgayThue(), DateTime.Now);
                                hoaDon.capNhapTongTienHD(hoaDon.TongTien());
                                x = "0.02";
                                break;

                            default:
                                throw new Exception("ERROL");
                                
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter("insert into HOADON values ('" + hoaDon.MaHD + "', '" + hoaDon.MaKH + "', '" + hoaDon.MaPhong + "'," +
                        " '" + float.Parse(Convert.ToString(hoaDon.GiaPhong)) + "', '" + hoaDon.SoNgayThue + "','"+ hoaDon.NgayLapHoaDon + "', '"+float.Parse(Convert.ToString(hoaDon.TongTien()))+"', '"+ float.Parse(Convert.ToString(hoaDon.Thue()))+"', '"+float.Parse(x)+"')", find.Db.GetConnection());
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt == null) throw new Exception("ERROL");
                    }
                    if(hoaDon != null)
                    {
                        danhsachhd.Dshd.Add(hoaDon);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROL");
            }
            find.Db.Close();
            return danhsachhd;
        }

        public void xoaTTPhong()
        {
            find.xoaTTPhong(id_cccd);
        }

    }
}
