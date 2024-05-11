using ConsoleApplication1;
using OOP_project.HoaDon;
using OOP_project.Phong;
using OOP_project.TaiKhoang;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OOP_project.DBC
{
    public class DBCInformation
    {
        private DBConnection db;

        public DBCInformation()
        {
            db = new DBConnection();
        }

        //khu vuc khoi tao
        public DBConnection Db { get => db; set => db = value; }

        public SqlCommand openDBC(string query)
        {
            Db.Open();
            SqlCommand cmd = new SqlCommand(query, Db.GetConnection());
            return cmd;
        }
        //khu vuc khoi tao


        // khu vuc cong viec
        //cong viec kiem tra dang nhap
        public SqlDataReader workWithDBC(string query, string username, string password, string command_username, string command_password)
        {
            SqlCommand cmd = openDBC(query);
            cmd.Parameters.AddWithValue(command_username, username);
            cmd.Parameters.AddWithValue(command_password, password);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        //cong viec lay phong
        public SqlDataReader workWithDBC(string query, string id_cccd, string command_cccd, int any_number)
        {
            SqlCommand cmd = openDBC(query);
            cmd.Parameters.AddWithValue(command_cccd, id_cccd);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        //cong viec lay cccd
        public object workWithDBC(string query, string username, string command_username)
        {
            SqlCommand cmd = openDBC(query);
            cmd.Parameters.AddWithValue(command_username, username);
            object result = cmd.ExecuteScalar();
            return result;
        }

        //cong viec kiem tra tinh trang phong
        public object workWithDBC(string query, string id_cccd, string command_cccd, string any_char)
        {
            SqlCommand cmd = openDBC(query);
            cmd.Parameters.AddWithValue(command_cccd, id_cccd);
            object result = null;
            result = cmd.ExecuteScalar();
            return result;
        }
        
        public double tinhTongDsHD(string dkthem)
        {
            string query = "select sum(TONGTIENTHUE) from HOADON " + dkthem;
            SqlCommand cmd = openDBC(query);
            object result = cmd.ExecuteScalar();
            return (double)result;
        }
        // khu vuc cong viec


        //khu vuc lay thong tin
        public string lay1TT(string query, string username, string command_username)
        {
            object result = null;
            if(checkDBC("TAIKHOAN", ""))
            {
                result = workWithDBC(query, username, command_username);
            }
            Db.Close();
            if (result != null)
            {
                return result.ToString();
            }
            return null;
        }

        public bool checkStateRoom(string query, string id_cccd, string command_cccd)
        {
            object result = null;
            if (checkDBC("PHONG",""))
            {
                result = workWithDBC(query, id_cccd, command_cccd, "A");
            }
            Db.Close();
            if (result != null)
            {
                return true;
            }
            return false;
        }
        public Taikhoan TaikhoanLogin(string query, string username, string password, string command_username, string command_password)
        {
            SqlDataReader rd = null;
            Taikhoan tkc = null;
            if (checkDBC("TAIKHOAN", ""))
            {
                rd = workWithDBC(query, username, password, command_username, command_password);
                if (rd.Read())
                {
                    tkc = new Taikhoan();
                    tkc.TenND = rd["TENTAIKHOAN"].ToString();
                    tkc.mk = rd["MATKHAU"].ToString();
                }
            }

            Db.Close();
            return tkc;
        }

        public Phong.Phong layPhong(string query, string id_cccd)
        {
            Phong.Phong pn = null;
            SqlDataReader rd = null;
            if(checkDBC("PHONG",""))
            {
                rd = workWithDBC(query, id_cccd, "@cccd", 1);
                if (rd.Read())
                {
                    pn = new Phong.Phong();
                    pn.nhap(rd);  
                }
            }
            db.Close();
            return pn;
        }

        //cong viec lay nhan vien binh thuong
        public NhanVien.BinhThuong layTTNVBT(string query, string idNV)
        {
            NhanVien.BinhThuong bt = null;
            SqlDataReader rd = null;
            if(checkDBC("NHANVIEN",""))
            {
                rd = workWithDBC(query, idNV, "@cccd",1);
                if (rd.Read())
                {
                    bt = new NhanVien.BinhThuong();
                    bt.nhap(rd);
                }
            }    
            Db.Close();
            return bt;
        }

        public Danhsachphong DSPhong(string query)
        {
            Danhsachphong dsp = null;
            if(checkDBC("PHONG", ""))
            {
                dsp = new Danhsachphong();
                SqlCommand cmd = openDBC(query);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Phong.Phong pn = null;
                foreach (DataRow dr in dt.Rows)
                {
                    pn = new Phong.Phong();
                    pn.nhap(dr);
                    dsp.Dsp.Add(pn);
                }
            }
            Db.Close();
            return dsp;
        }

        public dsHoaDon LayDSHoaDon(string query)
        {
            dsHoaDon dshd = null;
            try
            {
                if (checkDBC("HOADON", ""))
                {
                    dshd = new dsHoaDon();
                    SqlCommand cmd = openDBC(query);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    HoaDon.HoaDon hoaDon = null;
                    foreach (DataRow dr in dt.Rows)
                    {
                        string mp = dr["MAPHONG"].ToString();
                        switch (mp.Substring(6, 1))
                        {
                            case "1":
                            case "4":
                                hoaDon = new HoaDonPhongDon();
                                hoaDon.nhap(dr, mp);
                                break;

                            case "3":
                            case "2":
                                hoaDon = new HoaDonPhongDoi();
                                hoaDon.nhap(dr, mp);
                                break;

                            default:
                                throw new Exception("ERROL");
                                break;
                        }
                        dshd.Dshd.Add(hoaDon);
                    }
                }
                Db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROL");
            }
            return dshd;
        }

        public int LaysoLuong(string table, string dkthem)
        {
            string query = "select count(*) from " + table + " " + dkthem;
            SqlCommand cmd = openDBC(query);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        //khu vuc lay thong tin


        //khu vuc kiem tra thong tin
        public bool checkDBC(string table, string dk)
        {
            try
            {
                string query = "select count(*) from " + table + " " + dk;
                SqlCommand cmd = openDBC(query);
                int rowCountP = 0;
                rowCountP = Convert.ToInt32(cmd.ExecuteScalar());
                
                return rowCountP > 0;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"Lỗi");
            }
            return false;
        }

        //khu vuc kiem tra thong tin


        //khu vuc them thong tin
        public void themTTTaiKhoan(string tk, string mk, string cccd, string gmail)
        {
            Db.Open();  
            SqlDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                adapter = new SqlDataAdapter("insert into TAIKHOAN values('" + tk + "','" + mk + "','" + cccd + "','" + gmail + "')", Db.GetConnection());
                adapter.Fill(dt);
                if (dt == null) throw new Exception("ERROL");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROL!!!");
            }
            Db.Close();
        }
        //khu vuc them thong tin


        //khu vuc xoa tt
        public void xoaTTPhong(string id_cccd)
        {
            string query = "delete from PHONG where CCCD = @cccd";
            SqlCommand cmd = openDBC(query);
            cmd.Parameters.AddWithValue("@cccd", id_cccd);
            int c = cmd.ExecuteNonQuery();
            if (c > 0)
            {
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi để xóa hoặc xóa không thành công!");
            }
            Db.Close();
        }
        //khu vuc xoa tt
    }
}
