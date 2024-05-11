namespace OOP_project.KS_KhachHang
{
    partial class KS_TraPhong
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
            label2 = new Label();
            btn_xacNhanTraPhong = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(192, 86);
            label2.Name = "label2";
            label2.Size = new Size(789, 68);
            label2.TabIndex = 1;
            label2.Text = "Bạn có chắc muốn trả phòng?";
            // 
            // btn_xacNhanTraPhong
            // 
            btn_xacNhanTraPhong.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xacNhanTraPhong.ForeColor = Color.SteelBlue;
            btn_xacNhanTraPhong.Location = new Point(344, 214);
            btn_xacNhanTraPhong.Name = "btn_xacNhanTraPhong";
            btn_xacNhanTraPhong.Size = new Size(463, 86);
            btn_xacNhanTraPhong.TabIndex = 2;
            btn_xacNhanTraPhong.Text = "Xác nhận trả phòng";
            btn_xacNhanTraPhong.UseVisualStyleBackColor = true;
            btn_xacNhanTraPhong.Click += btn_xacNhanTraPhong_Click;
            // 
            // KS_TraPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 450);
            Controls.Add(btn_xacNhanTraPhong);
            Controls.Add(label2);
            Name = "KS_TraPhong";
            Text = "KS_TraPhong";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btn_xacNhanTraPhong;
    }
}