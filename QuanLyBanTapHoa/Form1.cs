using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace QuanLyBanTapHoa
{
    public partial class frmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(50, 52, 77);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
            
        }
        // MÀU CỦA RGB CỦA MENU
        private struct RGBColors
        {
            
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);


        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(50, 52, 77);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTepTin_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnTepTin_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }
    }
}
