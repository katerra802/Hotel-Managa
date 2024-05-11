using System;
using System.Drawing;
using System.Security.AccessControl;

namespace OOP_project.HoaDon
{
	public abstract class HoaDon
	{
        private static double thue = 0.05;

        protected string maHD;

        protected string maKH;

        protected string maPhong;

        protected double giaPhong;

        protected int soNgayThue;

        DateTime ngayLapHoaDon;

        protected double tongTienHD;

        public string MaKH { get => maKH; set => maKH = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public double GiaPhong { get => giaPhong; set => giaPhong = value; }
        public int SoNgayThue { get => soNgayThue; set => soNgayThue = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayLapHoaDon { get => ngayLapHoaDon; set => ngayLapHoaDon = value; }
        public double TongTienHD { get => tongTienHD; set => tongTienHD = value; }

        public HoaDon() { }

        public double Thue()
        {
            return thue;
        }

        public double tienPhong()
        {
            return giaPhong * soNgayThue;
        }

        public double tinhTienThue()
        {
            return tienPhong() * thue;
        }

        public abstract double TongTien();

        public void capNhapTongTienHD(double x)
        {
            TongTienHD = x;
        }
        public void nhap(System.Data.DataRow rd, string mp)
        {
            MaHD = rd["MAHOADON"].ToString();
            MaKH = rd["CCCD"].ToString();
            MaPhong = mp;
            GiaPhong = double.Parse(rd["GIATHUE"].ToString());
            SoNgayThue = int.Parse(rd["SONGAYTHUE"].ToString());
            NgayLapHoaDon = Convert.ToDateTime(rd["NGAYLAPHOADON"].ToString());
            TongTienHD = double.Parse(rd["TONGTIENTHUE"].ToString());
        }

        public void nhap(string mhd, string cccd, string mp, double giap, int snt, DateTime nlhd)
        {
            MaHD = mhd;
            MaKH = cccd;
            maPhong = mp;
            GiaPhong = giap;
            SoNgayThue = snt;
            ngayLapHoaDon = nlhd;
        }
    }
}

