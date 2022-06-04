namespace QuanLyBanTapHoa
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBaoCao = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnDanhMuc = new FontAwesome.Sharp.IconButton();
            this.btnTepTin = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.panelMenu.Controls.Add(this.btnBaoCao);
            this.panelMenu.Controls.Add(this.btnTimKiem);
            this.panelMenu.Controls.Add(this.btnHoaDon);
            this.panelMenu.Controls.Add(this.btnDanhMuc);
            this.panelMenu.Controls.Add(this.btnTepTin);
            this.panelMenu.Controls.Add(this.btnTrangChu);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(198, 496);
            this.panelMenu.TabIndex = 4;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBaoCao.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnBaoCao.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaoCao.IconSize = 25;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 338);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(198, 55);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 25;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 283);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(198, 55);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnHoaDon.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaDon.IconSize = 25;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 228);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(198, 55);
            this.btnHoaDon.TabIndex = 3;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhMuc.FlatAppearance.BorderSize = 0;
            this.btnDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDanhMuc.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnDanhMuc.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnDanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDanhMuc.IconSize = 25;
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.Location = new System.Drawing.Point(0, 173);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(198, 55);
            this.btnDanhMuc.TabIndex = 2;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnTepTin
            // 
            this.btnTepTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTepTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTepTin.FlatAppearance.BorderSize = 0;
            this.btnTepTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTepTin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTepTin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTepTin.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.btnTepTin.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTepTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTepTin.IconSize = 25;
            this.btnTepTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTepTin.Location = new System.Drawing.Point(0, 118);
            this.btnTepTin.Name = "btnTepTin";
            this.btnTepTin.Size = new System.Drawing.Size(198, 55);
            this.btnTepTin.TabIndex = 1;
            this.btnTepTin.Text = "Tệp tin";
            this.btnTepTin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTepTin.UseVisualStyleBackColor = true;
            this.btnTepTin.Click += new System.EventHandler(this.btnTepTin_Click_1);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnTrangChu.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangChu.IconSize = 25;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 63);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(198, 55);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 63);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(102)))), ((int)(((byte)(113)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(198, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 63);
            this.panel1.TabIndex = 6;
            // 
            // picHome
            // 
            this.picHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(0, 0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(198, 63);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(77)))), ((int)(((byte)(107)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(792, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Bán Tạp Hóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnBaoCao;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnDanhMuc;
        private FontAwesome.Sharp.IconButton btnTepTin;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picHome;
    }
}

