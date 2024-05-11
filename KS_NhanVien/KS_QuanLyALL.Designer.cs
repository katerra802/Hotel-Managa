namespace OOP_project.KS_NhanVien
{
    partial class KS_QuanLyALL
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
            btn_nhansu = new Button();
            btn_phong = new Button();
            btn_danhthu = new Button();
            SuspendLayout();
            // 
            // btn_nhansu
            // 
            btn_nhansu.Font = new Font("Times New Roman", 10.2F);
            btn_nhansu.Location = new Point(2, 3);
            btn_nhansu.Name = "btn_nhansu";
            btn_nhansu.Size = new Size(81, 29);
            btn_nhansu.TabIndex = 0;
            btn_nhansu.Text = "Nhân sự";
            btn_nhansu.UseVisualStyleBackColor = true;
            btn_nhansu.Click += button1_Click;
            // 
            // btn_phong
            // 
            btn_phong.Font = new Font("Times New Roman", 10.2F);
            btn_phong.Location = new Point(82, 3);
            btn_phong.Name = "btn_phong";
            btn_phong.Size = new Size(81, 29);
            btn_phong.TabIndex = 1;
            btn_phong.Text = "Phòng";
            btn_phong.UseVisualStyleBackColor = true;
            btn_phong.Click += btn_phong_Click;
            // 
            // btn_danhthu
            // 
            btn_danhthu.Font = new Font("Times New Roman", 10.2F);
            btn_danhthu.Location = new Point(162, 3);
            btn_danhthu.Name = "btn_danhthu";
            btn_danhthu.Size = new Size(81, 29);
            btn_danhthu.TabIndex = 2;
            btn_danhthu.Text = "Danh thu";
            btn_danhthu.UseVisualStyleBackColor = true;
            btn_danhthu.Click += btn_danhthu_Click;
            // 
            // KS_QuanLyALL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1087, 666);
            Controls.Add(btn_danhthu);
            Controls.Add(btn_phong);
            Controls.Add(btn_nhansu);
            Name = "KS_QuanLyALL";
            Text = "KS_QuanLyALL";
            FormClosed += KS_QuanLyALL_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_nhansu;
        private Button btn_phong;
        private Button btn_danhthu;
    }
}