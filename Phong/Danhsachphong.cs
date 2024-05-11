using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OOP_project.Phong;

namespace ConsoleApplication1
{
    public class Danhsachphong
    {
        List<Phong> dsp = new List<Phong>();

        public List<Phong> Dsp { get => dsp; set => dsp = value; }

        public int tongSoluong()
        {
            return dsp.Count;
        }

        public Phong ttPhong(int i)
        {
            Phong phong = dsp[i].ttpn();
            return phong;
        }

        public void addphong(Phong phong)
        {
            this.dsp.Add(phong);
        }

        public int tongNgayThue()
        {
            int c = 0;
            foreach (Phong phong in Dsp)
            {
                c += int.Parse(tinhThoiGianThue(phong.NgayThue, phong.NgayTra));
            }
            return c; 
        }

        public string tinhThoiGianThue(DateTime t1, DateTime t2)
        {
            TimeSpan t = t2 - t1;
            return Convert.ToString(t.Days.ToString());
        }

        public string xuatTatCaCacMaPhong()
        {
            string s = "";
            foreach (Phong phong in Dsp)
            {
                s = s + phong.maPhong + " - ";
            }
            return s;
        }

        public string xuatTatCaCacLoaiP()
        {
            string s = "";
            foreach (Phong phong in Dsp)
            {
                s = s + phong.loai + " - ";
            }
            return s;
        }
    }
}

