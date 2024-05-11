namespace OOP_project.KS_NhanVien
{
    partial class KS_DichVuNVBT
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
            SuspendLayout();
            // 
            // btn_nhansu
            // 
            btn_nhansu.Font = new Font("Times New Roman", 10.2F);
            btn_nhansu.Location = new Point(0, 2);
            btn_nhansu.Name = "btn_nhansu";
            btn_nhansu.Size = new Size(100, 44);
            btn_nhansu.TabIndex = 3;
            btn_nhansu.Text = "Thông tin";
            btn_nhansu.UseVisualStyleBackColor = true;
            btn_nhansu.Click += btn_nhansu_Click;
            // 
            // btn_phong
            // 
            btn_phong.Font = new Font("Times New Roman", 10.2F);
            btn_phong.Location = new Point(100, 2);
            btn_phong.Name = "btn_phong";
            btn_phong.Size = new Size(109, 44);
            btn_phong.TabIndex = 4;
            btn_phong.Text = "Lịch làm";
            btn_phong.UseVisualStyleBackColor = true;
            btn_phong.Click += btn_phong_Click;
            // 
            // KS_DichVuNVBT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 514);
            Controls.Add(btn_phong);
            Controls.Add(btn_nhansu);
            Name = "KS_DichVuNVBT";
            Text = "KS_DichVuNVBT";
            FormClosed += KS_DichVuNVBT_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_nhansu;
        private Button btn_phong;
    }
}