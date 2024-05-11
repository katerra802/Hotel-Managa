using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project.Phong
{
    public class Phong
    {
        protected string Loai;
        public string loai
        {
            get { return Loai; }
            set { Loai = value; }
        }
        protected string MaPhong;
        public string maPhong
        {
            get { return MaPhong; }
            set { MaPhong = value; }
        }
        protected string MaKhach;
        public string maKhach
        {
            get { return MaKhach; }
            set { MaKhach = value; }
        }
        protected string Ten;
        public string ten
        {
            get { return Ten; }
            set { Ten = value; }
        }
        protected double Gia;
        public double gia
        {
            get { return Gia; }
            set { Gia = value; }
        }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }

        protected DateTime ngayThue;

        protected DateTime ngayTra;

        public int soNgayThue()
        {
            TimeSpan ts = NgayTra - NgayThue;
            return Convert.ToInt16(ts.Days) + 1;
        }

        public Phong() { }
        public Phong(string l, string Map, string Mak, string t, double g, DateTime nTh, DateTime nTr)
        {
            loai = l;
            maPhong = Map;
            maKhach = Mak;
            ten = t;
            gia = g;
            ngayThue = nTh;
            ngayTra = nTr; 
        }

        public void nhap(System.Data.SqlClient.SqlDataReader rd)
        {
            loai = rd["LOAI"].ToString();
            maPhong = rd["MAPHONG"].ToString();
            maKhach = rd["CCCD"].ToString();
            ten = rd["TENKHACHHANG"].ToString();
            gia = double.Parse(rd["GIATHUE"].ToString());
            NgayThue = Convert.ToDateTime(rd["NGAYBATDAUTHUE"].ToString());
            NgayTra = Convert.ToDateTime(rd["NGAYTRAPHONG"].ToString());
        }

        public void nhap(System.Data.DataRow rd)
        {
            loai = rd["LOAI"].ToString();
            maPhong = rd["MAPHONG"].ToString();
            maKhach = rd["CCCD"].ToString();
            ten = rd["TENKHACHHANG"].ToString();
            gia = double.Parse(rd["GIATHUE"].ToString());
            NgayThue = Convert.ToDateTime(rd["NGAYBATDAUTHUE"].ToString());
            NgayTra = Convert.ToDateTime(rd["NGAYTRAPHONG"].ToString());
        }

        public void nhapbangDatagriew(DataGridViewRow selectedRow)
        {
            loai = selectedRow.Cells["LOAI"].Value.ToString();
            MaPhong = selectedRow.Cells["MAPHONG"].Value.ToString();
            maKhach = selectedRow.Cells["CCCD"].Value.ToString();
            ten = selectedRow.Cells["TENKHACHHANG"].Value.ToString();
            gia = double.Parse(selectedRow.Cells["GIATHUE"].Value.ToString());
            NgayThue = Convert.ToDateTime(selectedRow.Cells["NGAYBATDAUTHUE"].Value.ToString());
            NgayTra = Convert.ToDateTime(selectedRow.Cells["NGAYTRAPHONG"].Value.ToString());
        }

        public Phong ttpn()
        {
            return this;
        }
    }
}
