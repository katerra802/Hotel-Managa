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

namespace OOP_project.KS_NhanVien
{
    public partial class KS_QuanLyPhong : Form
    {
        DBC.DBCInformation find = new DBC.DBCInformation();
        public KS_QuanLyPhong()
        {
            InitializeComponent();
            getData();
            
        }

        public void getData()
        {
            try
            {
                string query = "select * from PHONG";
                SqlCommand cmd = find.openDBC(query);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dataG_main.DataSource = ds.Tables[0];
                }
                else
                {
                    dataG_main.DataSource = null;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "ERROL");
            }
        }

        private void dataG_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataG_main.Rows[index];
                Phong.Phong pn = new Phong.Phong();
                pn.nhapbangDatagriew(selectedRow);
                int i = find.LaysoLuong("PHONG", "");
                string note = selectedRow.Cells["NOTE"].Value.ToString();
                xuatTT(pn, note, Convert.ToString(i), Convert.ToString(20 - i));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        public void xuatTT(Phong.Phong pn, string note, string sldathue, string slconlai)
        {
            lab_loai.Text = pn.loai;
            lab_mp.Text = pn.maPhong;
            lab_cccd.Text = pn.maKhach;
            lab_tenkh.Text = pn.ten;
            lab_gia.Text = Convert.ToString(pn.gia);
            lab_ngaythue.Text = Convert.ToString(pn.NgayThue);
            lab_ngaytra.Text = Convert.ToString(pn.NgayTra);
            lab_note.Text = note;
            lab_soPhongdathue.Text = sldathue;
            lab_slPhongconlai.Text = slconlai;
        }
    }
}
