namespace RSA
{
    partial class Form_sinhkhoa
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
            this.n_nt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_p = new System.Windows.Forms.Button();
            this.button_q = new System.Windows.Forms.Button();
            this.button_e = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.n_text = new System.Windows.Forms.TextBox();
            this.phi_text = new System.Windows.Forms.TextBox();
            this.d_text = new System.Windows.Forms.TextBox();
            this.kp_text = new System.Windows.Forms.TextBox();
            this.ks_text = new System.Windows.Forms.TextBox();
            this.button_luuKhoa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.button_taoKhoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n_nt
            // 
            this.n_nt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_nt.Location = new System.Drawing.Point(99, 64);
            this.n_nt.Name = "n_nt";
            this.n_nt.Size = new System.Drawing.Size(100, 29);
            this.n_nt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập N:";
            // 
            // button_p
            // 
            this.button_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_p.Location = new System.Drawing.Point(205, 180);
            this.button_p.Name = "button_p";
            this.button_p.Size = new System.Drawing.Size(75, 35);
            this.button_p.TabIndex = 3;
            this.button_p.Text = "=> p";
            this.button_p.UseVisualStyleBackColor = true;
            this.button_p.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_q
            // 
            this.button_q.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_q.Location = new System.Drawing.Point(205, 254);
            this.button_q.Name = "button_q";
            this.button_q.Size = new System.Drawing.Size(75, 35);
            this.button_q.TabIndex = 3;
            this.button_q.Text = "=> q";
            this.button_q.UseVisualStyleBackColor = true;
            this.button_q.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_e
            // 
            this.button_e.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_e.Location = new System.Drawing.Point(205, 328);
            this.button_e.Name = "button_e";
            this.button_e.Size = new System.Drawing.Size(75, 35);
            this.button_e.TabIndex = 3;
            this.button_e.Text = "=> e";
            this.button_e.UseVisualStyleBackColor = true;
            this.button_e.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(812, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "N = p * q =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "ɸ(N) = (p-1) * (q-1) =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "d = e^(-1) mod ɸ =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(559, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Khóa Kp =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(561, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Khóa Ks =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(446, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 45);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sinh khóa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(267, 45);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tạo số nguyên tố";
            // 
            // n_text
            // 
            this.n_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.n_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_text.Location = new System.Drawing.Point(647, 110);
            this.n_text.Name = "n_text";
            this.n_text.Size = new System.Drawing.Size(100, 26);
            this.n_text.TabIndex = 1;
            this.n_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phi_text
            // 
            this.phi_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phi_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phi_text.Location = new System.Drawing.Point(647, 167);
            this.phi_text.Name = "phi_text";
            this.phi_text.Size = new System.Drawing.Size(100, 26);
            this.phi_text.TabIndex = 2;
            this.phi_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // d_text
            // 
            this.d_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.d_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_text.Location = new System.Drawing.Point(647, 224);
            this.d_text.Name = "d_text";
            this.d_text.Size = new System.Drawing.Size(100, 26);
            this.d_text.TabIndex = 4;
            this.d_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kp_text
            // 
            this.kp_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kp_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kp_text.Location = new System.Drawing.Point(647, 281);
            this.kp_text.Name = "kp_text";
            this.kp_text.Size = new System.Drawing.Size(100, 26);
            this.kp_text.TabIndex = 5;
            this.kp_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ks_text
            // 
            this.ks_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ks_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ks_text.Location = new System.Drawing.Point(647, 338);
            this.ks_text.Name = "ks_text";
            this.ks_text.Size = new System.Drawing.Size(100, 26);
            this.ks_text.TabIndex = 6;
            this.ks_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_luuKhoa
            // 
            this.button_luuKhoa.AutoSize = true;
            this.button_luuKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luuKhoa.Location = new System.Drawing.Point(454, 417);
            this.button_luuKhoa.Name = "button_luuKhoa";
            this.button_luuKhoa.Size = new System.Drawing.Size(100, 34);
            this.button_luuKhoa.TabIndex = 7;
            this.button_luuKhoa.Text = "Lưu khóa";
            this.button_luuKhoa.UseVisualStyleBackColor = true;
            this.button_luuKhoa.Click += new System.EventHandler(this.button_luuKhoa_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(205, 65);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 7;
            this.button5.Text = "Tạo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // list
            // 
            this.list.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.list.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.Location = new System.Drawing.Point(30, 110);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(167, 341);
            this.list.TabIndex = 8;
            this.list.UseCompatibleStateImageBehavior = false;
            // 
            // button_taoKhoa
            // 
            this.button_taoKhoa.AutoSize = true;
            this.button_taoKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_taoKhoa.Location = new System.Drawing.Point(285, 417);
            this.button_taoKhoa.Name = "button_taoKhoa";
            this.button_taoKhoa.Size = new System.Drawing.Size(96, 34);
            this.button_taoKhoa.TabIndex = 4;
            this.button_taoKhoa.Text = "Tạo khóa";
            this.button_taoKhoa.UseVisualStyleBackColor = true;
            this.button_taoKhoa.Click += new System.EventHandler(this.button_taoKhoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "e =";
            // 
            // textBox_e
            // 
            this.textBox_e.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_e.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_e.Location = new System.Drawing.Point(361, 209);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(84, 26);
            this.textBox_e.TabIndex = 3;
            this.textBox_e.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(321, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 21);
            this.label10.TabIndex = 4;
            this.label10.Text = "q =";
            // 
            // textBox_q
            // 
            this.textBox_q.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_q.Location = new System.Drawing.Point(361, 160);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(84, 26);
            this.textBox_q.TabIndex = 2;
            this.textBox_q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(321, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 21);
            this.label13.TabIndex = 4;
            this.label13.Text = "p =";
            // 
            // textBox_p
            // 
            this.textBox_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_p.Location = new System.Drawing.Point(361, 111);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(84, 26);
            this.textBox_p.TabIndex = 1;
            this.textBox_p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_back
            // 
            this.button_back.AutoSize = true;
            this.button_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(627, 420);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(94, 31);
            this.button_back.TabIndex = 9;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // Form_sinhkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 474);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_taoKhoa);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_luuKhoa);
            this.Controls.Add(this.ks_text);
            this.Controls.Add(this.d_text);
            this.Controls.Add(this.kp_text);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_e);
            this.Controls.Add(this.phi_text);
            this.Controls.Add(this.n_text);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_e);
            this.Controls.Add(this.button_q);
            this.Controls.Add(this.button_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_nt);
            this.Name = "Form_sinhkhoa";
            this.Text = "Tạo khóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n_nt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_p;
        private System.Windows.Forms.Button button_q;
        private System.Windows.Forms.Button button_e;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox n_text;
        private System.Windows.Forms.TextBox phi_text;
        private System.Windows.Forms.TextBox d_text;
        private System.Windows.Forms.TextBox kp_text;
        private System.Windows.Forms.TextBox ks_text;
        private System.Windows.Forms.Button button_luuKhoa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button button_taoKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Button button_back;
    }
}

