using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanTapHoa
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

             // đổi màu chổ này
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(18, 194, 233), Color.FromArgb(196, 113, 237), 237);
       
            graphics.FillRectangle(b, gradient_rectangle);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(set_background); // mau gradient
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Visible = false;
            main.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cbxPhanQyen_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (kq == DialogResult.OK)
                    this.Close();
        }
    }
}
