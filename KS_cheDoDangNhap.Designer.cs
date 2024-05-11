namespace OOP_project
{
    partial class KS_cheDoDangNhap
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
            btn_KH = new Button();
            btn_NV = new Button();
            SuspendLayout();
            // 
            // btn_KH
            // 
            btn_KH.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold);
            btn_KH.Location = new Point(58, 106);
            btn_KH.Name = "btn_KH";
            btn_KH.Size = new Size(207, 64);
            btn_KH.TabIndex = 0;
            btn_KH.Text = "Khách hàng";
            btn_KH.UseVisualStyleBackColor = true;
            btn_KH.Click += btn_KH_Click;
            // 
            // btn_NV
            // 
            btn_NV.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold);
            btn_NV.Location = new Point(330, 106);
            btn_NV.Name = "btn_NV";
            btn_NV.Size = new Size(207, 64);
            btn_NV.TabIndex = 1;
            btn_NV.Text = "Nhân viên";
            btn_NV.UseVisualStyleBackColor = true;
            btn_NV.Click += btn_NV_Click;
            // 
            // KS_cheDoDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 296);
            Controls.Add(btn_NV);
            Controls.Add(btn_KH);
            Name = "KS_cheDoDangNhap";
            Text = "KS_cheDoDangNhap";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_KH;
        private Button btn_NV;
    }
}