namespace OOP_project
{
    partial class KS_TaotaikhoanKH
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_tentk = new TextBox();
            txt_cccd = new TextBox();
            txt_mk = new TextBox();
            txt_nlmk = new TextBox();
            label5 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            txt_gmail = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(111, 401);
            button1.Name = "button1";
            button1.Size = new Size(205, 41);
            button1.TabIndex = 0;
            button1.Text = "Tạo Tài Khoản";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 10.8F);
            label1.Location = new Point(23, 86);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 10.8F);
            label2.Location = new Point(23, 139);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "CCCD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.8F);
            label3.Location = new Point(23, 250);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.8F);
            label4.Location = new Point(23, 303);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 4;
            label4.Text = "Nhập Lại Mật Khẩu:";
            // 
            // txt_tentk
            // 
            txt_tentk.Location = new Point(187, 86);
            txt_tentk.Name = "txt_tentk";
            txt_tentk.Size = new Size(220, 27);
            txt_tentk.TabIndex = 5;
            // 
            // txt_cccd
            // 
            txt_cccd.Location = new Point(187, 136);
            txt_cccd.Name = "txt_cccd";
            txt_cccd.Size = new Size(220, 27);
            txt_cccd.TabIndex = 6;
            // 
            // txt_mk
            // 
            txt_mk.Location = new Point(187, 243);
            txt_mk.Name = "txt_mk";
            txt_mk.Size = new Size(220, 27);
            txt_mk.TabIndex = 7;
            // 
            // txt_nlmk
            // 
            txt_nlmk.Location = new Point(187, 296);
            txt_nlmk.Name = "txt_nlmk";
            txt_nlmk.Size = new Size(220, 27);
            txt_nlmk.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(121, 31);
            label5.Name = "label5";
            label5.Size = new Size(217, 33);
            label5.TabIndex = 9;
            label5.Text = "Katera Hotel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(96, 360);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 10;
            label6.Text = "Bạn đã có tài khoản?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(263, 360);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(87, 20);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng nhập";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txt_gmail
            // 
            txt_gmail.Location = new Point(187, 189);
            txt_gmail.Name = "txt_gmail";
            txt_gmail.Size = new Size(220, 27);
            txt_gmail.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Times New Roman", 10.8F);
            label7.Location = new Point(23, 192);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 12;
            label7.Text = "Gmail:";
            // 
            // KS_TaotaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 470);
            Controls.Add(txt_gmail);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_nlmk);
            Controls.Add(txt_mk);
            Controls.Add(txt_cccd);
            Controls.Add(txt_tentk);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "KS_TaotaiKhoan";
            Text = "New_account";
            FormClosed += New_account_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_tentk;
        private TextBox txt_cccd;
        private TextBox txt_mk;
        private TextBox txt_nlmk;
        private Label label5;
        private Label label6;
        private LinkLabel linkLabel1;
        private TextBox txt_gmail;
        private Label label7;
    }
}