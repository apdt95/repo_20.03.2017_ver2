using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn thoát?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
                this.Close();
        }

        private void taokhoa_Click(object sender, EventArgs e)
        {
            var Form_sinhkhoa = new Form_sinhkhoa();
            Form_sinhkhoa.Show();
        }

        private void baomat_Click(object sender, EventArgs e)
        {
            var Form_baomat = new form_BaoMat();
            Form_baomat.Show();
        }

        private void xacthuc_Click(object sender, EventArgs e)
        {
            var Form_xacthuc = new form_XacThuc();
            Form_xacthuc.Show();
        }
    }
}
