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
    public partial class KS_QuanLyDanhThu : Form
    {
        DBC.DBCInformation find = new DBC.DBCInformation();
        public KS_QuanLyDanhThu()
        {
            InitializeComponent();
            getData("all", "");
            SetControl("Reset");
        }

        #region
        public void SetControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    {
                        btn_thietLap.Enabled = true;
                        btn_tongDanhThu.Enabled = false;
                        break;
                    }
            }
        }

        public void getData(string loaiTT, string time)
        {
            try
            {
                string query = null;
                switch (loaiTT)
                {
                    case "all":
                        query = "select * from HOADON";
                        break;

                    case "ngay":
                        query = "select * from HOADON where day(NGAYLAPHOADON) = " + time;
                        break;

                    case "thang":
                        query = "select * from HOADON where month(NGAYLAPHOADON) = " + time;
                        break;

                    case "nam":
                        query = "select * from HOADON where year(NGAYLAPHOADON) = " + time;
                        break;

                }
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

        private void dataG_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataG_main.Rows[index];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        #endregion

        private void btn_thietLap_Click(object sender, EventArgs e)
        {
            try
            {
                string x = null;
                CheckRegex rg = new CheckRegex();
                switch (cbbox_loaiTG.Text)
                {
                    case "Ngày":
                        if (!rg.checkTG2so(txt_tg.Text)) throw new Exception("NGÀY TỐI ĐA CÓ 2 CHỮ SỐ!");
                        if (int.Parse(txt_tg.Text) < 1 || int.Parse(txt_tg.Text) > 31) throw new Exception("NGÀY CHỈ CÓ 1 ĐẾN 31 NGÀY!");
                        getData("ngay", txt_tg.Text);
                        x = "where day(NGAYLAPHOADON) = " + txt_tg.Text;
                        break;

                    case "Tháng":
                        if (!rg.checkTG2so(txt_tg.Text)) throw new Exception("THÁNG TỐI ĐA CÓ 2 CHỮ SỐ!");
                        if (int.Parse(txt_tg.Text) < 1 || int.Parse(txt_tg.Text) > 12) throw new Exception("MỘT NĂM CHỈ CÓ 1 ĐẾN 12 THÁNG!");
                        getData("thang", txt_tg.Text);
                        x = "where month(NGAYLAPHOADON) = " + txt_tg.Text;
                        break;

                    case "Năm":
                        if (!rg.checkTG4so(txt_tg.Text)) throw new Exception("NĂM TỐI ĐA CÓ 4 CHỮ SỐ!");
                        if (int.Parse(txt_tg.Text) < 2000 || int.Parse(txt_tg.Text) > DateTime.Now.Year) throw new Exception("NĂM KHÔNG ĐƯỢC NHỎ HƠN 2000 VÀ LỚN HƠN NĂM HIỆN TẠI!");
                        getData("nam", txt_tg.Text);
                        x = "where year(NGAYLAPHOADON) = " + txt_tg.Text;
                        break;
                    default:
                        throw new Exception("HÃY CHỌN TRONG DANG SÁCH!");
                }
                btn_tongDanhThu.Enabled = true;
                btn_thietLap.Enabled = false;
                lab_soLuongHD.Text = Convert.ToString(find.LaysoLuong("HOADON", x));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROL");
            }
        }

        private void btn_tongDanhThu_Click(object sender, EventArgs e)
        {
            
            try
            {
                string x = null;
                CheckRegex rg = new CheckRegex();
                switch (cbbox_loaiTG.Text)
                {
                    case "Ngày":
                        if (!rg.checkTG2so(txt_tg.Text)) throw new Exception("NGÀY TỐI ĐA CÓ 2 CHỮ SỐ!");
                        if (int.Parse(txt_tg.Text) < 1 || int.Parse(txt_tg.Text) > 31) throw new Exception("NGÀY CHỈ CÓ 1 ĐẾN 31 NGÀY!");
                        x = "where day(NGAYLAPHOADON) = " + txt_tg.Text;
                        break;

                    case "Tháng":
                        if (!rg.checkTG2so(txt_tg.Text)) throw new Exception("THÁNG TỐI ĐA CÓ 2 CHỮ SỐ!");
                        if (int.Parse(txt_tg.Text) < 1 || int.Parse(txt_tg.Text) > 12) throw new Exception("MỘT NĂM CHỈ CÓ 1 ĐẾN 12 THÁNG!");
                        x = "where month(NGAYLAPHOADON) = " + txt_tg.Text;
                        break;

                    case "Năm":
                        if (!rg.checkTG4so(txt_tg.Text)) throw new Exception("NĂM TỐI ĐA CÓ 4 CHỮ SỐ!");
                        if (int.Parse(txt_tg.Text) < 2000 || int.Parse(txt_tg.Text) > DateTime.Now.Year) throw new Exception("NĂM KHÔNG ĐƯỢC NHỎ HƠN 2000 VÀ LỚN HƠN NĂM HIỆN TẠI!");
                        x = "where year(NGAYLAPHOADON) = " + txt_tg.Text;
                        break;
                    default:
                        throw new Exception("HÃY CHỌN TRONG DANG SÁCH!");
                }
                btn_tongDanhThu.Enabled = false;
                btn_thietLap.Enabled = true;
                lab_tongDT.Text = Convert.ToString(find.tinhTongDsHD(x));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROL");
            }
            
        }
    }
}
