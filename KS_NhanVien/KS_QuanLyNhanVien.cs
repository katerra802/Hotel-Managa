using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project.KS_NhanVien
{
    public partial class KS_QuanLyNhanVien : Form
    {
        private DBC.DBCInformation find = new DBC.DBCInformation();
        private static string State = "-1";
        private string idcccd = null;
        public KS_QuanLyNhanVien(string idcccd)
        {
            InitializeComponent();
            SetControl("Reset");
            getData();
            this.idcccd = idcccd;
            btn_Sua.Enabled = false;
        }

        #region Public Function

        public void SetControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    {
                        btn_Them.Enabled = true;
                        
                        btn_xoa.Enabled = true;
                        btn_tinhluong.Enabled = true;
                        btn_ghi.Enabled = false;
                        btn_huy.Enabled = false;
                        break;
                    }
            }
        }

        public void getData()
        {
            try
            {
                string query = "select * from NHANVIEN";
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

                string mnv = selectedRow.Cells["MANV"].Value.ToString();
                string snv = mnv.Substring(0, 2);
                switch (snv)
                {
                    case "QL":
                        NhanVien.QuanLy ql = new NhanVien.QuanLy();
                        ql.nhapbangDatagriew(selectedRow, mnv);

                        xuatTT(mnv, ql.TenNV, ql.Cccd, Convert.ToString(ql.NamSinh), Convert.ToString(ql.NamVaoLam)
                            , ql.LoaiCV, ql.TenChucVu, Convert.ToString(ql.HeSoChucVu), Convert.ToString(ql.thamNien),
                            Convert.ToString(ql.phuCap()), Convert.ToString(ql.LuongCoBan));
                        break;

                    case "BT":
                        NhanVien.BinhThuong bt = new NhanVien.BinhThuong();

                        xuatTT(mnv, bt.TenNV, bt.Cccd, Convert.ToString(bt.NamSinh), Convert.ToString(bt.NamVaoLam)
                            , bt.LoaiCV, "", "", Convert.ToString(bt.thamNien),
                            Convert.ToString(bt.phuCap()), Convert.ToString(bt.LuongCoBan));
                        break;

                    default:
                        throw new Exception("Lỗi");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        public void xuatTT(string manv, string tennv, string cccd, string ns, string namvl,
            string lcv, string tcv, string hscv, string tnien, string pcap, string lcb)
        {
            txt_tenNV.Text = manv;
            txt_manv.Text = tennv;
            txt_cccd.Text = cccd;
            txt_namSinh.Text = ns;
            txt_namVaoLam.Text = namvl;
            cmb_loaicv.Text = lcv;
            txt_tenChucVu.Text = tcv;
            txt_heSoCV.Text = hscv;
            txt_thamNien.Text = tnien;
            txt_phuCap.Text = pcap;
            txt_luongCoBan.Text = lcb;
        }

        #endregion

        private void KS_DinhVuNVQL_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_tinhluong_Click(object sender, EventArgs e)
        {
            try
            {
                string s = txt_tenNV.Text.Substring(0, 2);
                KS_LuongNV lgnv = null;
                NhanVien.QuanLy ql = null;
                NhanVien.BinhThuong bt = null;
                switch (s)
                {
                    case "QL":
                        ql = new NhanVien.QuanLy();

                        ql.nhapTT(txt_tenNV.Text,
                        txt_manv.Text,
                        cmbtxt_gtinh.Text,
                        txt_cccd.Text,
                        txt_namSinh.Text,
                        txt_namVaoLam.Text,
                        cmb_loaicv.Text,
                        txt_luongCoBan.Text,
                        txt_tenChucVu.Text,
                        txt_heSoCV.Text);
                        break;

                    case "BT":
                        bt = new NhanVien.BinhThuong();

                        bt.nhapTT(txt_tenNV.Text,
                        txt_manv.Text,
                        cmbtxt_gtinh.Text,
                        txt_cccd.Text,
                        txt_namSinh.Text,
                        txt_namVaoLam.Text,
                        cmb_loaicv.Text,
                        txt_luongCoBan.Text);
                        break;

                    default:
                        throw new Exception("Lỗi");

                }

                lgnv = new KS_LuongNV(ql, bt);
                lgnv.ShowDialog();
                lgnv.ok += Lgnv_ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void Lgnv_ok(object? sender, EventArgs e)
        {
            (sender as KS_LuongNV).isClose = false;
            (sender as KS_LuongNV).Close();
            this.Show();
        }
        public void cleanTxt()
        {
            txt_tenNV.Text = "";
            txt_manv.Text = "";
            cmb_loaicv.Text = "";
            cmbtxt_gtinh.Text = "";
            txt_cccd.Text = "";
            txt_namSinh.Text = "";
            txt_namVaoLam.Text = "";
            cmb_loaicv.Text = "";
            txt_tenChucVu.Text = "";
            txt_heSoCV.Text = "";
            txt_thamNien.Text = "";
            txt_phuCap.Text = "";
            txt_luongCoBan.Text = "";
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            cleanTxt();
            btn_Them.Enabled = false;
            
            btn_xoa.Enabled = false;
            btn_tinhluong.Enabled = false;
            btn_ghi.Enabled = true;
            btn_huy.Enabled = true;
            txt_phuCap.Enabled = false;
            txt_thamNien.Enabled = false;
            txt_ghiChu.Text = "Đối với nhân viên quản lý cần nhập đầy đủ tất cả thông tin, nhân viên khác không cần nhập tên chức vụ và hệ số chức vụ!";
            txt_ghiChu.ScrollBars = ScrollBars.Vertical;
            State = "Insert";
            txt_manv.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            btn_Them.Enabled = false;
            
            btn_xoa.Enabled = false;
            btn_tinhluong.Enabled = false;
            btn_ghi.Enabled = true;
            btn_huy.Enabled = true;
            State = "Update";
            SetControl("Reset");
        }


        private void btn_ghi_Click(object sender, EventArgs e)
        {
            try
            {
                CheckRegex regex = new CheckRegex();
                if (string.IsNullOrEmpty(txt_tenNV.Text)
                    || string.IsNullOrEmpty(txt_manv.Text)
                    || string.IsNullOrEmpty(txt_cccd.Text)
                    || string.IsNullOrEmpty(txt_namSinh.Text)
                    || string.IsNullOrEmpty(txt_namVaoLam.Text)
                    || string.IsNullOrEmpty(cmb_loaicv.Text)
                    || string.IsNullOrEmpty(txt_luongCoBan.Text))
                    throw new Exception("Hãy nhập đầy đủ thông tin!");
                if (!regex.checkMaNV(txt_manv.Text)) throw new Exception("Hãy nhập đúng mã nhân viên (quản lý: QL<chuỗi 3 số>; khác: BT<chuỗi 3 số>");
                if (!regex.checkCCCD(txt_cccd.Text)) throw new Exception("Hãy nhập đúng CCCD");
                if (find.checkDBC("NHANVIEN", "where MANV = '" + txt_manv.Text + "'")) throw new Exception("Mã nhân viên đã tồn tại!");
                int ni = DateTime.Now.Year - int.Parse(txt_namSinh.Text);
                if (int.Parse(txt_namVaoLam.Text) > DateTime.Now.Year) throw new Exception("Năm vào làm không được lơn hơn năm hiện tại!");
                if (ni > 65) throw new Exception("Nhân viên quá tuổi đi làm!!! (chỉ nhận từ đủ 18 -> 65 tuổi)");
                if (ni < 18) throw new Exception("Nhân viên chưa đủ tuổi làm việc!!! (chỉ nhận từ đủ 18 -> 65 tuổi");
                if (int.Parse(txt_namSinh.Text) > int.Parse(txt_namVaoLam.Text)) throw new Exception("Năm sinh không được nhỏ hơn năm vào làm");
                if (!checkGT(cmbtxt_gtinh.Text)) throw new Exception("Sai giới tính!!!!");
                if (double.Parse(txt_heSoCV.Text) < 0 || double.Parse(txt_heSoCV.Text) > 2) throw new Exception("Ăn chặn tiền khách sạn à???");
                if (!checkLuong(cmb_loaicv.Text)) throw new Exception("Quản lý: 10.000.000 ->  30.000.000\tLương nhân viên: 3.000.000 -> 15.000.000");
                string sk = txt_manv.Text.Substring(0, 2);
                switch (sk)
                {
                    case "QL":
                        {
                            if (string.IsNullOrEmpty(txt_tenChucVu.Text) || string.IsNullOrEmpty(txt_heSoCV.Text))
                                throw new Exception("Hãy nhập đầy đủ thông tin!");
                            break;
                        }
                    case "BT":
                        {
                            if (!string.IsNullOrEmpty(txt_tenChucVu.Text) || !string.IsNullOrEmpty(txt_heSoCV.Text))
                                throw new Exception("Nhân viên không thuộc loại quản lý không cần nhập tên chức vụ và hệ số chức vụ!");
                            break;
                        }
                    default:
                        throw new Exception("Hãy kiểm tra kĩ thông tin đã nhập!");

                }
                if (State == "Insert")
                {
                    find.Db.Open();
                    SqlDataAdapter adapter = null;
                    DataTable dt = new DataTable();
                    adapter = new SqlDataAdapter("insert into NHANVIEN values('" + txt_manv.Text + "', N'" + txt_tenNV.Text + "', '" + cmbtxt_gtinh.Text + "', " +
                        "'" + txt_cccd.Text + "','" + int.Parse(txt_namSinh.Text) + "', '" + int.Parse(txt_namVaoLam.Text) + "'," +
                        "'" + float.Parse(txt_luongCoBan.Text) + "', N'" + cmb_loaicv.Text + "', N'" + txt_tenChucVu.Text + "', '" + float.Parse(txt_heSoCV.Text) + "')", find.Db.GetConnection());
                    adapter.Fill(dt);
                    if (dt == null) throw new Exception("ERROL");
                    MessageBox.Show("Thêm nhân viên thành công!");
                    getData();
                    find.Db.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROL");
            }
        }

        public bool checkGT(string s)
        {
            switch (s)
            {
                case "Nam":
                case "Nữ":
                case "Không xác định":
                    return true;
                default: return false;
            }
        }

        public bool checkLuong(string s)
        {
            switch (s)
            {
                case "Quản lý":
                    if (double.Parse(txt_luongCoBan.Text) < 10000000 || double.Parse(txt_luongCoBan.Text) > 30000000) return false;
                    break;

                case "Nhân viên":
                    if (double.Parse(txt_luongCoBan.Text) < 3000000 || double.Parse(txt_luongCoBan.Text) > 15000000) return false;
                    break;

                default:
                    return true;

            }
            return true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            cleanTxt();
            btn_Them.Enabled = true;
            
            btn_xoa.Enabled = true;
            btn_tinhluong.Enabled = true;
            btn_ghi.Enabled = false;
            btn_huy.Enabled = false;
        }
    }
}
