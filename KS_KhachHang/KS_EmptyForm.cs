using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project.KS_KhachHang
{
    public partial class KS_EmptyForm : Form
    {
        public KS_EmptyForm(string txt)
        {
            InitializeComponent();
            label1.Text = txt;
        }
    }
}
