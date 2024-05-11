using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;
using OOP_project.Phong;

namespace OOP_project
{
    public partial class KS_ChonPhong : Form
    {
        private KS_DatPhong bkin;
        private Danhsachphong dsp = null;
        DBC.DBCInformation find = new DBC.DBCInformation();
        public KS_ChonPhong(KS_DatPhong bkin)
        {
            InitializeComponent();
            this.bkin = bkin;
            dsp = find.DSPhong("select * from PHONG");
            undisableBTN();
        }

        public string loaiPhong(string s)
        {
            int c = s.Length - 1;
            if (s[c] == '1' || s[c] == '4')
                return "Đơn";
            return "Đôi";
        }

        public string giaPhong(string s)
        {
            int c = s.Length - 1;
            if (s[c] == '1' || s[c] == '4')
                return "150000";
            return "300000";
        }

        public void nhapTTTD(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bkin.UpdateInfRoom("KS-" + bt.Text, loaiPhong(bt.Text), giaPhong(bt.Text), bt.Text);
            this.Close();
        }

        public void undisableBTN()
        {
            if(this.dsp != null)
            {
                foreach (Phong.Phong pn in dsp.Dsp)
                {
                    string s = pn.maPhong.Substring(3, 4);

                    switch (s)
                    {
                        case "A101":
                            changeStatebtn(a101);
                            break;

                        case "A102":
                            changeStatebtn(a102);
                            break;

                        case "B103":
                            changeStatebtn(b103);
                            break;

                        case "B104":
                            changeStatebtn(b104);
                            break;

                        case "A201":
                            changeStatebtn(a201);
                            break;

                        case "A202":
                            changeStatebtn(a202);
                            break;

                        case "B203":
                            changeStatebtn(b203);
                            break;

                        case "B204":
                            changeStatebtn(b204);
                            break;

                        case "A301":
                            changeStatebtn(a301);
                            break;

                        case "A302":
                            changeStatebtn(a302);
                            break;

                        case "B303":
                            changeStatebtn(b303);
                            break;

                        case "B304":
                            changeStatebtn(b304);
                            break;

                        case "A401":
                            changeStatebtn(a402);
                            break;

                        case "A402":
                            changeStatebtn(a402);
                            break;

                        case "B403":
                            changeStatebtn(b403);
                            break;

                        case "B404":
                            changeStatebtn(b404);
                            break;

                        case "A501":
                            changeStatebtn(a501);
                            break;

                        case "A502":
                            changeStatebtn(a502);
                            break;

                        case "B503":
                            changeStatebtn(b503);
                            break;

                        case "B504":
                            changeStatebtn(b504);
                            break;

                    }
                }
            }
        }

        public void changeStatebtn(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = Color.Gray;
        }

        private void Room_detail_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
