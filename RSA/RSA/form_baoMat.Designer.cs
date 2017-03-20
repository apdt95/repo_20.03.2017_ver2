namespace RSA
{
    partial class form_BaoMat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_openFile = new System.Windows.Forms.TextBox();
            this.button_browse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox_c = new System.Windows.Forms.RichTextBox();
            this.richTextBox_m = new System.Windows.Forms.RichTextBox();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢO MẬT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập input text:";
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_input.Location = new System.Drawing.Point(228, 47);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(415, 94);
            this.richTextBox_input.TabIndex = 2;
            this.richTextBox_input.Text = "";
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mở plain text file:";
            // 
            // textBox_openFile
            // 
            this.textBox_openFile.Location = new System.Drawing.Point(228, 159);
            this.textBox_openFile.Name = "textBox_openFile";
            this.textBox_openFile.Size = new System.Drawing.Size(315, 27);
            this.textBox_openFile.TabIndex = 3;
            // 
            // button_browse
            // 
            this.button_browse.AutoSize = true;
            this.button_browse.Location = new System.Drawing.Point(549, 157);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(94, 30);
            this.button_browse.TabIndex = 4;
            this.button_browse.Text = "Browse...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 46);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhập khóa Kp (bên nhận)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 203);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 27);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã hóa c = m^e mod N";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 66);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giải mật m = c^d mod N (dùng Ks của bên nhận)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox_c
            // 
            this.richTextBox_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_c.Location = new System.Drawing.Point(228, 260);
            this.richTextBox_c.Name = "richTextBox_c";
            this.richTextBox_c.Size = new System.Drawing.Size(415, 94);
            this.richTextBox_c.TabIndex = 2;
            this.richTextBox_c.Text = "";
            
            // 
            // richTextBox_m
            // 
            this.richTextBox_m.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_m.Location = new System.Drawing.Point(228, 368);
            this.richTextBox_m.Name = "richTextBox_m";
            this.richTextBox_m.Size = new System.Drawing.Size(415, 94);
            this.richTextBox_m.TabIndex = 2;
            this.richTextBox_m.Text = "";
            
            // 
            // button_luu
            // 
            this.button_luu.AutoSize = true;
            this.button_luu.Location = new System.Drawing.Point(179, 482);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(94, 30);
            this.button_luu.TabIndex = 4;
            this.button_luu.Text = "Lưu file";
            this.button_luu.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.AutoSize = true;
            this.button_back.Location = new System.Drawing.Point(382, 482);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(94, 30);
            this.button_back.TabIndex = 4;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // form_BaoMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 524);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_openFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_m);
            this.Controls.Add(this.richTextBox_c);
            this.Controls.Add(this.richTextBox_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_BaoMat";
            this.Text = "Bảo mật";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_openFile;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox_c;
        private System.Windows.Forms.RichTextBox richTextBox_m;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_back;

    }
}

