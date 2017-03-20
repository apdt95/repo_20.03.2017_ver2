namespace RSA
{
    partial class form_XacThuc
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_browse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_openFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_m = new System.Windows.Forms.RichTextBox();
            this.richTextBox_c = new System.Windows.Forms.RichTextBox();
            this.richTextBox_input = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_txt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.AutoSize = true;
            this.button_back.Location = new System.Drawing.Point(405, 553);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(94, 30);
            this.button_back.TabIndex = 17;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_luu
            // 
            this.button_luu.AutoSize = true;
            this.button_luu.Location = new System.Drawing.Point(202, 553);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(94, 30);
            this.button_luu.TabIndex = 18;
            this.button_luu.Text = "Lưu file";
            this.button_luu.UseVisualStyleBackColor = true;
            // 
            // button_browse
            // 
            this.button_browse.AutoSize = true;
            this.button_browse.Location = new System.Drawing.Point(561, 169);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(94, 30);
            this.button_browse.TabIndex = 19;
            this.button_browse.Text = "Browse...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 66);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kiểm tra XT m = c = c^e mod N (Kp của người cần XT)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_openFile
            // 
            this.textBox_openFile.Location = new System.Drawing.Point(234, 171);
            this.textBox_openFile.Name = "textBox_openFile";
            this.textBox_openFile.Size = new System.Drawing.Size(321, 27);
            this.textBox_openFile.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 63);
            this.label5.TabIndex = 7;
            this.label5.Text = "Xác thực c = m^(-1) mod N (Ks của người cần XT)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox_m
            // 
            this.richTextBox_m.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_m.Location = new System.Drawing.Point(234, 440);
            this.richTextBox_m.Name = "richTextBox_m";
            this.richTextBox_m.Size = new System.Drawing.Size(421, 94);
            this.richTextBox_m.TabIndex = 13;
            this.richTextBox_m.Text = "";
            // 
            // richTextBox_c
            // 
            this.richTextBox_c.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_c.Location = new System.Drawing.Point(234, 220);
            this.richTextBox_c.Name = "richTextBox_c";
            this.richTextBox_c.Size = new System.Drawing.Size(421, 94);
            this.richTextBox_c.TabIndex = 14;
            this.richTextBox_c.Text = "";
            // 
            // richTextBox_input
            // 
            this.richTextBox_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_input.Location = new System.Drawing.Point(234, 52);
            this.richTextBox_input.Name = "richTextBox_input";
            this.richTextBox_input.Size = new System.Drawing.Size(421, 94);
            this.richTextBox_input.TabIndex = 12;
            this.richTextBox_input.Text = "";
            
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 46);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mở văn bản cần kiểm tra XT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 48);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mở plain text file cần xác thực";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 57);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập input text cần xác thực";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "XÁC THỰC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // richTextBox_txt
            // 
            this.richTextBox_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_txt.Location = new System.Drawing.Point(234, 334);
            this.richTextBox_txt.Name = "richTextBox_txt";
            this.richTextBox_txt.Size = new System.Drawing.Size(421, 87);
            this.richTextBox_txt.TabIndex = 12;
            this.richTextBox_txt.Text = "";
            // 
            // form_XacThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 594);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_browse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_openFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox_m);
            this.Controls.Add(this.richTextBox_c);
            this.Controls.Add(this.richTextBox_txt);
            this.Controls.Add(this.richTextBox_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "form_XacThuc";
            this.Text = "Xác thực";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_openFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_m;
        private System.Windows.Forms.RichTextBox richTextBox_c;
        private System.Windows.Forms.RichTextBox richTextBox_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_txt;


    }
}