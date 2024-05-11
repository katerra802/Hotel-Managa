using OOP_project.Phong;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project.NhanVien
{
    public abstract class NhanVien
    {
        string maNV;
        string tenNV;
        string gioiTinh;
        string cccd;
        int namSinh;
        int namVaoLam;
        double luongCoBan;
        string loaiCV;

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public int NamVaoLam { get => namVaoLam; set => namVaoLam = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public string LoaiCV { get => loaiCV; set => loaiCV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public NhanVien() { }

        public virtual void nhapbangDatagriew(DataGridViewRow selectedRow, string mnv)
        {
            MaNV = mnv;
            TenNV = selectedRow.Cells["TENNHANVIEN"].Value.ToString();
            GioiTinh = selectedRow.Cells["GIOITINH"].Value.ToString();
            Cccd = selectedRow.Cells["CCCD"].Value.ToString();
            NamSinh = int.Parse(selectedRow.Cells["NAMSINH"].Value.ToString());
            NamVaoLam = int.Parse(selectedRow.Cells["NAMVAOLAM"].Value.ToString());
            LoaiCV = selectedRow.Cells["LOAICONGVIEC"].Value.ToString();
            LuongCoBan = double.Parse(selectedRow.Cells["LUONGCOBAN"].Value.ToString());
        }

        public void nhap(System.Data.SqlClient.SqlDataReader rd)
        {
            MaNV = rd["MANV"].ToString();
            TenNV = rd["TENNHANVIEN"].ToString();
            GioiTinh = rd["GIOITINH"].ToString();
            Cccd = rd["CCCD"].ToString();
            NamSinh = int.Parse(rd["NAMSINH"].ToString());
            NamVaoLam = int.Parse(rd["NAMVAOLAM"].ToString());
            LoaiCV = rd["LOAICONGVIEC"].ToString();
            LuongCoBan = double.Parse(rd["LUONGCOBAN"].ToString());
        }

        public virtual void nhapTT(string manv, string tennv, string gt,string cccd, string ns, string namvl,
            string lcv, string lcb)
        {
            MaNV = manv;
            TenNV = tennv;
            GioiTinh = gt;
            Cccd = cccd;
            NamSinh = int.Parse(ns);
            NamVaoLam = int.Parse(namvl);
            LoaiCV = lcv;
            LuongCoBan = double.Parse(lcb);
        }

        public int thamNien
        {
            get
            {
                return DateTime.Now.Year - namVaoLam;
            }
        }

       

        public double phuCapThamNien()
        {
            if (thamNien > 2)
                return thamNien * 100000;
            return 0;
        }

        public abstract double phuCap();

        public abstract double thuNhap();

    }
}