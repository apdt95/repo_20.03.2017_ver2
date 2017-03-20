namespace RSA
{
    partial class Form_main
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
            this.exit = new System.Windows.Forms.Button();
            this.xacthuc = new System.Windows.Forms.Button();
            this.baomat = new System.Windows.Forms.Button();
            this.taokhoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(0, 149);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(433, 53);
            this.exit.TabIndex = 3;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // xacthuc
            // 
            this.xacthuc.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xacthuc.Location = new System.Drawing.Point(300, 23);
            this.xacthuc.Name = "xacthuc";
            this.xacthuc.Size = new System.Drawing.Size(112, 105);
            this.xacthuc.TabIndex = 2;
            this.xacthuc.Text = "Xác thực";
            this.xacthuc.UseVisualStyleBackColor = true;
            this.xacthuc.Click += new System.EventHandler(this.xacthuc_Click);
            // 
            // baomat
            // 
            this.baomat.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baomat.Location = new System.Drawing.Point(161, 23);
            this.baomat.Name = "baomat";
            this.baomat.Size = new System.Drawing.Size(112, 105);
            this.baomat.TabIndex = 1;
            this.baomat.Text = "Bảo mật";
            this.baomat.UseVisualStyleBackColor = true;
            this.baomat.Click += new System.EventHandler(this.baomat_Click);
            // 
            // taokhoa
            // 
            this.taokhoa.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taokhoa.Location = new System.Drawing.Point(22, 23);
            this.taokhoa.Name = "taokhoa";
            this.taokhoa.Size = new System.Drawing.Size(112, 105);
            this.taokhoa.TabIndex = 0;
            this.taokhoa.Text = "Tạo khóa";
            this.taokhoa.UseVisualStyleBackColor = true;
            this.taokhoa.Click += new System.EventHandler(this.taokhoa_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 202);
            this.Controls.Add(this.taokhoa);
            this.Controls.Add(this.baomat);
            this.Controls.Add(this.xacthuc);
            this.Controls.Add(this.exit);
            this.Name = "Form_main";
            this.Text = "RSA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button xacthuc;
        private System.Windows.Forms.Button baomat;
        private System.Windows.Forms.Button taokhoa;
    }
}