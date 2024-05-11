using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class KS_DatPhong : Form
    {
        public bool isCLoseBI = true;
        private string id_cccd;
        Danhsachphong dsp;
        public KS_DatPhong(string id_cccd, Danhsachphong dsp)
        {
            InitializeComponent();
            this.id_cccd = id_cccd;
            cccd.Text = id_cccd.ToString();
            this.dsp = dsp;
        }

        public event EventHandler Exitbi;

        private void quay_lai_Click(object sender, EventArgs e)
        {
            Exitbi(this, new EventArgs());
        }


        public bool checkTimeLend(DateTime dt1, DateTime dt2)
        {
            return DateTime.Compare(dt1, dt2) > 0;
        }

        private Phong.Phong pg = null;
        private void dat_phong_Click(object sender, EventArgs e)
        {
            CheckRegex cr = new CheckRegex();
            try
            {
                if (string.IsNullOrEmpty(ten.Text)
                    || string.IsNullOrEmpty(cccd.Text)
                    || string.IsNullOrEmpty(dt_ngayThue.Text)
                    || string.IsNullOrEmpty(dt_ngayTra.Text))
                    throw new Exception("Hãy nhập đầy đủ thông tin!");
                if (string.IsNullOrEmpty(type.Text)
                    || string.IsNullOrEmpty(id_room.Text)
                    || string.IsNullOrEmpty(price.Text))
                    throw new Exception("Hãy nhấn vào chọn phòng");
                if (checkTimeLend(DateTime.Now, DateTime.Parse(dt_ngayThue.Text))) throw new Exception("Ngày thuê không được phép nhỏ hơn ngày hiện tại!");
                if (checkTimeLend(DateTime.Parse(dt_ngayThue.Text), DateTime.Parse(dt_ngayTra.Text))) throw new Exception("Hãy chọn đúng ngày thuê và trả! (ngày thuê trước ngày trả)");
                if (!cr.checkCCCD(cccd.Text)) throw new Exception("Hãy nhập đúng cccd!");
                
                pg = new Phong.Phong(type.Text, id_room.Text, cccd.Text, ten.Text, Convert.ToDouble(price.Text), Convert.ToDateTime(dt_ngayThue.Text), Convert.ToDateTime(dt_ngayTra.Text));

                this.Hide();
                KS_XacNhanDatPhong xn = new KS_XacNhanDatPhong();
                xn.Show();
                xn.xndp(pg, choose_room.Text, note.Text);
                xn.Xndp += Xn_Xndp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void Xn_Xndp(object? sender, EventArgs e)
        {
            (sender as KS_XacNhanDatPhong).isCloseXn = false;
            (sender as KS_XacNhanDatPhong).Close();
            this.Show();
        }

        private void choose_room_Click(object sender, EventArgs e)
        {
            KS_ChonPhong rd = new KS_ChonPhong(this);
            rd.ShowDialog();
        }

        public void UpdateInfRoom(string id_r, string tpe, string prce, string nmbr)
        {
            Id_room.Text = id_r;
            Type.Text = tpe;
            Price.Text = prce;
            Choose_room.Text = nmbr;
        }

        
    }
}
