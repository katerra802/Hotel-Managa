using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project.KS_KhachHang
{
    public partial class KS_TraPhong : Form
    {
        private Danhsachphong ds = null;
        private KS_DichVuKH f = null;
        public KS_TraPhong(KS_DichVuKH f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btn_xacNhanTraPhong_Click(object sender, EventArgs e)
        {
            f.xacNhanTraPhong();
        }
    }
}
