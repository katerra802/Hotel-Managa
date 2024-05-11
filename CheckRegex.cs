using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP_project
{
    public class CheckRegex
    {
        public bool checkTenDangNhap(string s)
        {
            Regex regex = new Regex("^[A-Za-z0-9_]+");

            return regex.IsMatch(s);
        }

        public bool checkCCCD(string s)
        {
            Regex regex = new Regex("^[0-9]{12}$");

            return regex.IsMatch(s);
        }

        public bool checkGmail(string s)
        {
            Regex regex = new Regex(@"^[A-Za-z0-9._%+-]+@[a-z]+\.[a-z]+$");

            return regex.IsMatch(s);
        }

        public bool checkMaNV(string s)
        {
            Regex regex = new Regex(@"^[QL || BT]+\d{3}$");
            return regex.IsMatch(s);
        }

        public bool checkTG2so(string s)
        {
            Regex regex = new Regex(@"^[0-9]{0,2}$");
            return regex.IsMatch(s);
        }

        public bool checkTG4so(string s)
        {
            Regex regex = new Regex(@"^[0-9]{0,4}$");
            return regex.IsMatch(s);
        }
    }
}
