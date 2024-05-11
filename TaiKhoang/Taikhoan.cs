using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project.TaiKhoang
{
	public class Taikhoan
	{
        string tenND;
        public string TenND
        {
            get { return tenND; }
            set { tenND = value; }
        }
        string MK;
        public string mk
        {
            get { return MK; }
            set { MK = value; }
        }
        string GMAIL;
        public string gmail
        {
            get { return GMAIL; }
            set { GMAIL = value; }
        }
        public Taikhoan()
        {
            tenND = null;
            MK = null;
            GMAIL = null;
        }

        //public virtual void nhap()
        //{
        //    Console.WriteLine("=========Nhap thong tin========");
        //    Console.Write("Nhap ten nguoi dung: ");
        //    TenND = Console.ReadLine();
        //    Console.Write("Nhap mat khau : ");
        //    mk = Console.ReadLine();
        //    Console.Write("gmail: ");
        //    gmail = Console.ReadLine();

        //}

        //public virtual void xuat()
        //{
        //    Console.WriteLine("==============Xuat thong tin==============");
        //    Console.WriteLine("ten nguoi dung la:: " + TenND);
        //    Console.WriteLine("mat khau : " + mk);
        //    Console.WriteLine("gmail : " + gmail);
        //}
        
        
        
	}
}

