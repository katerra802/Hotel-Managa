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
using OOP_project.DBC;

namespace OOP_project
{
    public partial class KS_XacNhanDatPhong : Form
    {
        SqlDataAdapter adapter;
        private DBConnection db;
        DataTable dt;
        public bool isCloseXn = true;
        Phong.Phong pn = null;
        DBC.DBCInformation find = new  DBC.DBCInformation();
        public KS_XacNhanDatPhong()
        {
            InitializeComponent();
            db = new DBConnection();
            dt = new DataTable();
        }

        public event EventHandler Xndp;

        private void button2_Click(object sender, EventArgs e)
        {
            Xndp(this, new EventArgs());
        }

        private void Xac_Nhan_Dat_Phong_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isCloseXn)
            {
                Application.Exit();
            }
        }

        public void xndp(Phong.Phong px, string pos, string nte)
        {
            pn = px;
            name.Text = px.ten;
            cccd.Text = Convert.ToString(px.maKhach);
            type_l.Text = px.loai;
            time_lend.Text = Convert.ToString(px.NgayThue);
            time_return.Text = Convert.ToString(px.NgayTra);
            position.Text = pos;
            id_room.Text = px.maPhong;
            price.Text = Convert.ToString(px.gia);
            note.Text = nte;
        }

        private void btn_XacNhanDatPhong_Click(object sender, EventArgs e)
        {
            try
            {
                adapter = new SqlDataAdapter("insert into PHONG values ('" + pn.loai + "', '" + pn.maPhong + "', " +
                "'" + pn.maKhach + "', '" + pn.ten + "', '" + float.Parse(Convert.ToString(pn.gia)) + "','" + pn.NgayThue + "', '" + pn.NgayTra + "', '" + note.Text + "')", db.GetConnection());
                adapter.Fill(dt);
                if (dt == null) throw new Exception("ERROL");
                MessageBox.Show("Đặt phòng thành công!", "Thông báo");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROL");
            }
        }
    }
}
