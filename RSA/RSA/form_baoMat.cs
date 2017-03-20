using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RSA
{
    public partial class form_BaoMat : Form
    {
        public form_BaoMat()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Mở file text...";
            fd.InitialDirectory = @"D:\";
            fd.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBox_openFile.Text = fd.FileName;
                StreamReader file = new StreamReader(fd.FileName);
                richTextBox_input.Text = file.ReadToEnd();
                file.Close();
            }
        }

        
    }
}
