namespace OOP_project
{
    partial class KS_DichVuKH
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
            dangxuat = new Button();
            datPhong = new Button();
            traPhong = new Button();
            thongTinPhong = new Button();
            thoat = new Button();
            panelContent = new Panel();
            SuspendLayout();
            // 
            // dangxuat
            // 
            dangxuat.BackColor = Color.Transparent;
            dangxuat.FlatAppearance.BorderSize = 0;
            dangxuat.FlatStyle = FlatStyle.Flat;
            dangxuat.Font = new Font("Times New Roman", 15F);
            dangxuat.Location = new Point(578, 9);
            dangxuat.Name = "dangxuat";
            dangxuat.Size = new Size(180, 58);
            dangxuat.TabIndex = 0;
            dangxuat.Text = "Đăng xuất";
            dangxuat.UseVisualStyleBackColor = false;
            dangxuat.Click += button1_Click;
            // 
            // datPhong
            // 
            datPhong.BackColor = Color.Transparent;
            datPhong.FlatAppearance.BorderColor = SystemColors.Menu;
            datPhong.FlatAppearance.BorderSize = 0;
            datPhong.FlatStyle = FlatStyle.Flat;
            datPhong.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datPhong.Location = new Point(198, 11);
            datPhong.Name = "datPhong";
            datPhong.Size = new Size(184, 57);
            datPhong.TabIndex = 1;
            datPhong.Text = "Đặt Phòng Online";
            datPhong.UseVisualStyleBackColor = false;
            datPhong.Click += button2_Click;
            // 
            // traPhong
            // 
            traPhong.BackColor = Color.Transparent;
            traPhong.FlatAppearance.BorderSize = 0;
            traPhong.FlatAppearance.MouseDownBackColor = Color.White;
            traPhong.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            traPhong.FlatStyle = FlatStyle.Flat;
            traPhong.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            traPhong.Location = new Point(388, 10);
            traPhong.Name = "traPhong";
            traPhong.Size = new Size(184, 57);
            traPhong.TabIndex = 3;
            traPhong.Text = "Trả phòng";
            traPhong.UseVisualStyleBackColor = false;
            traPhong.Click += traPhong_Click;
            // 
            // thongTinPhong
            // 
            thongTinPhong.BackColor = Color.White;
            thongTinPhong.FlatAppearance.BorderColor = Color.Black;
            thongTinPhong.FlatAppearance.BorderSize = 0;
            thongTinPhong.FlatStyle = FlatStyle.Flat;
            thongTinPhong.Font = new Font("Times New Roman", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            thongTinPhong.ForeColor = Color.SteelBlue;
            thongTinPhong.ImageAlign = ContentAlignment.MiddleRight;
            thongTinPhong.Location = new Point(8, 12);
            thongTinPhong.Name = "thongTinPhong";
            thongTinPhong.Size = new Size(184, 58);
            thongTinPhong.TabIndex = 4;
            thongTinPhong.Text = "Thông tin phòng";
            thongTinPhong.UseVisualStyleBackColor = false;
            thongTinPhong.Click += thongTinPhong_Click;
            // 
            // thoat
            // 
            thoat.BackColor = Color.Transparent;
            thoat.FlatAppearance.BorderSize = 0;
            thoat.FlatStyle = FlatStyle.Flat;
            thoat.Font = new Font("Times New Roman", 15F);
            thoat.Location = new Point(764, 9);
            thoat.Name = "thoat";
            thoat.Size = new Size(187, 58);
            thoat.TabIndex = 5;
            thoat.Text = "Thoát";
            thoat.UseVisualStyleBackColor = false;
            thoat.Click += button6_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.ForeColor = Color.Black;
            panelContent.Location = new Point(8, 64);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1133, 497);
            panelContent.TabIndex = 6;
            // 
            // KS_DichVuKS
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1149, 569);
            Controls.Add(panelContent);
            Controls.Add(thoat);
            Controls.Add(thongTinPhong);
            Controls.Add(traPhong);
            Controls.Add(datPhong);
            Controls.Add(dangxuat);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Transparent;
            Name = "KS_DichVuKS";
            Text = "Device_customer";
            FormClosed += Device_customer_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button dangxuat;
        private Button datPhong;
        private Button traPhong;
        private Button thongTinPhong;
        private Button thoat;
        private Panel panelContent;
    }
}